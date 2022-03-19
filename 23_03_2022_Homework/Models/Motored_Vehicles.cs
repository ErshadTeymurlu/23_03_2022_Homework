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
        public int fuelCapacity;
        public int fuelAmount;
        public int speed;
        public double desiredDistance;
        public double fuelUsedPerKm;
        public string interiorColor;
        public string exteriorColor;
        public string transmission;
        public string horsePower;
        public string passangerCapacity;
        public string wheelBase;
        public string torque;
        public List<string> techFeatures;
        public Motored_Vehicles()
        {

        }
        public Motored_Vehicles(string make, string model, string productionYear)
        {
            this.make = make;
            this.model = model;
            this.productionYear = productionYear;
        }
        public void SpeedUpOrSlowDown(ref double km, int speed)
        {

            Console.WriteLine($"Speed: {speed}    Fuel Amount: {fuelAmount}   Remaining distance: {km}");
           SpeedControl: ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                this.speed += 5;
                km--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                this.speed = this.speed - 5;
                if (speed <= 0)
                {
                    Console.WriteLine("You can't get any slower. Your car has stopped"); this.speed = 0; goto SpeedControl;
                }
                km--;
            }    
        }
        public void GetInfo()
        {
            if (make == "BMW")
            {
                if (productionYear == "2021")
                {
                    if (model == "M4 COMPETITION")
                    {
                        interiorColor = "Black";
                        exteriorColor = "Black";
                        fuelCapacity = 70;
                        fuelUsedPerKm = 9.8 / 100;
                        passangerCapacity = "4";
                        techFeatures = new List<string> { "Leather Seats", "Navigation System", "Front Seat Heaters", "Heated Steering Wheel",
                        "Sunroof","Memory Seat(s)","Air Conditioning","AM/FM Stereo", "Cruise Control"};
                    }
                }
                Console.WriteLine("Make: " + make);
                Console.WriteLine("Model: " + model);
                Console.WriteLine("Exterior Color: " + exteriorColor);
                Console.WriteLine("Interior Color: " + interiorColor);
                Console.WriteLine("Passenger Capacity: " + passangerCapacity);
                Console.WriteLine("Fuel Capacity: " + fuelCapacity);
                Console.WriteLine("Fuel Used Per km: " + fuelUsedPerKm);
                Console.Write("Technalogy features: ");
                foreach (string item in techFeatures) Console.Write($"{item} ");
            }
        }

        public virtual void GetDetailedInfo()
        {
            if (make == "BMW")
            {
                if (productionYear == "2021")
                {
                    if (model == "M4 COMPETITION")
                    {
                        wheelBase = "112.5 (inch)";
                        transmission = "Automatic";
                        motorSize = "3.0";
                        horsePower = "503 HP";
                        torque = "479";
                    }
                }
                Console.WriteLine("Motor Size: " + motorSize);
                Console.WriteLine("Horse Power: " + horsePower);
                Console.WriteLine("Torque: " + torque);
                Console.WriteLine("Transmission: " + transmission);
                Console.WriteLine("Transmission: " + wheelBase);
            }
        }
    }
}
