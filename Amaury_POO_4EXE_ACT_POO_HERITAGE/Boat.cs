using System;
using System.Collections.Generic;
using System.Text;

namespace Amaury_POO_4EXE_ACT_POO_HERITAGE
{
    class Boat : Vehicle
    {
        public double Tonnage { get; set; }

        public Boat(string brand, double fuel, double tonnage) : base(brand, fuel)
        {
            Tonnage = tonnage;
        }

        public override void Info()
        {
            Console.WriteLine($"Boat: Brand={Brand}, Fuel={Fuel}, Tonnage={Tonnage}");
        }
    }
}
