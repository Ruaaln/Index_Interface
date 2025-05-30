using MyInterface.Interfaces;
using MyInterface.AbstractClass;

namespace MyInterface.Models;

class Lada : Car, IClassic
{
    public void Classic() => Console.WriteLine("Lada Classic");
}
