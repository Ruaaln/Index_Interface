namespace _Solid_InrterfaceSagregation.BadExample;

interface IPlayer
{
    void PlayAudio();
    void PlayVideo();
}


class DivMediaPlayer : IPlayer
{
    public void PlayAudio() => Console.WriteLine("DivMediaPlayer PlayAudio");

    public void PlayVideo() => Console.WriteLine("DivMediaPlayer PlayVideo");
}

class Winamp : IPlayer
{
    public void PlayAudio() => Console.WriteLine("Winamp PlayAudio");

    public void PlayVideo() { }
}


class SomeVideoPlayer : IPlayer
{
    public void PlayAudio() { }

    public void PlayVideo() => Console.WriteLine("SomeVideoPlayer PlayVideo");
}