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
            Car car1 = new Car("BMW","M4 COMPETITION","2021");
            car1.GetInfo();
            Console.Write("do yo wanna turn on the engine ? if yes press enter, otherwise press U...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if(keyInfo.Key == ConsoleKey.Enter)
            {
                car1.TurnOn();
                Console.WriteLine("The engine has been started.");
                car1.Go(100);
            }
            if (keyInfo.Key == ConsoleKey.E) Console.Write("The geer is in parkin mode.");
                Console.ReadLine();
        }
    }
}
