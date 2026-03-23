using DemoGenericite.Interfaces;

namespace DemoGenericite.Models;

public class Vehicule : IBaseEntity<int>
{
    public int Id { get; set; }
    public string Brand { get; set; }
}
