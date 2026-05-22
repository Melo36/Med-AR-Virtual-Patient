public interface ILocalTTSSpeaker
{
    public enum AudioStatus
    {
        Idle,
        Downloading,
        Playing,
        Completed,
        Error
    }
    void Speak(string text);
    void SpeakDelayed();
    void Stop();
    void TestConnection();
    AudioStatus GetStatus();
}
