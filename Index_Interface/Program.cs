using Indexer.Models;

var eClass = new Car()
{
    Id = Guid.NewGuid(),
    Model = "E class",
    Maker = "Mercedes",
    Year = new DateTime(2020, 1,1)
};


var f10 = new Car()
{
    Id = Guid.NewGuid(),
    Model = "520e",
    Maker = "BMW",
    Year = new DateTime(2022, 1, 1)
};


List<Car> cars = new List<Car>();

cars.Add(eClass);
cars.Add(f10);

foreach (var car in cars)
{
    Console.WriteLine(car.Model);
}

CarGalary carGalary = new CarGalary()
{
    Name = "Nurgun motors",
    Cars = cars
};

Console.WriteLine(carGalary.Cars[0].Maker);

Console.WriteLine(carGalary[0].Maker);