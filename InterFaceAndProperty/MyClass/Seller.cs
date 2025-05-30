using InterFaceAndProperty.Derived;
using InterFaceAndProperty.Interface;

namespace InterFaceAndProperty.MyClass;

class Seller : Employee, IWork
{
    public bool isWork { get; set; }

    public void Work() => Console.WriteLine("Seller Work");
}
