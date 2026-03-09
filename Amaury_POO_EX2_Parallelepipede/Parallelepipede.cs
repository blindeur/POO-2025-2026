using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_EX2_Parallelepipede
{
    public abstract class Parallelepipede
    {
        // Attribut privé
        private string _couleur;
        public string Couleur { get; set; }

        // Constructeur
        public Parallelepipede( string couleur) 
        {
            _couleur = couleur;
        }

        // Méthode pour calculer l'aire
        public abstract double CalculAire();


        // Méthode pour calculer le périmètre
        public abstract double CalculPerimetre();


        // Méthode d'affichage
        public abstract void Afficher();
      
    }
}
