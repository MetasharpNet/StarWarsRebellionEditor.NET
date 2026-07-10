namespace SwRebellionEditor;

// Each game DLL is loaded lazily on first use: parsing all of them upfront costs ~230 MB
// (TACTICAL.DLL alone is ~149 MB) and used to freeze the UI when opening the first form.
public static class ResourcesDlls
{
    private static readonly Lazy<Alsprite> _alsprite = new(() => new Alsprite("ALSPRITE.DLL"));
    private static readonly Lazy<Cdderr>   _cdderr   = new(() => new Cdderr  ("CDDERR.DLL"));
    private static readonly Lazy<Common>   _common   = new(() => new Common  ("COMMON.DLL"));
    private static readonly Lazy<Emsprite> _emsprite = new(() => new Emsprite("EMSPRITE.DLL"));
    private static readonly Lazy<Encybmap> _encybmap = new(() => new Encybmap("ENCYBMAP.DLL"));
    private static readonly Lazy<Encytext> _encytext = new(() => new Encytext("ENCYTEXT.DLL"));
    private static readonly Lazy<Gokres>   _gokres   = new(() => new Gokres  ("GOKRES.DLL"));
    private static readonly Lazy<Rebdlog>  _rebdlog  = new(() => new Rebdlog ("REBDLOG.DLL"));
    private static readonly Lazy<Strategy> _strategy = new(() => new Strategy("STRATEGY.DLL"));
    private static readonly Lazy<Tactical> _tactical = new(() => new Tactical("TACTICAL.DLL"));
    private static readonly Lazy<Textcomm> _textcomm = new(() => new Textcomm("TEXTCOMM.DLL"));
    private static readonly Lazy<Textstra> _textstra = new(() => new Textstra("TEXTSTRA.DLL"));
    private static readonly Lazy<Texttact> _texttact = new(() => new Texttact("TEXTTACT.DLL"));
    private static readonly Lazy<Voicefxa> _voicefxa = new(() => new Voicefxa("VOICEFXA.DLL"));
    private static readonly Lazy<Voicefxe> _voicefxe = new(() => new Voicefxe("VOICEFXE.DLL"));

    public static Alsprite Alsprite => _alsprite.Value;
    public static Cdderr   Cdderr   => _cdderr.Value;
    public static Common   Common   => _common.Value;
    public static Emsprite Emsprite => _emsprite.Value;
    public static Encybmap Encybmap => _encybmap.Value;
    public static Encytext Encytext => _encytext.Value;
    public static Gokres   Gokres   => _gokres.Value;
    public static Rebdlog  Rebdlog  => _rebdlog.Value;
    public static Strategy Strategy => _strategy.Value;
    public static Tactical Tactical => _tactical.Value;
    public static Textcomm Textcomm => _textcomm.Value;
    public static Textstra Textstra => _textstra.Value;
    public static Texttact Texttact => _texttact.Value;
    public static Voicefxa Voicefxa => _voicefxa.Value;
    public static Voicefxe Voicefxe => _voicefxe.Value;
}
