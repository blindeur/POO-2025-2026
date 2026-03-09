using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_ACT_8__Ex_Héritage
{
   public abstract class Employe
    {
        //Attributs communs à tous les employés
        
        protected string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        protected string _prenom;
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        protected string _matricule;
        public string Matricule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }
        protected double _salaire;
        public double Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }
        protected DateTime _dateDeNaissance;
        public DateTime DateDeNaissance
        {
            get { return _dateDeNaissance; }
            set { _dateDeNaissance = value; }
        }





        // Méthode pour calculer
        public abstract double getSalaire();

        // Méthode d'affichage
        public abstract void Afficher();
    }
}
