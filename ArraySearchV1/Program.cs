using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySearchV1
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Instancie une variable de type groupe
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

// ------------------------------------------------------------------------------------------------------------- //

        // Triez les élèves par ordre alphabétique du nom (ascendant)
        var elevesTries = groupeCda.Eleves.OrderBy(eleve => eleve.Nom).ToList();

        // Affichez les élèves triés
        foreach (var eleve in elevesTries)
        {
            Console.WriteLine(eleve.Nom + " " + eleve.Prenom + "" + eleve.Metier);
        }

// ------------------------------------------------------------------------------------------------------------------ //

            // Déclaration d'une variable emailSearch
            String emailSearch;
            // Boucle tant que la variable emailSearch est vide ou ne contient que des espaces
            do
            {
                // Affiche un message à l'utilisateur
                Console.Write("Entrer l'adresse mail de l'élève à rechercher : ");
                // Lit une chaine de caractère depuis la console
                emailSearch = Console.ReadLine();

                // test que l'adresse saisie n'est pas vide ou ne contient pas que des espaces
                if (String.IsNullOrWhiteSpace(emailSearch))
                {
                    // Affiche un message pour indiquer que l'adresse email est invalide
                    Console.WriteLine("Adresse email invalide !");
                    Console.WriteLine("");
                }
            }
            while (String.IsNullOrWhiteSpace(emailSearch));

            // Déclaration d'une variable eleveSearch
            Eleve eleveSearch = null;
            int y =0;
            // Boucle while tant que y est inférieur à la longeur du tableau ou que eleveSearch est null
            while (y<groupeCda.Eleves.Length && eleveSearch == null)
            {
                // Verifie que le metier de l'élève est egal à metierSearch
                if (groupeCda.Eleves[y].Email == emailSearch)
                {
                    eleveSearch = groupeCda.Eleves[y];
                }
                y++;
            }

            // Test que eleveSearch est différent de null
            if (eleveSearch != null)
            {
                Console.WriteLine("");
                // affiche les informations de emailSearch
                Console.WriteLine("L'utilisateur avec l'email " + emailSearch + " est : " + eleveSearch.Nom + " " + eleveSearch.Prenom);
            }
            else
            {
                Console.WriteLine("");
                // affiche qu'aucun utilisateur ne dispose de cet email
                Console.WriteLine("aucun utilisateur ne dispose de cet email");
            }



// ------------------------------------------------------------------------------------------------------------------------------ //

            // Déclaration d'une variable metierSearch
        string metierSearch;

        // Boucle tant que la variable metierSearch est vide ou ne contient que des espaces
        do
        {
            // Affiche un message à l'utilisateur
            Console.Write("Entrer le métier recherché : ");
            // Lit une chaîne de caractères depuis la console
            metierSearch = Console.ReadLine();

            // Test que le métier saisi n'est pas vide ou ne contient pas que des espaces
            if (String.IsNullOrWhiteSpace(metierSearch))
            {
                // Affiche un message pour indiquer que le métier est invalide
                Console.WriteLine("Métier invalide !");
                Console.WriteLine("");
            }
        } while (String.IsNullOrWhiteSpace(metierSearch));

        // Déclaration d'une liste pour stocker les élèves avec le métier recherché
         List<Eleve> elevesAvecMetier = new List<Eleve>();

        // Boucle for pour parcourir tous les élèves du groupe
        for (int i = 0; i < groupeCda.Eleves.Length; i++)
        {
            // Vérifie si le métier de l'élève correspond au métier recherché
            if (groupeCda.Eleves[i].Metier == metierSearch)
            {
                // Ajoute l'élève à la liste
                elevesAvecMetier.Add(groupeCda.Eleves[i]);
            }
        }

        // Test si des élèves ont été trouvés
        if (elevesAvecMetier.Count > 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Les utilisateurs avec le métier " + metierSearch + " sont :");

            // Affiche les informations de tous les élèves ayant le métier recherché
            foreach (var eleve in elevesAvecMetier)
            {
                Console.WriteLine(eleve.Nom + " " + eleve.Prenom);
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Aucun utilisateur ne fait ce métier.");
        }


            
            Console.WriteLine("Appuyer sur une touche pour fermer l'application !");
            Console.ReadLine();
            Console.ReadLine();

            
        }

    }

}


