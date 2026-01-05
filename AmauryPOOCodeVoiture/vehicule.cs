using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmauryPOOCodeVoiture
{
    using System;

    public class vehicule
    {
        // ----- Attributs -----
        private string _PlaqueDimmatriculation;
        private string _marque;
        private string _modele;
        private double _capaciteMaximumReservoir;
        private double _niveauJaugeCarburant;

        // ----- Constructeur -----
        public vehicule(string plaque, string marque, string modele, double capaciteMax, double niveauInitial)
        {
            _PlaqueDimmatriculation = plaque;
            _marque = marque;
            _modele = modele;
            _capaciteMaximumReservoir = capaciteMax;
            _niveauJaugeCarburant = Math.Min(niveauInitial, capaciteMax); // éviter de dépasser la capacité
        }

        // ----- Méthodes -----

        // Retourne la marque + modèle
        public string TypeVehicule()
        {
            return $"{_marque} {_modele}";
        }

        // Ajoute du carburant sans dépasser la capacité
        public void AjouterCarburant(double litres)
        {
            if (litres <= 0)
            {
                Console.WriteLine("Quantité invalide !");
                return;
            }

            _niveauJaugeCarburant += litres;

            if (_niveauJaugeCarburant > _capaciteMaximumReservoir)
            {
                _niveauJaugeCarburant = _capaciteMaximumReservoir;
                Console.WriteLine("Réservoir plein, ajout limité à la capacité maximale.");
            }
            else
            {
                Console.WriteLine($"{litres} litres ajoutés.");
            }
        }

        // Remplit le réservoir
        public void FaireLePlein()
        {
            _niveauJaugeCarburant = _capaciteMaximumReservoir;
            Console.WriteLine("Le plein a été fait !");
        }

        // Consomme du carburant
        public void ConsommerCarburant(double litres)
        {
            if (litres <= 0)
            {
                Console.WriteLine("Quantité invalide !");
                return;
            }

            _niveauJaugeCarburant -= litres;

            if (_niveauJaugeCarburant < 0)
            {
                _niveauJaugeCarburant = 0;
                Console.WriteLine("Le réservoir est vide !");
            }
            else
            {
                Console.WriteLine($"{litres} litres consommés.");
            }
        }

        // Affiche les informations du véhicule
        public void AfficherInfos()
        {
            Console.WriteLine($"Plaque : {_PlaqueDimmatriculation}");
            Console.WriteLine($"Véhicule : {TypeVehicule()}");
            Console.WriteLine($"Capacité réservoir : {_capaciteMaximumReservoir} L");
            Console.WriteLine($"Niveau de carburant : {_niveauJaugeCarburant} L");
            Console.WriteLine("-------------------------------");
        }
    }
}
