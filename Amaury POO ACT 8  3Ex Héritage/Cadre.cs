using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO_ACT_8__Ex_Héritage
{
    internal class Cadre : Employe
    {
        private int _indice;

        public int Indice
        {
            get { return _indice; }
            set { _indice = value; }
        }

        public override double getSalaire()
        {
            switch (_indice)
            {
                case 1:
                    return Tarification.SAL_T1;
                case 2:
                    return Tarification.SAL_T2;
                case 3:
                    return Tarification.SAL_T3;
                case 4:
                    return Tarification.SAL_T4;
                default:
                    return 0;
            }
        }

        public override void Afficher()
        {
            Console.WriteLine($"Cadre : {Nom} {Prenom}");
            Console.WriteLine($"Indice : {_indice}");
            Console.WriteLine($"Salaire : {getSalaire()}");
        }
    }
}
