namespace DemoGenericite.Models;

public static class Outils
{
    public static void AfficherDetails<T> (T valeur)
    {
        Console.WriteLine($"[{typeof(T).Name}] {valeur}");
    }

    public static (B, A) Inverser<A,B>((A, B) paire)
    {
        return (paire.Item2, paire.Item1);
    }
}
