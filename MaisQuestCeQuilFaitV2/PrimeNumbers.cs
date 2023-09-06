
namespace Greta
{

    public class PrimeNumbers
    {
        public static List<int> Compute(int maxValue)
        {
            List<int> candidatePrimeNumbers = new List<int>();
            
            // Par défaut, on considère que tous les nombres sont des nombres premiers potentiels
            for (int i = 2;i<maxValue; i++)
            {
                candidatePrimeNumbers.Add(i);
            }

            // On prends tous les nombres compris entre 2 et    maxValue/2  
            for (int multipleBase=2; multipleBase<(maxValue/2); multipleBase++)
            {
                // Et on supprime de la liste des nombres premiers potentiels, tous les multiples de ces nombres.
                int multiplefactor = 2;
                int multipleValue = multipleBase*multiplefactor;
                while (multipleValue <maxValue)
                {
                    if (candidatePrimeNumbers.Contains(multipleValue))
                        candidatePrimeNumbers.Remove(multipleValue);

                    multiplefactor++;
                    multipleValue = multipleBase*multiplefactor;
                }
            }

            return candidatePrimeNumbers;
        }

    }

}