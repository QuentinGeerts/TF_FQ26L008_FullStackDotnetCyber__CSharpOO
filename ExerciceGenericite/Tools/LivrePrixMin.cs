using ExerciceGenericite.Models;

namespace ExerciceGenericite.Tools;

public class LivrePrixMin : ICondition<Livre>
{
    private readonly double _prixMin;

    public LivrePrixMin(double prixMin)
    {
        _prixMin = prixMin;
    }

    public bool Verifier(Livre element)
    {
        return element.Prix > _prixMin;
    }
}
