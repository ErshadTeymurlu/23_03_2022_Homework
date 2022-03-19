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
        public Car(string model, string make , string year) : base(model, make, year)
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

        }
        public override void GetDetailedInfo()
        {

        }

        
    }
}
