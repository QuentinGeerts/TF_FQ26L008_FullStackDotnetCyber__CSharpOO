using DemoExceptions.Exceptions;

namespace DemoExceptions.Models;

public static class Conversion
{
    /// <summary>
    /// Attempts to convert the specified string representation of a number to its 32-bit signed integer equivalent.
    /// </summary>
    /// <remarks>This method handles format and overflow errors gracefully by returning false and setting
    /// convertedValue to zero. It also logs messages to the console for different failure scenarios. If value is not a
    /// valid integer or is outside the range of a 32-bit signed integer, the method does not throw an exception but
    /// instead returns false.</remarks>
    /// <param name="value">The string representation of the number to convert. This parameter cannot be null.</param>
    /// <param name="convertedValue">When this method returns, contains the 32-bit signed integer value equivalent to the number contained in value,
    /// if the conversion succeeded, or zero if the conversion failed.</param>
    /// <returns>true if the conversion succeeded; otherwise, false.</returns>
    /// <exception cref="QuentinException">Thrown if the value parameter is equal to "quentin" (case-insensitive).</exception>
    public static bool TryParse (string value, out int convertedValue)
    {
        if (value.ToLower() == "quentin") 
            throw new QuentinException("La valeur ne peut contenir cette donnée.", "Quentin");

        try
        {
            convertedValue = int.Parse(value);
            return true;
        }
        // Exemple: catch (HttpRequestException e) when (e.statusCode == 404)
        catch (ArgumentNullException e) when (true) 
        {
            Console.WriteLine($"La valeur à convertir ne peut pas être nulle.");
            convertedValue = default;
            return false;
        }
        catch (ArgumentNullException e) when (false)
        {
            Console.WriteLine($"La valeur à convertir ne peut pas être nulle.");
            convertedValue = default;
            return false;
        }
        catch (Exception e)
        {
            switch (e)
            {
                case ArgumentNullException:
                    Console.WriteLine($"La valeur à convertir ne peut pas être nulle.");
                    break;
                case FormatException:
                    Console.WriteLine($"La valeur n'est pas dans un format convertissable.");
                    break;
                case OverflowException:
                    Console.WriteLine($"La valeur à convertir dépasse la capacité maximal d'un int.");
                    break;

                default:
                    Console.WriteLine($"Exception non gérée: " + e.Message);
                    Console.WriteLine($"Trace: " + e.StackTrace);
                    break;
            }

            convertedValue = default;
            return false;
        }
        finally
        {
            Console.WriteLine($"Conversion terminée (que ça soit réussi ou non).");
        }

    }
}
