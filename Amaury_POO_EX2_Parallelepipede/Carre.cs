using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_EX2_Parallelepipede
{
    internal class Carre : Parallelepipede
    {
        // Attribut privé
        private float cote;

        // Propriété avec encapsulation
        public float Cote
        {
            get { return Cote; }
            set
            {
                if (value > 0)
                    Cote = value;
                else
                    throw new Exception("Le cote doit être positif !");
            }
        }
        // Constructeur
        public Carre(float c, string couleur) : base(couleur)
        {
            cote = c;
        }

        // Méthode pour calculer l'aire
        public double CalculAireCarre()
        {
            return  cote * cote;
        }

        // Méthode pour calculer le périmètre
        public double CalculPerimetreCarre()
        {
            return 4 * cote;
        }

        // Méthode d'affichage
        public void Afficher()
        {
            Console.WriteLine($"Le carre de cote {cote} a un périmètre de {CalculPerimetre():0.00} et une aire de {CalculAire():0.00}");
        }
    }
}
