namespace ExerciceGenericite.Interfaces;

public interface IDepot<T>
{
    int NombreElements { get; }

    void Ajouter(T element);
    void Retirer(int indice);
    T Recuperer(int indice);
}
