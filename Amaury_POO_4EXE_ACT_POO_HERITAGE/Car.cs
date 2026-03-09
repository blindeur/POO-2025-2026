using System;
using System.Collections.Generic;
using System.Text;

namespace Amaury_POO_4EXE_ACT_POO_HERITAGE
{
    class Car : RoadVehicle
    {
        public Car(string brand, double fuel, double km) : base(brand, fuel, km) { }

        public override void Info()
        {
            Console.WriteLine($"Car: Brand={Brand}, Fuel={Fuel}, Km={Km}");
        }
    }
}
