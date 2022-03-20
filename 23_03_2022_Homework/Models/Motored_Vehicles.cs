﻿using System;
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
        public double fuelAmount;
        public double fuelUsedPerKm;
        public string color;
        public string passangerCount;
        public Motored_Vehicles()
        {

        }
        public Motored_Vehicles(string model, string make, string productionYear)
        {
            this.model = model;
            this.make = make;
            this.productionYear = productionYear;
        }
        public void GetInfo()
        {

        }
        public virtual double GetDetailedInfo()
        {
            return fuelAmount;
        }
    }
}
