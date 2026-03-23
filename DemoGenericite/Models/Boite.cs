using DemoGenericite.Interfaces;

namespace DemoGenericite.Models;

// Vous pouvez des contraintes sur le type T
// > public class NomClass<T> where T : contrainte(s)

// where T : struct → type valeur
// where T : class → type référence
// where T : new() → posséder un constructeur sans paramètre
// where T : NomClasse → doit hériter d'une certaine classe
// where T : NomInterface → doit implémenter une interface
// where T : notnull → obligation de valeur

public class Boite<T, TId>
    //where T : struct
    //where T : class
    //where T : class, new()
    //where T : Vehicule
    //where T : IBaseEntity<TId>
    //where T : notnull
    //where T : IComparable<T> // T est comparable à lui-même (CompareTo, tri, min/max)
    where T : IComparable<T>, IBaseEntity<TId>, new() // Multi-contrainte
{
    private T _valeur;

    public void Ajouter(T valeur)
    {
        _valeur = valeur;
    }

    public T Valeur => _valeur;

    public override string ToString()
    {
        return $"Boite<{typeof(T).Name}> = {_valeur}";
    }
}
