using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOBiblioV2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using System.Collections.Generic;
    using System.Text;
    using System;

    public class Bibliotheque
    {
        private List<Livre> _livres;
        private List<Emprunt> _emprunts;
        private List<Abonne> _abonnes;

        public Bibliotheque()
        {
            _livres = new List<Livre>();
            _emprunts = new List<Emprunt>();
            _abonnes = new List<Abonne>();
        }

        public List<Livre> Livres
        {
            get { return _livres; }
        }

        public List<Emprunt> Emprunts
        {
            get { return _emprunts; }
        }

        public List<Abonne> Abonnes
        {
            get { return _abonnes; }
        }

        public void Ajoute(Livre livre)
        {
            _livres.Add(livre);
        }

        public void SupprimeLivresAbimes()
        {
            _livres.RemoveAll(l => l.Etat >= 2);
        }

        public string Inventaire()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Livre livre in _livres)
                sb.AppendLine(livre.Description());

            return sb.ToString();
        }

        public void CreeAbonne(string nom, string prenom, string email)
        {
            _abonnes.Add(new Abonne(nom, prenom, email));
        }

        public void AjouteEmpruntLivre(Livre livre, Abonne abonne, DateTime dateRetour)
        {
            _emprunts.Add(new Emprunt(livre, abonne, dateRetour));
        }

        public string ListesEmprunts()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Emprunt emprunt in _emprunts)
                sb.AppendLine(emprunt.Infos());

            return sb.ToString();
        }

        public string ListeAbonnes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Abonne abonne in _abonnes)
                sb.AppendLine(abonne.Infos());

            return sb.ToString();
        }
    }


}
