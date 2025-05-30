namespace _Solid_InrterfaceSagregation.GoodExample;

interface IAudioPlayer
{
    void PlayAudio();

}

interface IVideoPlayer
{
    void PlayVideo();

}



class DivMediaPlayer : IAudioPlayer, IVideoPlayer
{
    public void PlayAudio() => Console.WriteLine("DivMediaPlayer PlayAudio");

    public void PlayVideo() => Console.WriteLine("DivMediaPlayer PlayVideo");
}

class Winamp : IAudioPlayer
{
    public void PlayAudio() => Console.WriteLine("Winamp PlayAudio");
}


class SomeVideoPlayer : IVideoPlayer
{
    public void PlayVideo() => Console.WriteLine("SomeVideoPlayer PlayVideo");
}
