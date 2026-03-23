using ExerciceGenericite.Interfaces;

namespace ExerciceGenericite.Models;

public class Depot<T> : IDepot<T>
{
    private readonly List<T> _elements = [];

    public int NombreElements => _elements.Count;

    public void Ajouter(T item)
    {
        _elements.Add(item);
    }

    public T Recuperer(int indice)
    {
        if (indice < 0 || indice >= _elements.Count)
            throw new ArgumentOutOfRangeException(nameof(indice), "L'indice est invalide.");
        return _elements[indice];
    }

    public void Retirer(int indice)
    {
        if (indice < 0 || indice >= _elements.Count)
            throw new ArgumentOutOfRangeException(nameof(indice), "L'indice est invalide.");
        _elements.RemoveAt(indice);
    }

    public void Afficher()
    {
        if (_elements.Count == 0)
        {
            Console.WriteLine($"Dépôt vide.");
            return;
        }

        for (int i = 0; i < _elements.Count; i++)
        {
            Console.WriteLine($" - [{i}] {_elements[i]}");
        }
    }
}
