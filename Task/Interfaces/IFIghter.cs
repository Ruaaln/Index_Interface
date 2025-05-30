namespace Task.Interfaces;

public interface IFIghter
{
    void CanAttack();
    void CanFire();
    void CanShot();
}

public interface IKiller
{
    void canKill();
}

public interface IManager
{
    void Control();
    void CompleteMission();
    void GatherPeople();
}


class Fighter : IFIghter, IKiller
{
    public void CanAttack() => Console.WriteLine("Figher CanAttack");

    public void CanFire() => Console.WriteLine("Figher CanFire");

    public void canKill() => Console.WriteLine("Figher canKill");

    public void CanShot() => Console.WriteLine("Figher CanShot");
}



class Commander : Fighter, IManager
{
    public void CompleteMission() => Console.WriteLine("Commander CompleteMission");

    public void Control() => Console.WriteLine("Commander Control");


    public void GatherPeople() => Console.WriteLine("Commander GatherPeople");

}
