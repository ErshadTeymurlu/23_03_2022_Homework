using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23_03_2022_Facebook.Models
{
    internal class User
    {
        public string Name;
        public string Surname;
        public string Email;
        public string Password;
        public string DateOfBirth;
        public string PhoneNumber;
        public bool IsSingle;
        public List<Post> posts;
        public User()
        {
            Name = "Guest";
            Surname = null;
            DateOfBirth = null;
            PhoneNumber = null;
            Email = null;
            Password = null;
        }
        public User(string name, string surname, string dateOfBirth, string phoneNumber, string email, string password)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
        }
        public User(string email, string password)
        {
            if (Email == email && Password == password) Console.WriteLine($"Welcome, {Name}!");
            else Console.WriteLine("Email or password is not current");
        }
    }
}
