using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            string dataFile = "credentials.Evoker";

            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            user input = new user(username, password);

            user fromFile = new user(dataFile);

            login login = new login(input, fromFile);

            if (login.check(input, fromFile))
                Console.Write("Welcome!");
            else
                Console.WriteLine("GTFO!");

            Console.ReadLine();
        }
        
    }
}
