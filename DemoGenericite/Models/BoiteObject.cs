using System.Collections;

namespace DemoGenericite.Models;

public class BoiteObject
{
    private object _valeur;

    public void Ajouter(object valeur)
    {
        _valeur = valeur;
    }

    public object Valeur => _valeur;
}
