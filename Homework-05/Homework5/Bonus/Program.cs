using System;
using Bonus.Domain;
using Bonus.Services;
using System.Collections.Generic;

namespace Bonus
{
    class Program
    {
        static TheService theService = new TheService();
        static List<User> users = new List<User>()
        {
            new User(){FirstName="First name",LastName="Last name",Age=45},
            new User(){FirstName="name123",LastName="lastname123",Age=12},
        };
        static void Main(string[] args)
        {

            foreach (var user in users)
            {
               theService.Log(user);
            }

            Console.WriteLine("We are done! :)");

            Console.ReadLine();

        }

    }
}
