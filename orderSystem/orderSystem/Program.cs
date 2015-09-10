using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, pass;

            Console.Write("Name: ");
            userName = Console.ReadLine();

            Console.Write("Password: ");
            pass = Console.ReadLine();

            Console.WriteLine("Name: "+userName+", Pass: "+pass+".");

            string[] user = new string[2];
            user = Credentials.Get();

            if ( Equals(userName, user[0]) && Equals(pass, user[1] ) )
            {
                Console.WriteLine("You are in!");
            }
            else 
            {
                Console.WriteLine("No way!");
            }    
            

            Console.ReadLine();
        }
    }
}
