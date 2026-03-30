using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioVersion1.classes
{
    public class Livre
    {
        private int _id;
        private string _titre;
        private string _prenomAuteur;
        private string _nomAuteur;
        private int _anneeDeParution;
        private int _etat;
        
        public int Id { get { return _id; } set { _id = value; } }
        public string Titre { get { return _titre; } }
        public string PrenomAuteur { get { return _prenomAuteur; } }
        public string NomAuteur { get { return _nomAuteur; } }
        public int AnneeDeParution { get { return _anneeDeParution; } }
        public int Etat { get { return _etat; } set { _etat = value; } }

        public Livre(int id , string titre, string PrenomAuteur, string NomAuteur, int AnneeDeParution, int etat)
        {
            _id = id;
            _titre = titre;
            _prenomAuteur = PrenomAuteur;
            _nomAuteur = NomAuteur;
            _anneeDeParution = AnneeDeParution;
            _etat = etat;
        }

        public bool Degrade()
        {
            _etat--;
            if (_etat <= 0)
            {
                _etat = 0;
                return true;
            }
            return false;
        }
        public string Description()
        {
            return _titre + " " + _prenomAuteur + " " + _nomAuteur + " " + _anneeDeParution + " " +_etat + "\n";
        }
    }
}
