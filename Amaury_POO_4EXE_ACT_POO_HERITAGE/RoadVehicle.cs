using System;
using System.Collections.Generic;
using System.Text;

namespace Amaury_POO_4EXE_ACT_POO_HERITAGE
{
    abstract class RoadVehicle : Vehicle
    {
        public double Km { get; set; }

        public RoadVehicle(string brand, double fuel, double km) : base(brand, fuel)
        {
            Km = km;
        }
    }
}
