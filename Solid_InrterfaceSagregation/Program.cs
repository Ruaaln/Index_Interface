//using _Solid_InrterfaceSagregation.BadExample;

//List<IPlayer> players = new();


//players.Add(new DivMediaPlayer());
//players.Add(new Winamp());
//players.Add(new SomeVideoPlayer());


//foreach (var player in players)
//{
//    player.PlayAudio();
//}


using _Solid_InrterfaceSagregation.GoodExample;

List<IAudioPlayer> players = new();


players.Add(new DivMediaPlayer());
players.Add(new Winamp());

foreach (var player in players)
{
    player.PlayAudio();
}