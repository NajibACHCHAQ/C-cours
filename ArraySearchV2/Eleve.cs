using System;
using System.Text.RegularExpressions;

namespace ArraySearchV2
{
    public class Eleve
    {
        private Eleve()
        {

        }

        public Eleve(String prenom, String nom)
        {
            this.Prenom = prenom;
            this.Nom = nom;
        }

        public String Nom { get; init; }

        public String Prenom { get; init; }

        private string email;
        public String Email 
        { 
            get
            {
                return email;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(Email));

                value = value.Trim();
                
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                // Utilisation de l'expression régulière pour la validation
                Regex regex = new Regex(pattern);
                if (!regex.IsMatch(value))
                    throw new ArgumentException("{0} is not a valid mail.", nameof(Email));
                else
                {
                    email = value;
                }
            } 
        }

        public String Metier { get; set; }
    }
}