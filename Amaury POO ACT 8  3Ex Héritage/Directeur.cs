using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_ACT_8__Ex_Héritage
{
    internal class Directeur : Employe
    {
        private double _pourcentage;
        public double Pourcentage
        {
            get { return _pourcentage; }
            set { _pourcentage = value; }
        }

        private double _chiffreAffaire;
        public double ChiffreAffaire
        {
            get { return _chiffreAffaire; }
            set { _chiffreAffaire = value; }
        }

        public override double getSalaire()
        {
            return Salaire + (ChiffreAffaire * Pourcentage);
        }

        public override void Afficher()
        {
            Console.WriteLine($"Directeur : {Nom} {Prenom}");
            Console.WriteLine($"Chiffre d'affaire : {ChiffreAffaire}");
            Console.WriteLine($"Salaire : {getSalaire()}");
        }
    }
}
