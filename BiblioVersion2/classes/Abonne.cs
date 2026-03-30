using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioVersion1.classes
{
    public class Abonne
    {
        private string _nom;
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Abonne(int id,string nom, string prenom, string email)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _email = email;
        }
        public string Infos()
        {
            return _prenom + "   " + _nom + "  " + _email;
        }
    }
    
	
    
}
