using MyInterface.AbstractClass;
using MyInterface.Interfaces;
using static System.Console;


namespace MyInterface.Models;

class Mercedes : Car, ISport, ITurbo, IClassic
{
    public void Classic() => WriteLine("Mercedese Classic");

    public void Sport() => WriteLine("Mercedese Sport");

    public void Turbo() => WriteLine("Mercedese Turbo");
}
