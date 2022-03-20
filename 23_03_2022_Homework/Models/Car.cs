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
        public Car(string model, string make, string year) : base(model, make, year)
        {

        }
        public void TurnOn()
        {
            isOn = true;
        }
        public void TurnOff()
        {
            isOn = false;
        }
        public void Go(int km)
        {
            fuelUsedPerKm = 0.14;
            fuelAmount = 30;
            double fuelNeeded = (km / 100) * (fuelUsedPerKm * 100);
            if (isOn = true)
            {
                if (fuelAmount >= fuelNeeded)
                {
                    fuelAmount = fuelAmount - fuelNeeded;
                    Console.WriteLine($"Current Fuel Amount is {Math.Round(fuelAmount)}, you've traveled {km} km so far.");
                }
                else Console.WriteLine("Yo don't have enought fuel to go that much distance.");
                if(fuelAmount<10) Console.WriteLine("Your fuel is running low, do yo wanna add");
            }
            else Console.WriteLine("The Vehicle won't move, because the engine hasn't been started yet.");
        }
        public override double GetDetailedInfo()
        {
            return base.GetDetailedInfo();
        }


    }
}
