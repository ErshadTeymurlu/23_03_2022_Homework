using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _23_03_2022_Facebook.Models;

namespace _23_03_2022_Facebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------SIGN UP------");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surnname = Console.ReadLine();
            Console.Write("Date Of Birth: ");
            string dateOfBirth = Console.ReadLine();
            Console.Write("Phone Number: ");
            string PhoneNumber = Console.ReadLine();
            Console.Write("Email Address: ");
            string Email = Console.ReadLine();
            Console.Write("Password: ");
            string Password = Console.ReadLine();
            User us1 = new User(name, surnname, dateOfBirth, PhoneNumber, Email, Password);
           Continue: Console.WriteLine("------LOGIN------");
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            if (email == us1.Email && password== us1.Email) Console.WriteLine("Welcome!");
            if (email != us1.Email && password != us1.Email)
            {
                Console.WriteLine("ERROR: Email or password is not correct, try again!\n"); goto Continue;

            }
            int PostCount = 0;
            string text = "";
            while (true)
            {
                Console.WriteLine("Do you want to share what you think: ");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "Yes" || yesOrNo == "yes")
                {
                    Console.Write("Text : ");
                    text = Console.ReadLine();
                    us1.posts.Add(new Post());
                    us1.posts[PostCount].Text = text;
                    PostCount++;
                }
                else if (yesOrNo == "Cancel" || yesOrNo == "cancel") break;
            }

            Console.ReadLine();
        }
    }
}
