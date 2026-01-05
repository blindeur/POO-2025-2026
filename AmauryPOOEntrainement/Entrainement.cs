using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOEntrainement
{
    public class Entrainement
    {
        // ----- Attributs -----
        private string _nomCoureur;
        private double _distanceKm;
        private int _tempsSecondes;

        // ----- Constructeur -----
        public Entrainement(string nom, double distance, int temps)
        {
            _nomCoureur = nom;
            _distanceKm = distance;
            _tempsSecondes = temps;
        }

        // ----- Méthode : Vitesse moyenne -----
        public double VitesseMoyenne()
        {
            // temps en heures = secondes / 3600
            double tempsHeures = _tempsSecondes / 3600.0;
            double vitesse = _distanceKm / tempsHeures;
            return Math.Round(vitesse, 2); // arrondi à 2 décimales
        }

        // ----- Méthode : Différence de temps par rapport au meilleur -----
        public int DiffTempsParRapportAuPremier(int meilleurTemps)
        {
            return _tempsSecondes - meilleurTemps;
        }

        // ----- Méthode : ToString -----
        public override string ToString()
        {
            return $"Coureur : {_nomCoureur} | Distance : {_distanceKm} km | Temps : {_tempsSecondes} s | Vitesse : {VitesseMoyenne()} km/h";
        }
    }
}
