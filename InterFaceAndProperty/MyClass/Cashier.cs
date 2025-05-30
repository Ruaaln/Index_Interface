using InterFaceAndProperty.Derived;
using InterFaceAndProperty.Interface;

namespace InterFaceAndProperty.MyClass;

class Cashier : Employee, IWork
{
    public bool isWork { get ; set ; }

    public void Work() => Console.WriteLine("Cashier Work");

}
