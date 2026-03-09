using System.Diagnostics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace Amaury_POO_4EXE_ACT_POO_HERITAGE
{
    internal class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                Console.WriteLine("\nChoisir un type de véhicule : 1-Car, 2-Truck, 3-Boat, 4-Plane, 0-Quitter");
                string choice = Console.ReadLine();

                if (choice == "0") break;

                Console.Write("Marque : ");
                string brand = Console.ReadLine();

                Console.Write("Carburant : ");
                double fuel = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.Write("Kilométrage : ");
                        double kmCar = double.Parse(Console.ReadLine());
                        vehicles.Add(new Car(brand, fuel, kmCar));
                        break;

                    case "2":
                        Console.Write("Kilométrage : ");
                        double kmTruck = double.Parse(Console.ReadLine());
                        Console.Write("Poids max : ");
                        double weight = double.Parse(Console.ReadLine());
                        vehicles.Add(new Truck(brand, fuel, kmTruck, weight));
                        break;

                    case "3":
                        Console.Write("Tonnage : ");
                        double tonnage = double.Parse(Console.ReadLine());
                        vehicles.Add(new Boat(brand, fuel, tonnage));
                        break;

                    case "4":
                        Console.Write("Distance max : ");
                        double range = double.Parse(Console.ReadLine());
                        vehicles.Add(new Plane(brand, fuel, range));
                        break;

                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
            }

            Console.WriteLine("\n--- Liste des véhicules ---");
            foreach (var v in vehicles)
            {
                v.Info();
            }
        }
    }
}
