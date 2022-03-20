using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_03_2022_Homework.Models
{
    internal class Car : Motored_Vehicles
    {
        public bool isOn;
        public string transmission;
        public string horsePower;
        public Car(string model, string make, string year , double fuelUsedPer100Km) : base(model, make, year , fuelUsedPer100Km)
        {

        }
        public bool TurnOn()
        {
            isOn = true;
            return isOn;
        }
        public void TurnOff()
        {
            isOn = false;
        }
        public void Go(int km)
        {
            double fuelNeeded = (km / 100) * fuelUsedPer100Km;
            if (TurnOn())
            { 
                if (fuelAmount >= fuelNeeded)
                {
                    fuelAmount = fuelAmount - fuelNeeded;
                    Console.WriteLine($"Current Fuel Amount is {fuelAmount}  ,you've traveled {km} km!");
                }
                else Console.WriteLine("Yo don't have enought fuel to go that much distance.");
            }
        }
        public override double GetDetailedInfo()
        {
            return base.GetDetailedInfo();
        }


    }
}
