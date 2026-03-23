using ExerciceGenericite.Interfaces;

namespace ExerciceGenericite.Models;

public class Appareil : IProduit
{
    public Appareil(string nom, string marque, double prix)
    {
        Nom = nom;
        Prix = prix;
        Marque = marque;
    }

    public string Nom { get; }

    public double Prix { get; }
    public string Marque { get; }

    public override string? ToString()
    {
        return $"Appareil: {Nom} de {Marque} à {Prix:F2} euros.";
    }
}
