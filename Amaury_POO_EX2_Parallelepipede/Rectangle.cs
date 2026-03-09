using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_EX2_Parallelepipede
{
    internal class Rectangle : Parallelepipede
    {
        // Attribut privé
        private float longeur;
        private float largeur;

        // Propriété avec encapsulation
        public float Largeur
        {
            get { return Largeur; }
            set
            {
                if (value > 0)
                    Largeur = value;
                else
                    throw new Exception("Le Largeur doit être positif !");
            }
        }
        public float Longeur
        {
            get { return Longeur; }
            set
            {
                if (value > 0)
                    Longeur = value;
                else
                    throw new Exception("Le Longeur doit être positif !");
            }
        }
        // Constructeur
        public Rectangle(float L,float l, string couleur) : base(couleur)
        {
            longeur = L;
            largeur = l; 
        }

        // Méthode pour calculer l'aire
        public double CalculAireRectangle()
        {
            return  longeur * largeur;
        }

        // Méthode pour calculer le périmètre
        public double CalculPerimetreRectangle()
        {
            return (longeur + largeur)*2;
        }

        // Méthode d'affichage
        public void Afficher()
        {
            Console.WriteLine($"Le rectangle de longeur {longeur} et de largeur {largeur}a un périmètre de {CalculPerimetre():0.00} et une aire de {CalculAire():0.00}");
        }
    }
}
 