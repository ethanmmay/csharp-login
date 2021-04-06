using LoginSystem.Models;
using System.Collections.Generic;
using System;

namespace LoginSystem
{
    public class Authenticator
    {

        public Authenticator()
        {
            User tim = new User("Timbo", "Timbosl!ce");
            Signup(tim);
        }
        public Dictionary<string, User> Users { get; set; } = new Dictionary<string, User>();
        public void Login()
        {
            Console.Write("Please enter login info. \nUsername: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine($"U: {username} P: {password}");
            if (Users.ContainsKey(username.ToLower()) && Users[username.ToLower()].ValidatePassword(password))
            {
                Console.WriteLine("Welcome " + username);
            }
            else
            {
                Console.WriteLine("Unauthorized");
            }
        }

        public void Signup(User newUser)
        {
            Users.Add(newUser.Name.ToLower(), newUser);
        }
    }
}