using ExerciceGenericite.Interfaces;

namespace ExerciceGenericite.Models;

public class DepotProduit<T> : Depot<T> where T : IProduit
{
    public double PrixTotal()
    {
        double total = 0;
        for (int i = 0; i < NombreElements; i++)
        {
            total += Recuperer(i).Prix;
        }
        return total;
    }
}
