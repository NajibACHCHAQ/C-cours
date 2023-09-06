// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Text;
using Greta;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            const int MAX_PRIME_NUMBER_VALUE = 1000;
            List<int> primeNumbers = PrimeNumbers.Compute(MAX_PRIME_NUMBER_VALUE);
            Console.WriteLine("les nombres premiers jusqu'a {0} sont : {1}", MAX_PRIME_NUMBER_VALUE, (primeNumbers)); 
        }
        catch (System.Exception)
        {
            Console.WriteLine("Une erreur s'est produite pendant l'execution du programme");            
        }
    }

    
    static String  ListIntToString(List<int> integersToDisplay)
    {
        StringBuilder result = new StringBuilder();
        foreach (int intToDisplay in integersToDisplay)
        {
            if (result.Length>0)
                result.Append(", ");
            result.Append(intToDisplay.ToString());
        }

        return result.ToString();
    }
}
ListIntToString