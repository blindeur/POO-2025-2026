using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOBliblio
{
    internal class Livre
    {

        // Attributs
        public string titre;
        public string auteur;
        public int etat;

        // Constructeur
        public Livre(string titre, string auteur, int etat)
        {
            this.titre = titre;
            this.auteur = auteur;

            if (etat < 0)
                this.etat = 0;
            else if (etat > 5)
                this.etat = 5;
            else
                this.etat = etat;
        }

        // Méthodes
        public void degrade()
        {
            if (etat > 0)
            {
                etat--;
            }
        }

        public void description()
        {
            Console.WriteLine("Titre : " + titre);
            Console.WriteLine("Auteur : " + auteur);
            Console.WriteLine("État : " + etat);
            Console.WriteLine("------------------------");
        }
    }
}

