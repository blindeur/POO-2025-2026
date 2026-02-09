using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOBiblioV2
{
    using System;

    using System;

    public class Emprunt
    {
        private Livre _livreEmprunte;
        private DateTime _dateEmprunt;
        private DateTime _dateRetour;
        private Abonne _emprunteur;

        public Emprunt(Livre livre, Abonne abonne, DateTime dateRetour)
        {
            _livreEmprunte = livre;
            _emprunteur = abonne;
            _dateEmprunt = DateTime.Now;
            _dateRetour = dateRetour;
        }

        public Livre LivreEmprunt
        {
            get { return _livreEmprunte; }
        }

        public DateTime DateEmprunt
        {
            get { return _dateEmprunt; }
        }

        public DateTime DateRetour
        {
            get { return _dateRetour; }
            set { _dateRetour = value; }
        }

        public Abonne Emprunteur
        {
            get { return _emprunteur; }
        }

        public string Infos()
        {
            return $"{_livreEmprunte.Titre} | {_emprunteur.Prenom} {_emprunteur.Nom} | Retour : {_dateRetour.ToShortDateString()}";
        }
    }
}
