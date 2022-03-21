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
            Car cr1 = new Car("M4 Competition","BMW",  "2022", 14.1);
            cr1.GetInfo();
            Console.WriteLine("The Vehicle won't move, because the engine hasn't been started yet. To Turn On The Engine, Press 'Enter'...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                cr1.TurnOn();
                Console.WriteLine("The vehicle has been started!");
            }
            Continue: Console.Write("\ndo yo wanna add fuel? : ");
            string YesOrNo = Console.ReadLine();
            if (YesOrNo == "yes" || YesOrNo == "Yes")
            {
                Console.Write("How much do yo want to add? : ");
                int amountOfFuel = Convert.ToInt32(Console.ReadLine());
                cr1.fuelAmount = cr1.fuelAmount + amountOfFuel;
            }
            else if (YesOrNo == "no" || YesOrNo == "No")
            {
                Console.WriteLine($"You have {cr1.GetDetailedInfo()} fuel currently");
                if(cr1.fuelAmount == 0)
                {
                    Console.WriteLine("The Vehicle won't move, because of the low fuel amount"); goto Continue;
                }
            }
            Console.Write("How much distance do yo want to go? : ");
            int km = Convert.ToInt32(Console.ReadLine());
            cr1.Go(km);
            Console.WriteLine("In order to stop the program, turn off the engine by pressing 'Enter' button again, otherwise press any button to continue.");
            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
            if (keyInfo2.Key == ConsoleKey.Enter)
            {
                Console.Write("The engine has been stopped!");
                cr1.TurnOff();
            }
            else goto Continue;
            Console.ReadLine();
        }
    }
}
