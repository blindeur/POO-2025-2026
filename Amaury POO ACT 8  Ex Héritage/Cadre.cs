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


        // Méthode pour calculer
        public  double getSalaire();

        // Méthode d'affichage
        public  void Afficher();
    }
}
