using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOBiblioV2
{


    public class Livre
    {
        private string _titre;
        private string _auteur;
        private byte _etat;

        public Livre(string titre, string auteur, byte etat)
        {
            _titre = titre;
            _auteur = auteur;
            _etat = etat;
        }

        public string Titre
        {
            get { return _titre; }
        }

        public string Auteur
        {
            get { return _auteur; }
        }

        public byte Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        public void Degrade()
        {
            if (_etat < 2)
                _etat++;
        }

        public string Description()
        {
            return $"{_titre} - {_auteur} (État : {_etat})";
        }
    }

}