/*
 * Démonstration : Généricité
 */

using DemoGenericite.Models;

//var boiteInt = new BoiteInt();
//boiteInt.Ajouter(42);
//int valeurInt = boiteInt.Valeur;

////boiteInt.Ajouter("42");

//BoiteString boiteString = new(); // Inférence de type
//boiteString.Ajouter("Quentin");
//boiteString.Ajouter("Thierry");
//string valeurString = boiteString.Valeur;

////boiteString.Ajouter(42);

//BoiteObject boiteObject = new BoiteObject();
//boiteObject.Ajouter("Quentin");
//string valeurStringObject = (string)boiteObject.Valeur;

//boiteObject.Ajouter(42);
//int valeurIntObject = (int)boiteObject.Valeur;



//var boiteEntier = new Boite<int>(); // struct = valeur
//boiteEntier.Ajouter(42);
//int valeurEntier = boiteEntier.Valeur;

//Console.WriteLine(boiteEntier);

//var boiteChaine = new Boite<string>(); // class = reference
//boiteChaine.Ajouter("Quentin");
//string valeurChaine = boiteChaine.Valeur;

//Console.WriteLine(boiteChaine);

//var boiteBooleen = new Boite<bool>();
//boiteBooleen.Ajouter(true);
//bool valeurBooleen = boiteBooleen.Valeur;

//Console.WriteLine(boiteBooleen);

// 2.  Multi-paramètres

var paire = new Paire<string, Boite<int>>
{
    Key = "B000001",
    Value = new Boite<int>()
};

Console.WriteLine(paire);

//Outils.AfficherDetails<int>(boiteInt.Valeur);
//Outils.AfficherDetails(boiteChaine.Valeur);

// Déstructuration
var (prenom, age) = Outils.Inverser((29, "Quentin"));

Outils.AfficherDetails(prenom);
Outils.AfficherDetails(age);

// 3.  Contraintes

//Boite<Personne> boitePersonnes = new Boite<Personne>();
//Boite<Coordonnee> boiteCoordonnee = new();

Boite<Vehicule, int> boiteVehicule = new Boite<Vehicule, int>();
Boite<Voiture, int> boiteVoiture = new Boite<Voiture, int>();
Boite<Personne, Guid> boitePersonne = new Boite<Personne, Guid>();
