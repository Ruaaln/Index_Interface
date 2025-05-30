using InterFaceAndProperty.Derived;
using InterFaceAndProperty.Interface;

namespace InterFaceAndProperty.MyClass;

class Director : Employee, IWork, IManager
{
    public bool isWork { get; set; }

    public void MakeBudget() => Console.WriteLine("Director MakeBudget");


    public void Organize() => Console.WriteLine("Director Organize");


    public void ShowHistory() => Console.WriteLine("Director ShowHistory");


    public void Work() => Console.WriteLine("Director Work");

}
