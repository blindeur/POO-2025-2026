using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOBiblioV2
{
    public class Abonne
    {
        private string _nom;
        private string _prenom;
        private string _email;

        public Abonne(string nom, string prenom, string email)
        {
            _nom = nom;
            _prenom = prenom;
            _email = email;
        }

        public string Nom
        {
            get { return _nom; }
        }

        public string Prenom
        {
            get { return _prenom; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Infos()
        {
            return $"{_prenom} {_nom} - {_email}";
        }
    }
}