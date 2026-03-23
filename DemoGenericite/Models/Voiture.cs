using DemoGenericite.Interfaces;

namespace DemoGenericite.Models;

public class Voiture : Vehicule, IConvertisseur<Vehicule, Voiture>
{
    public Voiture Convertir(Vehicule value)
    {
        if (value is not Voiture) throw new ArgumentException();
        return (Voiture)value;
    }
}
