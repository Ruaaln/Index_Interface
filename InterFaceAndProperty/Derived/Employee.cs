using InterFaceAndProperty.Base;

namespace InterFaceAndProperty.Derived;

class Employee : Human
{
    public string Position { get; set; }
    public double Salary { get; set; }


    public override string ToString()
    => @$"{base.ToString()}
Position: {Position}
Salary:{Salary}";


}
