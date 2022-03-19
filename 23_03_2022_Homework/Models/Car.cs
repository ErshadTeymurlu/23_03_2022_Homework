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
        public Car(string make, string model, string year) : base(make, model, year)
        {

        }
        public void TurnOn()
        {
            isOn = true;
            Console.Clear();
        }
        public void TurnOff()
        {
           isOn = false;
        }
        public void Go(int km)
        {
            this.desiredDistance = km;
            this.speed = 0;
            this.fuelAmount = 50;
            if (isOn == false) return;
            else
            {
                while(desiredDistance >= 0)
                {
                    SpeedUpOrSlowDown(ref desiredDistance, speed, ref fuelAmount);
                }
            }
        }
        public override void GetDetailedInfo()
        {

        }

        
    }
}
