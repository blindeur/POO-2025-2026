using System;
using System.Collections.Generic;
using System.Text;

namespace Amaury_POO_4EXE_ACT_POO_HERITAGE
{
    class Truck : RoadVehicle
    {
        public double Weight { get; set; }

        public Truck(string brand, double fuel, double km, double weight) : base(brand, fuel, km)
        {
            Weight = weight;
        }

        public override void Info()
        {
            Console.WriteLine($"Truck: Brand={Brand}, Fuel={Fuel}, Km={Km}, Weight={Weight}");
        }
    }
}
