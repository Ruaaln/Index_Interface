interface IDraw
{
    void Draw();
    void BeatifullDraw() { Console.WriteLine("Beatifull Draw"); }
}


class Rectancle : IDraw
{
    public void Draw() => Console.WriteLine("Rectancle Draw");
    void BeatifullDraw() { Console.WriteLine("Rectancle Draw"); }
}


var rectangle = new Rectancle();
