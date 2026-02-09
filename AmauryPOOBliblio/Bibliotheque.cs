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
        public string ajoute(Livre livre)
        {
            
            string info = $"Ajout du livre : {livre.Titre} par {livre.Auteur}";
           
            if (livre.Etat > 0)
            {
                livres.Add(livre);
                info +=  "Le livre est en bon état et sera ajouté à la bibliothèque.";

            }else
            {
                info += "Le livre est abîmé et ne sera pas ajouté à la bibliothèque.";
            }

            return info;
        }

        public void supprime_livres_abimes()
        {
            //livres.RemoveAll(l => l.etat == 0); BON MAIS ON PART SUR DU CLASSIQUE
            for (int i = livres.Count - 1; i >= 0; i--)
            {
                if (livres[i].Etat == 0)
                {
                    livres.RemoveAt(i);
                }
            }
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
