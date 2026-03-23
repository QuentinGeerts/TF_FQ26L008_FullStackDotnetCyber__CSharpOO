using System.Collections;

namespace DemoGenericite.Models;

public class BoiteInt
{
    private int _valeur;

    public void Ajouter (int valeur)
    {
        _valeur = valeur;
    }

    public int Valeur => _valeur;
}
