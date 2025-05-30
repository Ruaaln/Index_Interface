namespace Indexer.Models;

public class CarGalary
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; }



    public Car this[int index]
    {
        get
        {
            if (index < 0 || index > Cars.Count)
                throw new IndexOutOfRangeException();
            return Cars[index];
        }
        set
        {
            if (index < 0 || index > Cars.Count)
                throw new IndexOutOfRangeException();
            Cars[index] = value;
        }
    }


}

