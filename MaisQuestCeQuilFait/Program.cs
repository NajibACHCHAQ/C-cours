// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            DoSomething();    
        }
        catch (System.Exception)
        {
            Console.WriteLine("Une erreur s'est produite pendant l'execution du programme");            
        }
    }

    static void DoSomething()
    {
        const int ARRAY_SIZE = 10000;

        Boolean[] array = new Boolean[ARRAY_SIZE];
        for (int i = 0;i<ARRAY_SIZE; i++)
        {
            array[i] = true;
        }
            
        array[0] = false;
        array[1] = false;
        for (int i=2 ;i<ARRAY_SIZE/2; i++)
        {
            int j = 2;
            int index = i*j;
            while (index <ARRAY_SIZE)
            {
                array[index] = false;
                j++;
                index = i*j;
            }
        }

        Console.WriteLine("Affiche les résultats mais quels résultats ?");
        StringBuilder result = new StringBuilder();
        for (int i=0; i<ARRAY_SIZE; i++) 
        {
            if (array[i] == true)
            {
                if (result.Length>0)
                    result.Append(", ");
                result.Append(i.ToString());
            }
        }
         Console.WriteLine(result.ToString());
      
    }


    #region Liste des améliorations de ce programme
        
        /******************************************************
        *
        *   Donner des noms plus explicites aux variables
        *
        ******************************************************/

        /******************************************************
        *
        *   Ajouter des commentaires
        *
        ******************************************************/

        /******************************************************
        *
        *   DoSomethingButWhat réalise deux opérations, calculer et afficher les résultats
        *   Découper cette méthodes en deux :
        *       - Une première qui réalise le calcul et retourne une liste d'entiers avec en paramètre d'entrée la valeur limite de fin de calcul
        *       - Une seconde qui affiche le résultat du calcul.
        *
        ******************************************************/

        /******************************************************
        *
        *   Transférer la méthode qui calcule les nombres premiers dans une classe séparée qui permettra de réutiliser facilement la fonctionnalité.
        *
        *******************************************************/

    #endregion
}
