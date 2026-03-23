using System.Collections;

namespace DemoGenericite.Models;

public class BoiteString
{
    private string _valeur;

    public void Ajouter(string valeur)
    {
        _valeur = valeur;
    }

    public string Valeur => _valeur;
}
