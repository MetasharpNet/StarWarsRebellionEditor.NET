using System.Media;

namespace SwRebellionEditor;

public static class Sound
{
    private static Random _random = new Random(DateTime.Now.Millisecond);

    public static void Play(Stream audioStream)
    {
        ThreadPool.QueueUserWorkItem(ignoredState =>
        {
            using (var soundPlayer = new SoundPlayer(audioStream))
            {
                soundPlayer.Play();
            }
        });
        Thread.Sleep(520);
    }

    private static SoundPlayer _musicSoundPlayer;
    static Sound()
    {
        _musicSoundPlayer = new SoundPlayer();
    }
    public static void PlayMusic(string filePath, bool looping = true)
    {
        _musicSoundPlayer!.Stop();
        _musicSoundPlayer.SoundLocation = filePath;
        if (looping)
            _musicSoundPlayer.PlayLooping();
        else
            _musicSoundPlayer.Play();
    }
    public static void StopMusic()
    {
        _musicSoundPlayer!.Stop();
    }

    public static void PlayRandomMusic()
    {
        if (!RegistryKeys.IsRebellionCdLoaded)
            return;
        PlayMusic(RegistryKeys.DllLocation + "\\MDATA\\MDATA." + _random.Next(300, 315));
    }
}
