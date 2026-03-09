using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_EX2_Parallelepipede
{
    internal class Rectangle : Parallelepipede
    {
        // Attributs privés
        private float longeur;
        private float largeur;

        // Propriété Largeur
        public float Largeur
        {
            get { return largeur; }
            set
            {
                if (value > 0)
                    largeur = value;
                else
                    throw new Exception("La largeur doit être positive !");
            }
        }

        // Propriété Longueur
        public float Longeur
        {
            get { return longeur; }
            set
            {
                if (value > 0)
                    longeur = value;
                else
                    throw new Exception("La longueur doit être positive !");
            }
        }

        // Constructeur
        public Rectangle(float L, float l, string couleur) : base(couleur)
        {
            longeur = L;
            largeur = l;
        }

        // Calcul aire
        public override double CalculAire()
        {
            return longeur * largeur;
        }

        // Calcul périmètre
        public override double CalculPerimetre()
        {
            return (longeur + largeur) * 2;
        }

        // Affichage
        public override void Afficher()
        {
            Console.WriteLine($"Le rectangle de longueur {longeur} et de largeur {largeur} a un périmètre de {CalculPerimetre():0.00} et une aire de {CalculAire():0.00}");
        }
    }
}
 