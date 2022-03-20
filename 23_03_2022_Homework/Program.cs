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
            Car cr1 = new Car("BMW","M4 Competition","2022");
            Console.WriteLine("To Turn On The Engine Write Yes: ");
            string yesOrNo = Console.ReadLine();
            if(yesOrNo == "yes")
            {
                cr1.TurnOn();
            }
            Console.Write("How much distance do yo want to go? : ");
            int km = Convert.ToInt32(Console.ReadLine());
            cr1.Go(km);
            Console.ReadLine();
        }
    }
}
