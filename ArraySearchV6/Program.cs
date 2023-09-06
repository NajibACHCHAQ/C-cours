using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Greta.util;

namespace ArraySearchV6
{
    internal class Program
    {
        /// <summary>
        /// Permet la recherche et l'affichage des informations des eleves dans un groupe de test à partir de la profession exercée
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Groupe groupeCda = CreerGroupeDeTest();

                /*
                List<String> metiers = ExtractMetier(groupeCda);
                String metierSearch = SaisieUtil.ChoiseFromMenu("Please enter job to search !", metiers, 5);
                List<Eleve> elevesWithMetier = FilterEleveByJob(groupeCda, metierSearch);
                DisplayElevesInformations(elevesWithMetier);
                */

                DisplayElevesInformations(FilterEleveByJob(groupeCda, SaisieUtil.ChoiseFromMenu("Please enter job to search !", ExtractMetier(groupeCda), 5)));
            }

            catch (ArgumentNullException argumentNullException)
            {
                 #if DEBUG
                    DisplayExceptionInformations(argumentNullException);
                 #endif
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                #if DEBUG
                    DisplayExceptionInformations(argumentOutOfRangeException);
                #endif
            }
            catch (InvalidOperationException invalidOperationException)
            {
                Console.WriteLine("");
                Console.WriteLine("Sil vous plait, retirer vos moufles pour utiliser l'application ! ");

                #if DEBUG
                    DisplayExceptionInformations(invalidOperationException);
                #endif
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Une erreur s'est produite pendant l'execution de l'application ! ");
            }
            finally 
            {
                Console.WriteLine("");
                Console.WriteLine("Apputer sur une touche pour terminer le programme ! ");
            }
           
        }

        static Groupe CreerGroupeDeTest()
        {
            Groupe groupeDeTest = new Groupe()
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

            return groupeDeTest;
        } 

        static List<String> ExtractMetier(Groupe group)
        {
            List<String> result = group.Eleves.Select(p=>p.Metier).Distinct().OrderBy(p=>p).ToList();
            return result;
        }


        static List<Eleve> FilterEleveByJob(Groupe group, String metierSearch)
        {
            List<Eleve> result = group.Eleves.Where(p=>p.Metier == metierSearch).OrderBy(p=>p.Nom).ThenBy(p=>p.Prenom).ToList();
            return result;
        }

        static void DisplayElevesInformations(List<Eleve> eleves)
        {
            if (eleves == null || (eleves!= null && eleves.Count == 0))
            {
                Console.WriteLine("");
                Console.WriteLine("Aucun élève ne correspond au critère saisi ! ");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Voici les élèves trouvé :");

                foreach (Eleve eleve in eleves)
                {
                    Console.WriteLine("{0} {1}, \t adresse mail : {2}, \t métier {3}", eleve.Prenom, eleve.Nom, eleve.Email, eleve.Metier );
                }
            }
        }

        static void DisplayExceptionInformations (Exception exception)
        {
            Console.WriteLine("");
            Console.WriteLine(exception.Message);
            Console.WriteLine("Inner Exception : {0} ", exception.InnerException);
            Console.WriteLine("Stack trace : {0} ", exception.StackTrace);
        }
    }

}


