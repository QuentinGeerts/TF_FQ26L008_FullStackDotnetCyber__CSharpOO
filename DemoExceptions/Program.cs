/*
 * Démonstration : Exceptions
 */

using DemoExceptions.Exceptions;
using DemoExceptions.Models;

//int convertedValue;
//while (!Conversion.TryParse(Console.ReadLine()!, out convertedValue))
//{
//    Console.WriteLine($"Erreur, réessayez :");
//}

// 3 exceptions classiques d'un TryParse
//string strToConvert = null;
//string strToConvert = "12a";
//unchecked
//{
//    string strToConvert = ((long)int.MaxValue + 1).ToString();
//    bool success = Conversion.TryParse(strToConvert, out int convertedValue);
//    Console.WriteLine($"Success: {success} - ConvertedValue: {convertedValue}");
//}


// Autres exceptions
try
{
	string strToConvert = "42";
	bool success = Conversion.TryParse(strToConvert, out int convertedValue);
	Console.WriteLine($"Success: {success} - ConvertedValue: {convertedValue}");
}
catch (Exception e)
{
    Console.WriteLine($"Erreur: {e.Message}");
	if (e is QuentinException qe)
	{
        Console.WriteLine($"Value incorrecte : {((QuentinException)e).Value}");
        Console.WriteLine($"Value incorrecte : {qe.Value}");
	}
}