using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CineDechDimitrio
{
    // Classe contenant les méthodes abstraites du projet
    class CinemaMethods
    {
        // Fonction de recherche de genre par id
        internal static Genre searchGenreById(List<Genre> genres, int id)
        {
            Boolean isFound = false;
            Genre genre = null;
            int i = 0;

            while (!isFound && i < genres.Count)
            {
                if (genres[i].getId() == id)
                {
                    genre = genres[i];
                    isFound = true;
                }
                else
                {
                    i++;
                }
            }

            return genre;
        }

        // Fonction de recherche de genre par nom
        public static Genre searchGenreByName(List<Genre> genres, String name)
        {
            Boolean isFound = false;
            Genre genre = null;
            int i = 0;

            while (!isFound && i < genres.Count)
            {
                if (genres[i].getName() == name)
                {
                    genre = genres[i];
                    isFound = true;
                }
                else
                {
                    i++;
                }
            }

            return genre;
        }

        // Fonction de vérification de champ d'identifiant
        public static Boolean verifIdField(ref String text)
        {
            replaceQuotes(ref text);

            /** Si le champ ne contient que des lettres et nombres et
                que le champ n'est ni vide ni rempli d'espaces **/
            if (Regex.IsMatch(text, @"^+[a-zA-Z0-9]+$"))
            {
                return true;
            }
            return false;
        }

        // Fonction de vérification de champ contenant uniquement des chiffres
        public static Boolean verifIntField(ref String text)
        {
            if (Regex.IsMatch(text, @"^[0-9]+$"))
            {
                return true;
            }
            return false;
        }

        // Fonction de vérification de champ de texte
        public static void correctTextField(ref String text)
        {
            if (text.Length > 1)
            {
                replaceFirstSpaces(ref text);
                replaceQuotes(ref text);
            }
        }

        private static void replaceFirstSpaces(ref string text)
        {
            // Si le premier caractère est un espace on le supprime
            while (text[0] == ' ')
            {
                text = text.Substring(1, text.Length - 1);
            }
        }

        // Fonction remplaçant les quotes par des doubles quote pour éviter les bugs / injections
        private static void replaceQuotes(ref String text)
        {
            // Si le champ contient des apostrophes on les remplaces pour éviter des bugs ou injections
            if (text.Contains("'"))
            {
                text = text.Replace("'", "''");
            }
        }

        // Fonction de message d'alerte
        public static void alert(String text)
        {
            MessageBox.Show(text);
        }
    }
}
