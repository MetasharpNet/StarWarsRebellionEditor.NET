#!/usr/bin/env python3
"""
Rebellion Save File Parser
==========================

Parses Star Wars: Rebellion save files (SAVEGAME.001-009).
Returns structured data: save name, entities (units, characters, buildings),
events, and message log records.

Based on reverse engineering documented in generated/types/SAVE_FILE_FORMAT_v2.md

Usage:
    from rebellion_save_parser import RebellionSave

    save = RebellionSave.load("SAVEGAME.001")
    print(f"Save: {save.name}")
    print(f"Entities: {len(save.entities)}")
    for entity in save.entities:
        print(f"  {entity.type_name} '{entity.name}' (faction: {entity.faction_name})")

Status: Partial — extracts named records and metadata. Day counter and
resource values still need RE work.
"""

import struct
from dataclasses import dataclass, field
from pathlib import Path
from typing import List, Dict, Optional


# === Type IDs (from RE analysis) ===

# Entity types - keyed by LOW 16 bits of full ID
# (savegame records store the abbreviated form)
# Source: Identifiers.cs from MetasharpNet/StarWarsRebellionEditor.NET
# NOTE: To properly disambiguate we need to know the family byte.
# When count of records matches CAPSHPSD/MJCHARSD entries, prefer those names.
ENTITY_TYPES = {
    # Container/special — Fleet (used internally as a unit container)
    0x04: 'Fleet',  # in saves this is overwhelmingly Fleet containers

    # Capital ships (full IDs are 0x14XXXXXX) — main expected matches
    0x40: 'Mon_Calamari_Cruiser',
    0x41: 'Bulk_Cruiser',
    0x42: 'Assault_Frigate',
    0x43: 'Nebulon-B_Frigate',
    0x44: 'Alliance_Escort_Carrier',
    0x45: 'Corellian_Corvette',
    0x46: 'Medium_Transport',
    0x47: 'Bulk_Transport',
    0x48: 'Corellian_Gunship',
    0x49: 'Alliance_Dreadnaught',
    0x4A: 'CC-7700_Frigate',
    0x4B: 'Bulwark_Battlecruiser',
    0x4C: 'Liberator_Cruiser',
    0x4D: 'CC-9600_Frigate',
    0x4E: 'Dauntless_Cruiser',
    0x80: 'Strike_Cruiser',
    0x81: 'Lancer_Frigate',
    0x82: 'Interdictor_Cruiser',
    0x83: 'Carrack_Light_Cruiser',
    0x84: 'Victory_Destroyer',
    0x85: 'Imperial_Star_Destroyer',
    0x86: 'Super_Star_Destroyer',
    0x87: 'Assault_Transport',
    0x88: 'Death_Star',  # full 0x18000088
    0x89: 'Galleon',
    0x8A: 'Victory_II_Star_Destroyer',
    0x8B: 'Imperial_II_Star_Destroyer',
    0x8C: 'Star_Galleon',
    0x8D: 'Imperial_Escort_Carrier',
    0x8E: 'Imperial_Dreadnaught',

    # Major Alliance characters
    0x240: 'Mon_Mothma',
    0x241: 'Leia_Organa',
    0x242: 'Luke_Skywalker',
    0x243: 'Han_Solo',

    # Major Empire characters
    0x280: 'Emperor_Palpatine',
    0x281: 'Darth_Vader',

    # Minor Alliance characters (family 0x38, low 0x340-0x35F)
    0x340: 'Ackbar', 0x341: 'Wedge_Antilles', 0x342: 'Lando_Calrissian',
    0x343: 'Chewbacca', 0x344: 'Jan_Dodonna', 0x345: 'Crix_Madine',
    0x346: 'Carlist_Rieekan', 0x347: 'Afyon', 0x348: 'Drayson',
    0x349: 'Borsk_Feylya', 0x34A: 'Tura_Raftican', 0x34B: 'Bren_Derlin',
    0x34C: 'Garm_Bel_Iblis', 0x34D: 'Talon_Karrde', 0x34E: 'Narra',
    0x34F: 'Huoba_Neva', 0x350: 'Page', 0x351: 'Syub_Snunb',
    0x352: 'Adar_Tallon', 0x353: 'Sarin_Virgilio', 0x354: 'Vanden_Willard',
    0x355: 'Roget_Jiriss', 0x356: 'Kaiya_Andrimetrum', 0x357: 'Mazer_Rackus',
    0x358: 'Orrimaarko', 0x359: 'Mawshiye',

    # Minor Empire characters (family 0x38, low 0x380-0x39F)
    0x380: 'Jerjerrod', 0x381: 'Ozzel', 0x382: 'Piett', 0x383: 'Veers',
    0x384: 'Brandei',  # IS Empire, not Alliance!
    0x385: 'Covell', 0x386: 'Dorja', 0x387: 'Bin_Essada',
    0x388: 'Niles_Ferrier', 0x389: 'Grammel', 0x38A: 'Griff',
    0x38B: 'Klev', 0x38C: 'Needa', 0x38D: 'Bane_Nothos',
    0x38E: 'Orlok', 0x38F: 'Pellaeon', 0x390: 'Screed',
    0x391: 'Thrawn', 0x392: 'Zuggs', 0x393: 'Daala',
    0x394: 'Pter_Thanas', 0x395: 'Bevel_Lemelisk', 0x396: 'Shenir_Rix',
    0x397: 'Noval_Garaint', 0x398: 'Garindan', 0x399: 'Menndo',
    0x39A: 'Labansat', 0x39B: 'Villar',

    # Facilities (low 2 bytes — ambiguous without family byte, prefixed with FAC_)
    # 0x0001: Alliance_HQ / Orbital_Shipyard / Mine — disambiguate by family
    # 0x0003: Construction_Yard
    # These are commented out to avoid collisions with Capital Ship IDs above

    # System IDs (low 2 bytes for systems, high byte 0x90/0x92)
    0x0109: 'System_Coruscant',  # 0x90000109
    0x0121: 'System_Yavin',      # 0x92000121
}

# Special forces (family 0x3C)
SPECIAL_FORCES = {
    0x01: 'Guerillas', 0x02: 'Infiltrators', 0x03: 'Longprobe_Y-wing_Recon_Team',
    0x04: 'Bothan_Spies', 0x05: 'Imperial_Probe_Droid', 0x06: 'Imperial_Espionage_Droid',
    0x07: 'Imperial_Commandos', 0x08: 'Noghri_Death_Commandos', 0x09: 'Bounty_Hunters',
}

# Missions (high byte families)
MISSIONS = {
    0x41: 'Move', 0x42: 'Return', 0x43: 'Autorouting', 0x44: 'Adrift',
    0x51: 'Diplomacy', 0x52: 'Espionage', 0x53: 'Research',
    0x54: 'Reconnaissance', 0x55: 'Recruitment',
    0x56: 'Incite_Uprising', 0x57: 'Subdue_Uprising', 0x58: 'Jedi_Training',
    0x61: 'Rescue', 0x62: 'Abduction', 0x63: 'Assassination',
    0x64: 'Palace', 0x65: 'Bounty', 0x69: 'Sabotage', 0x6A: 'DeathStar_Sabotage',
    0x71: 'Dagobah', 0x72: 'Vacation/Sabbatical', 0x73: 'Pickup',
}

# Family byte -> category
FAMILY_NAMES = {
    0x10: 'Troop', 0x14: 'CapitalShip', 0x18: 'DeathStar', 0x1C: 'Fighter',
    0x20: 'AllianceFacility', 0x22: 'DefenseFacility',
    0x28: 'ManufacturingFacility', 0x2C: 'ProductionFacility',
    0x30: 'MonMothma', 0x31: 'Leia', 0x32: 'Luke', 0x33: 'HanSolo',
    0x34: 'Palpatine', 0x35: 'Vader',
    0x38: 'MinorCharacter', 0x3C: 'SpecialForces',
    0x80: 'Sector', 0x90: 'System(Core)', 0x92: 'System(Rim)',
}

FACTION_MARKERS = {
    0x41: 'Alliance',         # primary Alliance entity (often appears once)
    0x51: 'Alliance_alt',     # secondary marker - appears in pairs with 0x41
    0x62: 'Alliance_other',   # another Alliance variant?
    0x81: 'Empire',           # primary Empire entity
    0xA1: 'Empire_alt',       # secondary Empire marker - appears in pairs with 0x81
    0x92: 'System/Special',   # rare marker (1-2 occurrences per save)
}

# Observation: 0x41/0x51 counts match, 0x81/0xA1 counts match
# Pattern: low bit always set (0x01), bit 7 = Empire, bit 6 = Alliance,
# bits 5,4 = some sub-state (parent record vs child record?)


# === Record dataclasses ===

@dataclass
class Entity:
    """A named entity: unit, ship, character, or building"""
    offset: int
    type_id: int
    type_name: str
    faction_id: int
    faction_name: str
    count: int
    name: str
    marker: int  # 0x80 = unit, 0x90 = building

    def __repr__(self):
        return f"Entity({self.type_name}, '{self.name}', {self.faction_name}, count={self.count})"


@dataclass
class MessageRecord:
    """A UI message, event, or notification record"""
    offset: int
    pattern: str  # Header pattern (hex string)
    category: str  # 'mission_report', 'battle', 'tutorial', 'notification', 'construction_status'
    text: str

    def __repr__(self):
        return f"Message({self.category}, '{self.text[:40]}')"


@dataclass
class RebellionSave:
    """Parsed Rebellion save file"""
    path: Path
    file_size: int
    name: str
    name_length: int
    data_start: int

    # Header fields (first 16 bytes after save name)
    version: int                 # u32 at +0x00 (always 1 in known saves)
    header_unknown_1: int        # u32 at +0x04 (always 0)
    header_unknown_2: int        # u32 at +0x08 (always 1)
    save_iteration: int          # u32 at +0x0C (varies: 1, 2, 3)

    # Records
    entities: List[Entity] = field(default_factory=list)
    messages: List[MessageRecord] = field(default_factory=list)

    # Raw file data (for further analysis)
    raw_data: bytes = field(default=b'', repr=False)

    @classmethod
    def load(cls, path) -> 'RebellionSave':
        """Load and parse a save file"""
        p = Path(path)
        with open(p, 'rb') as f:
            data = f.read()

        # Parse header
        name_length = struct.unpack('<H', data[0:2])[0]
        save_name = data[2:2+name_length].decode('ascii', errors='replace')
        data_start = 2 + name_length

        if len(data) < data_start + 16:
            raise ValueError("Save file too short to contain header")

        version = struct.unpack('<I', data[data_start+0:data_start+4])[0]
        h1 = struct.unpack('<I', data[data_start+4:data_start+8])[0]
        h2 = struct.unpack('<I', data[data_start+8:data_start+12])[0]
        iteration = struct.unpack('<I', data[data_start+12:data_start+16])[0]

        save = cls(
            path=p,
            file_size=len(data),
            name=save_name,
            name_length=name_length,
            data_start=data_start,
            version=version,
            header_unknown_1=h1,
            header_unknown_2=h2,
            save_iteration=iteration,
            raw_data=data,
        )

        save._parse_entities()
        save._parse_messages()
        return save

    def _parse_entities(self):
        """Scan file for entity records matching pattern: 00 00 [faction] 00 00 [marker:0x80|0x90]"""
        data = self.raw_data
        i = self.data_start

        while i < len(data) - 20:
            # Look for entity header signature: 00 00 XX 00 00 [80|90]
            if (data[i] == 0x00 and data[i+1] == 0x00 and
                    data[i+3] == 0x00 and data[i+4] == 0x00 and
                    data[i+5] in (0x80, 0x90)):

                faction_id = data[i+2]
                marker = data[i+5]

                if i + 16 < len(data):
                    type_id = struct.unpack('<I', data[i+6:i+10])[0]
                    count = struct.unpack('<I', data[i+10:i+14])[0]
                    name_len = struct.unpack('<H', data[i+14:i+16])[0]

                    # Sanity checks
                    if (1 <= name_len < 80 and
                            1 <= count <= 1000 and
                            type_id < 0x1000 and  # entity type IDs we've seen are small
                            i + 16 + name_len <= len(data)):

                        name_bytes = data[i+16:i+16+name_len]
                        if all(32 <= b < 127 for b in name_bytes):
                            name = name_bytes.decode('ascii')

                            self.entities.append(Entity(
                                offset=i,
                                type_id=type_id,
                                type_name=ENTITY_TYPES.get(type_id, f'Type_0x{type_id:04X}'),
                                faction_id=faction_id,
                                faction_name=FACTION_MARKERS.get(faction_id, f'Unknown_0x{faction_id:02X}'),
                                count=count,
                                name=name,
                                marker=marker,
                            ))
                            # Skip past this record
                            i += 16 + name_len
                            continue
            i += 1

    def _parse_messages(self):
        """Find UI message records via known header patterns"""
        data = self.raw_data

        message_patterns = {
            b'\x10\x00\x00\x00\x10\x00\x00\x00': 'mission_report',
            b'\x00\x01\x00\x00\x10\x00\x00\x00': 'battle_event',
            b'\x00\x02\x00\x00\x10\x00\x00\x00': 'tutorial_topic',
            b'\x00\x02\x00\x00\x00\x00\x00\x00': 'notification',
            b'\x08\x00\x00\x00\x10\x00\x00\x00': 'construction_status',
        }

        for pattern_bytes, category in message_patterns.items():
            i = 0
            while i < len(data) - 16:
                idx = data.find(pattern_bytes, i)
                if idx < 0:
                    break

                # After pattern, expect u16 length + ASCII string
                name_off = idx + len(pattern_bytes)
                if name_off + 2 < len(data):
                    name_len = struct.unpack('<H', data[name_off:name_off+2])[0]
                    if 3 <= name_len < 100 and name_off + 2 + name_len <= len(data):
                        name_bytes = data[name_off+2:name_off+2+name_len]
                        if all(32 <= b < 127 for b in name_bytes):
                            self.messages.append(MessageRecord(
                                offset=idx,
                                pattern=pattern_bytes.hex(' '),
                                category=category,
                                text=name_bytes.decode('ascii'),
                            ))

                i = idx + 1

    def summary(self) -> Dict:
        """Return summary statistics"""
        from collections import Counter
        type_counts = Counter(e.type_name for e in self.entities)
        faction_counts = Counter(e.faction_name for e in self.entities)
        message_counts = Counter(m.category for m in self.messages)

        return {
            'name': self.name,
            'file_size': self.file_size,
            'version': self.version,
            'save_iteration': self.save_iteration,
            'total_entities': len(self.entities),
            'entity_types': dict(type_counts),
            'factions': dict(faction_counts),
            'total_messages': len(self.messages),
            'message_categories': dict(message_counts),
        }

    def entities_by_faction(self, faction_name: str) -> List[Entity]:
        """Get all entities owned by a specific faction"""
        return [e for e in self.entities if e.faction_name == faction_name]

    def entities_by_type(self, type_id_or_name) -> List[Entity]:
        """Get all entities of a specific type (by ID or name)"""
        if isinstance(type_id_or_name, int):
            return [e for e in self.entities if e.type_id == type_id_or_name]
        return [e for e in self.entities if e.type_name == type_id_or_name]

    def find_entity(self, name_substring: str) -> List[Entity]:
        """Find entities by name substring match"""
        return [e for e in self.entities if name_substring in e.name]


# === CLI ===

def main():
    import sys
    if len(sys.argv) < 2:
        # Demo: parse all 3 saves
        print("Usage: python rebellion_save_parser.py <savegame_path> [savegame_path2 ...]")
        print()
        print("Demo mode: parsing all 3 known saves...")
        paths = [
            r"C:\Program Files (x86)\GOG Galaxy\Games\Star Wars - Rebellion\SaveGame\SAVEGAME.001",
            r"C:\Program Files (x86)\GOG Galaxy\Games\Star Wars - Rebellion\SaveGame\SAVEGAME.002",
            r"C:\Program Files (x86)\GOG Galaxy\Games\Star Wars - Rebellion\SaveGame\SAVEGAME.003",
        ]
    else:
        paths = sys.argv[1:]

    for path in paths:
        if not Path(path).exists():
            print(f"\n[SKIP] Not found: {path}")
            continue

        print(f"\n{'='*70}")
        print(f"FILE: {path}")
        print('='*70)

        save = RebellionSave.load(path)
        summary = save.summary()

        print(f"  Save name:         {summary['name']!r}")
        print(f"  File size:         {summary['file_size']:,} bytes")
        print(f"  Format version:    {summary['version']}")
        print(f"  Save iteration:    {summary['save_iteration']}")
        print(f"  Total entities:    {summary['total_entities']}")
        print(f"  Total messages:    {summary['total_messages']}")
        print()
        print(f"  Entity types:")
        for tname, count in sorted(summary['entity_types'].items(), key=lambda x: -x[1]):
            print(f"    {count:>4} x {tname}")
        print()
        print(f"  Factions:")
        for fname, count in sorted(summary['factions'].items(), key=lambda x: -x[1]):
            print(f"    {count:>4} entities owned by {fname}")
        print()
        print(f"  Message categories:")
        for cat, count in sorted(summary['message_categories'].items(), key=lambda x: -x[1]):
            print(f"    {count:>4} x {cat}")


if __name__ == '__main__':
    main()
