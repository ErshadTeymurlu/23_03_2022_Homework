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
        public string fuelAmount;
        public int fuelUsedPerKm;
        public string interiorColor;
        public string exteriorColor;
        public string transmission;
        public string horsePower;
        public string passangerCapacity;
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
        public void GetInfo()
        {
            if(make == "BMW")
            {
                if(productionYear == "2021")
                {
                    if(model == "M4 COMPETITION")
                    {
                        interiorColor = "Black";
                        exteriorColor = "Black";
                        passangerCapacity = "4";
                        transmission = "Automatic";
                        techFeatures = new List<string>{"Leather Seats","Navigation System","Front Seat Heaters","Heated Steering Wheel" 
                        "Sunroof","Memory Seat(s)","Air Conditioning","AM/FM Stereo", "Cruise Control"};
                    }
                }
            }
        }
   
        public virtual void GetDetailedInfo()
        {
            if(make == "BMW")
            {
                if(productionYear == "2021")
                {
                    if(model == "M4 COMPETITION")
                    {
                        motorSize = "3.0";
                        
                    }
                }
            }

        }
    }
}
