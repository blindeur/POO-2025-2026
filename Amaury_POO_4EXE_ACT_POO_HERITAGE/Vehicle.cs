using System;
using System.Collections.Generic;
using System.Text;

namespace Amaury_POO_4EXE_ACT_POO_HERITAGE
{
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public double Fuel { get; set; }

        public Vehicle(string brand, double fuel)
        {
            Brand = brand;
            Fuel = fuel;
        }

        public abstract void Info();
    }

}
