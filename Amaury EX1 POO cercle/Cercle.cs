using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_EX1_POO_cercle
{
    using System;

    public class Cercle
    {
        // Attribut privé
        private double rayon;

        // Propriété avec encapsulation
        public double Rayon
        {
            get { return rayon; }
            set
            {
                if (value > 0)
                    rayon = value;
                else
                    throw new Exception("Le rayon doit être positif !");
            }
        }

        // Constructeur
        public Cercle(double r)
        {
            Rayon = r;
        }

        // Méthode pour calculer l'aire
        public double CalculAire()
        {
            return Math.PI * rayon * rayon;
        }

        // Méthode pour calculer le périmètre
        public double CalculPerimetre()
        {
            return 2 * Math.PI * rayon;
        }

        // Méthode d'affichage
        public void Afficher()
        {
            Console.WriteLine($"Le cercle de rayon {rayon} a un périmètre de {CalculPerimetre():0.00} et une aire de {CalculAire():0.00}");
        }
    }

}
