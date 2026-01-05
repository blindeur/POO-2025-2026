using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOHeritageVehicule
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }

        private bool _gps;
        public bool Gps
        {
            get { return _gps; }
            set { _gps = value; }
        }

        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }
        


        public override string Affiche() 
        {
            //string info = véhicule de marque + _marque + , modèle + _modele + , couleur + _couleur + , prix + _prix;
            string info = base.Affiche() + ", Motorisation: " + _motorisation + ", GPS: " + _gps;
            return info;
        }
    }
}
