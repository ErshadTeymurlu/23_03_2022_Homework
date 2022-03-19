using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _23_03_2022_Homework.Models;

namespace _23_03_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("M4 COMPETITION","BMW","2021");
            car1.TurnOn();
            car1.Go(100);
            Console.ReadLine();
        }
    }
}
