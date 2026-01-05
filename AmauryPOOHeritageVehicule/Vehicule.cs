using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOHeritageVehicule
{
    internal class Vehicule
    {
        // Attributs
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected decimal _prix;

        // Propriétés
        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }

       
        public string Marque

        {
            get { return _marque; }
            set { _marque = value; }
        }

       
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }


        // Constructeur
        public Vehicule(string marque, string modele, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }
        // Méthodes
        public virtual string Affiche()
        {
            string info = "Véhicule de marque: " + _marque + ", modèle: " + _modele + ", couleur: " + _couleur + ", prix: " + _prix;
            return info;
        }


    }
}
