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
        private string _titre;
        private string _auteur;
        private int _etat;

        public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }
        public int Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }


        // Constructeur
        public Livre(string titre, string auteur, int etat)
        {
            this.Titre = titre;
            this.Auteur = auteur;

            if (etat < 0)
                this.Etat = 0;
            else if (etat > 5)
                this.Etat = 5;
            else
                this.Etat = etat;

        }

        // Méthodes
        public void degrade()
        {
            if (Etat > 0)
            {
                Etat--;
            }
        }

        public void description()
        {
            Console.WriteLine("Titre : " + Titre);
            Console.WriteLine("Auteur : " + Auteur);
            Console.WriteLine("État : " + Etat);
            Console.WriteLine("------------------------");
        }
    }
}

