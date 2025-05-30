using InterFaceAndProperty.Interface;
using InterFaceAndProperty.MyClass;

var workers = new List<IWork>();

workers.Add(new Cashier());
workers.Add(new Seller());
workers.Add(new Cashier());
workers.Add(new Seller());
workers.Add(new Seller());
workers.Add(new Director());


foreach (var worker in workers)
{
    worker.Work();
}
