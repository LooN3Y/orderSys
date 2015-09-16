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

            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            User userInfo = new User(username, password);

            Authenticator authorize = new Authenticator(userInfo);
            Login toLogin = new Login(authorize.Check(), userInfo);

            Console.WriteLine(toLogin.LoginTask());

            Console.ReadLine();
        }
        
    }
}
