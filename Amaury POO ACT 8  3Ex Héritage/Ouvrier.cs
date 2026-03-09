using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_ACT_8__Ex_Héritage
{
    internal class Ouvrier : Employe
    {
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

        // Calcul salaire
        public override double getSalaire()
        {
            int anciennete = DateTime.Now.Year - _dateEntreSociete.Year;
            return Salaire + (anciennete * 100);
        }

        // Affichage
        public override void Afficher()
        {
            Console.WriteLine($"Ouvrier : {Nom} {Prenom}");
            Console.WriteLine($"Spécialité : {Specialite}");
            Console.WriteLine($"Salaire : {getSalaire()}");
        }
    }
}
