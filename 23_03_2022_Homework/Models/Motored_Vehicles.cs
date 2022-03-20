using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_03_2022_Homework.Models
{
    internal class Motored_Vehicles
    {
        public string model;
        public string make;
        public string productionYear;
        public string motorSize;
        public string fuelTankSize;
        public double fuelAmount = 0;
        public double fuelUsedPer100Km;
        public string color;
        public string passangerCount = "4";
        public Motored_Vehicles()
        {

        }
        public Motored_Vehicles(string model, string make, string productionYear, double fuelUsedPer100Km)
        {
            this.model = model;
            this.make = make;
            this.productionYear = productionYear;
            this.fuelUsedPer100Km = fuelUsedPer100Km;
        }
        public void GetInfo()
        {
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Production year: " + productionYear);
            Console.WriteLine("Fuel consuption: " + fuelUsedPer100Km);
            Console.WriteLine("Passenger count: " + passangerCount);
        }
        public virtual double GetDetailedInfo()
        {
            return fuelAmount;
        }
    }
}
