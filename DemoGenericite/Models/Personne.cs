using DemoGenericite.Interfaces;

namespace DemoGenericite.Models;

public class Personne : IBaseEntity<Guid>, IComparable<Personne>
{
    public Personne()
    {
    }

    public Personne(string lastname, string firstname)
    {
        Lastname = lastname;
        Firstname = firstname;
    }

    public Guid Id { get; set; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public int Age { get; set; }

    public int CompareTo(Personne? other)
    {
        if (other == null) return 1;
        return Age - other.Age;
    }
}
