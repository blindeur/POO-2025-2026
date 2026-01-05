using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_EX2_POO_nombre_complexe
{
    using System;

    public class Complexe
    {
        private double reel;
        private double imaginaire;

        public double Reel
        {
            get { return reel; }
            set { reel = value; }
        }

        public double Imaginaire
        {
            get { return imaginaire; }
            set { imaginaire = value; }
        }

        public Complexe(double r, double i)
        {
            Reel = r;
            Imaginaire = i;
        }

        // Retourne par exemple "(1.00, -2.00)"
        public string AfficheComplexe()
        {
            return $"({Reel:0.00}, {Imaginaire:0.00})";
        }

        // √(a² + b²)
        public double CalculeModule()
        {
            return Math.Sqrt(Reel * Reel + Imaginaire * Imaginaire);
        }

        // Modifie le nombre courant (pas de création d’un 3e nombre)
        public void Ajoute(Complexe c)
        {
            Reel += c.Reel;
            Imaginaire += c.Imaginaire;
        }
    }

}
