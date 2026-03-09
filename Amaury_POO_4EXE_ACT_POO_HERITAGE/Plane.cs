using System;
using System.Collections.Generic;
using System.Text;

namespace Amaury_POO_4EXE_ACT_POO_HERITAGE
{
    class Plane : Vehicle
    {
        public double Range { get; set; }

        public Plane(string brand, double fuel, double range) : base(brand, fuel)
        {
            Range = range;
        }

        public override void Info()
        {
            Console.WriteLine($"Plane: Brand={Brand}, Fuel={Fuel}, Range={Range}");
        }
    }
}
