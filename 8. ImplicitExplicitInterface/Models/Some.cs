namespace _8._ImplicitExplicitInterface.Models;

public interface IA
{
    void Get();
}

public interface IB
{
    void Get();
}


class Some : IA, IB
{
    // Askar
    void IA.Get() => Console.WriteLine("IA Get");
    void IB.Get() => Console.WriteLine("IB Get");


    // Q/ askar
    public void Get() => Console.WriteLine("Some Get");
}
