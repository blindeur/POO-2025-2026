using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOHeritageVehicule
{
    internal class Velo : Vehicule
    {
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        private bool _EstElectrique;
        public bool EstElectrique
        {
            get { return _EstElectrique; }
            set { _EstElectrique = value; }
        }

        public Velo(string type, bool electrique, string modele, string marque, string couleur, decimal prix): base(modele, marque, couleur, prix)
        { 
            _type = type;
            _EstElectrique = electrique;

        }

        public override string Affiche() 
        {
            //string info = véhicule de marque + _marque + , modèle + _modele + , couleur + _couleur + , prix + _prix;
            string info = base.Affiche() + ", Type: " + _type + ", Electrique: " + _EstElectrique;
            return info;
        }
    }
}
