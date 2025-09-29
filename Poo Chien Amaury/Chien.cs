using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Chien_Amaury
{
    internal class Chien
    {

        // Attributs
        private string _nom;
        private string _race;
        private int _age;
        private string _pelage;
        private string _taille; // petit, moyen, grand
        private string _poids; // léger, moyen, lourd
        private bool _agressivite;
        private bool _sociabilite; // avec les autres chiens et les humains
        private string _tag; // collier avec puce électronique


        // Constructeur
        public Chien(string nom, string race, int age, string pelage,string taille ,string poids, bool agressivite, bool sociabilite, string tag)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _pelage = pelage;
            _poids = poids;
            _taille = taille;
            _agressivite = agressivite;
            _sociabilite = sociabilite;
            _tag = tag;
        }
        // Méthodes
        public string RaceChien()
        {
            return $"{_nom} est un {_race}";
        }
        public string Aboyer()
        {
            return "Woof Woof!";
        }
        public string Manger(string nourriture)
        {
            return $"{_nom} mange {nourriture}.";
        }
        public string Jouer(string jouet)
        {
            return $"{_nom} joue avec {jouet}.";
        }
        public string SeFaireCaresser()
        {
            if (_sociabilite)
            {
                return $"{_nom} aime se faire caresser!";
            }
            else
            {
                return $"{_nom} n'aime pas se faire caresser.";
            }
        }
        public string FaireUnePromenade(string lieu)
        {
            return $"{_nom} fait une promenade à {lieu}.";
        }

        public string AfficherInfos()
        {
            return $"Nom: {_nom} " + $" age: {_age} ans " + $" taille: {_taille} cm " + $" pelage: son pelage est {_pelage} " + $" tag: son tag est {_tag} ";

        }
       
        
    }
}
