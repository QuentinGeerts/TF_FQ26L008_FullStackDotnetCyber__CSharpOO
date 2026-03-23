namespace ExerciceGenericite.Tools;

public interface ICondition<T>
{
    bool Verifier(T element);
}
