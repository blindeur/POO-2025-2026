using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_ACT_8__Ex_Héritage
{
    internal class Ouvrier : Employe
    {
        // Attribut privé
        private string _specialite;
        public string Specialite
        {
            get { return _specialite; }
            set { _specialite = value; }
        }

        private DateTime _dateEntreSociete;
        public DateTime DateEntreSociete
        {
            get { return _dateEntreSociete; }
            set { _dateEntreSociete = value; }
        }

        // Constructeur






        // Méthode pour calculer
        public  double getSalaire();

        // Méthode d'affichage
        public  void Afficher();
    }
}
