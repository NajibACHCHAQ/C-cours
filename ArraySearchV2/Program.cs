using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySearchV2
{
    internal class Program
    {
        /// <summary>
        /// Permet la recherche et l'affichage des informations d'un eleve dans un groupe de test à partir de son adresse mail.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Groupe groupeCda = new Groupe()
            {
                Nom = "Concepteur developpeur d'applications",
                Eleves = new Eleve[]
                {
                     new Eleve (prenom : "Gad", nom : "Elmaleh") {Email="ge@gmail.com", Metier = "Acteur"},
                     new Eleve (prenom : "Omar", nom : "Sy") { Email="os@gmail.com", Metier = "Acteur"},
                     new Eleve (prenom : "Jean", nom : "Dujardin") { Email="jd@gmail.com", Metier = "Acteur"},
                     new Eleve (prenom : "Kylian", nom : "Mbappé") { Email="km@gmail.com", Metier = "Sportif"},
                     new Eleve (prenom : "Marion", nom : "Cotillard") { Email="mc@gmail.com", Metier = "Acteur"},
                     new Eleve (prenom : "Zinedine", nom : "Zidane") { Email="zz@gmail.com", Metier = "Sportif"},
                     new Eleve (prenom : "Florence", nom : "Foresti") { Email="ff@gmail.com", Metier = "Acteur"},
                     new Eleve ("Yann", "Barthès") { Email="yb@gmail.com", Metier = "Journaliste"},
                     new Eleve ("Jean Jacques", "Goldman") { Email="jjg@gmail.com", Metier = "Chanteur"},
                     new Eleve ("Francis", "Cabrel") { Email="fc@gmail.com", Metier = "Chanteur"},
                     new Eleve ("Florent", "Pagny") { Email="fp@gmail.com", Metier = "Chanteur"},
                     new Eleve ("Alain", "Pagny") {Email="ap@gmail.com", Metier = "Chanteur"}                            
                }
            };

            // Saisie d'un texte jusqu'à ce que le texte saisie par l'utilisateur soit non vide
            // Ce texte sera l'adresse mail à rechercher
            String emailSearch;
            do
            {
                Console.Write("Entrer l'adresse mail de l'élève à rechercher : ");
                emailSearch = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(emailSearch))
                {
                    Console.WriteLine("Adresse email invalide !");
                    Console.WriteLine("");
                }
            }
            while (String.IsNullOrWhiteSpace(emailSearch));

            // Recherche de l'élève
            // Parcours la liste des élève du groupe jusqu'à trouver un eleve ayant l'adresse mail idientique avec l'adresse saisie par l'utilisateur
            Eleve eleveSearch = null;
            int i = 0;
            while (i < groupeCda.Eleves.Length && eleveSearch == null)
            {
                if (groupeCda.Eleves[i].Email == emailSearch)
                {
                    eleveSearch = groupeCda.Eleves[i];
                }
                i++;
            }

            // Un elève a t'il été trouvé ?
            if (eleveSearch != null)
            {
                // Oui, affichage des inforamtions de l'élève trouvé
                Console.WriteLine("");
                Console.WriteLine("L'utilisateur avec l'email " + emailSearch + " est : " + eleveSearch.Nom + " " + eleveSearch.Prenom);
            }
            else
            {
                // Non affichage d'un message pour indiquer qu'auncun utilisateur n'a été trouvé.
                Console.WriteLine("");
                Console.WriteLine("aucun utilisateur ne dispose de cet email");
            }

            Console.WriteLine("Appuyer sur une touche pour fermer l'application !");
            Console.ReadLine();
        }

    }

}


