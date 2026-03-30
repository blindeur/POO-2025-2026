using BiblioVersion1.classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioVersion1
{
    public static class methodeDuProjet
    {
        public static int lireEntier(string question)
        {
            string nUser;
            int entier;
            do
            {
                Console.WriteLine(question);
                nUser = Console.ReadLine();

            } while (!int.TryParse(nUser, out entier));
            return entier;

        }
        public static bool TrouveLivre(string titre, List<Livre> biblio, out Livre livre)
        {
            bool trouve = false;
            livre = null;
            foreach (Livre item in biblio)
            {
                if (item.Titre == titre)
                {
                    livre = item;
                    trouve = true;
                }
            }
            return trouve;
        }

        public static bool TrouveLivreAvecId(int numero, List<Livre> biblio, out Livre livre)
        {
            bool trouve = false;
            livre = null;
            foreach (Livre item in biblio)
            {
                if (item.Id == numero)
                {
                    livre = item;
                    trouve = true;
                }
            }
            return trouve;
        }
        public static bool TrouveEmprunt(string titre, List<Emprunt> emprunts, out Emprunt emprunt)
        {
            bool trouve = false;
            emprunt = null;
            foreach (Emprunt item in emprunts)
            {
                if (item.LivreEmprunte.Titre == titre)
                {
                    emprunt = item;
                    trouve = true;
                }
            }
            return trouve;
        }
        public static bool TrouveAbonne(string nom, List<Abonne> abonnes, out Abonne abonne)
        {
            bool trouve = false;
            abonne = null;
            foreach (Abonne item in abonnes)
            {
                if (item.Nom == nom)
                {
                    abonne = item;
                    trouve = true;
                }
            }
            return trouve;
        }
        public static bool TrouveAbonneAvecId(int numero, List<Abonne> abonnes, out Abonne abonne)
        {
            bool trouve = false;
            abonne = null;
            foreach (Abonne item in abonnes)
            {
                if (item.Id == numero)
                {
                    abonne = item;
                    trouve = true;
                }
            }
            return trouve;
        }
    }
}


