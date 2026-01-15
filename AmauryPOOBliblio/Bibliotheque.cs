using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOBliblio
{
    internal class Bibliotheque
    {
        // Attribut
        public List<Livre> livres;

        // Constructeur
        public Bibliotheque()
        {
            livres = new List<Livre>();
        }

        // Méthodes
        public void ajoute(Livre livre)
        {
            livres.Add(livre);
        }

        public void supprime_livres_abimes()
        {
            livres.RemoveAll(l => l.etat == 0);
        }

        public void inventaire()
        {
            Console.WriteLine("Inventaire de la bibliothèque :");
            Console.WriteLine("===============================");

            if (livres.Count == 0)
            {
                Console.WriteLine("Aucun livre dans la bibliothèque.");
            }

            foreach (Livre livre in livres)
            {
                livre.description();
            }
        }
    }
}
