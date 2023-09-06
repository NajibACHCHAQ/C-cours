using System;

namespace Greta.util
{
    /// <summary>
    /// classe utilitaire pour la saisie d'informations de la part des utilisateurs
    /// </summary>
    public class SaisieUtil 
    {

        /// <summary>
        /// invite l'utilisateur à saisir une text et vérifie que le texte saisi comporte au moins un caractère.
        /// </summary>
        /// <param name="inviteMessage">Message displayed to the user. Must be not null and not empty</param>
        /// <param name="maxTryCount">Max try count for user. Must be upper or equals to 1</param>
        /// <returns>The text writen by the user.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static String ConsoleReadLineNotNullOrEmpty(String inviteMessage, int maxTryCount)
        {
            // Vérification des paramètres en entrée
            if (String.IsNullOrEmpty(inviteMessage))
                throw new ArgumentNullException("inviteMessage must be not null or not empty !");

            if (maxTryCount<1)
                throw new ArgumentOutOfRangeException("maxTryCount must be upper or equal to 1 !");

            String userText = null;
            int tryCount = 0;
            do 
            {
                Console.WriteLine(inviteMessage);
                userText = Console.ReadLine();

                if (String.IsNullOrEmpty(userText))
                {
                    Console.WriteLine("Vous devez saisir une valeur ! ");
                    Console.WriteLine();
                }

                tryCount ++;
            }
            while  (String.IsNullOrEmpty(userText) && tryCount<maxTryCount);

            if (String.IsNullOrEmpty(userText))
            {
                // InvalidOperationException est utilisé dans les cas où l'échec d'appeler une méthode est dû à des raisons autres que des arguments non valides.
                throw new InvalidOperationException("max try count has been reached");
            }

            return userText;
        }

    }
}