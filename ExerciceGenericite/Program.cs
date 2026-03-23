/*
 * Exercice: Généricité
 */

using ExerciceGenericite.Models;
using ExerciceGenericite.Tools;

// 1. Création des dépôts

var depotLivres = new DepotProduit<Livre>();
var depotAppareils = new DepotProduit<Appareil>();

// 2. Insertion des données
depotLivres.Ajouter(new Livre("L'épée de vérité", "Terry Goodkind", 12.99));
depotLivres.Ajouter(new Livre("Le Seigneur des Anneaux", "J.R.R. Tolkien", 25.50));
depotLivres.Ajouter(new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", 7.50));
depotLivres.Ajouter(new Livre("Dune", "Frank Herbert", 14.95));

depotAppareils.Ajouter(new Appareil("Latitue 3550", "Dell", 449.99));
depotAppareils.Ajouter(new Appareil("Switch OLED", "Nintendo", 310.50));
depotAppareils.Ajouter(new Appareil("WH-1000XM5", "Sony", 349.00));
depotAppareils.Ajouter(new Appareil("Kindle Paperwhite", "Amazon", 169.99));

// 3. Affichage des éléments + prix total
depotLivres.Afficher();
Console.WriteLine($"Dépôt livres - Prix total: {depotLivres.PrixTotal()}");

depotAppareils.Afficher();
Console.WriteLine($"Dépôt appareils- Prix total: {depotAppareils.PrixTotal()}");


// 4.  Test de retirer + gestion des erreurs 

Console.WriteLine("Avant retrait :");
depotLivres.Afficher();
depotLivres.Retirer(1);

Console.WriteLine("Après retrait de l'index 1 :");
depotLivres.Afficher();

try
{
    depotLivres.Retirer(42); // indice invalide
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erreur : {ex.Message}");
}

// 5.  Test de Echanger<T>

int x = 10, y = 20;
Console.WriteLine($"Avant : x={x}, y={y}");
OutilsDepot.Echanger(ref x, ref y);
Console.WriteLine($"Après : x={x}, y={y}");

string s1 = "Bonjour", s2 = "Monde";
Console.WriteLine($"Avant : s1={s1}, s2={s2}");
OutilsDepot.Echanger(ref s1, ref s2);
Console.WriteLine($"Après : s1={s1}, s2={s2}");


// 6.  Test de Trouver<T>

List<int> nombres = new List<int> { 5, 12, 7, 42, 3 };
Console.WriteLine($"Liste : {string.Join(", ", nombres)}");
Console.WriteLine($"Index de 42 : {OutilsDepot.Trouver(nombres, 42)}");
Console.WriteLine($"Index de 99 : {OutilsDepot.Trouver(nombres, 99)}");

// 7. Test de Filtrer<T> avec ICondition<T>

// On recrée le dépôt complet pour la démo

List<Livre> tousLesLivres = new List<Livre>();
for (int i = 0; i < depotLivres.NombreElements; i++)
{
    tousLesLivres.Add(depotLivres.Recuperer(i));
}

List<Livre> livresFiltres = OutilsDepot.Filtrer(tousLesLivres, new LivrePrixMin(10.0));

Console.WriteLine("Livres avec un prix > 10€ :");
foreach (Livre l in livresFiltres)
    Console.WriteLine($"  {l}");