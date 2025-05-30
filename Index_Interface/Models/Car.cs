namespace Indexer.Models;

public class Car
{
    public Guid Id { get; set; }
    public string? Model { get; set; }
    public string Maker { get; set; } = default!;
    public DateTime Year { get; set; }
}
