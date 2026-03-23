using ExerciceGenericite.Interfaces;

namespace ExerciceGenericite.Models;

public class Livre : IProduit
{
    public Livre(string nom, string auteur, double prix)
    {
        Nom = nom;
        Prix = prix;
        Auteur = auteur;
    }

    public string Nom { get; }

    public double Prix { get; }
    public string Auteur { get; }

    public override string ToString()
    {
        return $"Livre: {Nom} de {Auteur} à {Prix:F2} euros.";
    }

}
