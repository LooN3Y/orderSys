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
            string userName, userPass, line;
            string uName = "";
            string uPass = "";

            Console.Write("Name: ");
            userName = Console.ReadLine();

            Console.Write("Password: ");
            userPass = Console.ReadLine();
            
            string filePath = "credentials.Evoker";
            // File check
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
            }
            // File is there
            else
            {
                StreamReader file = new StreamReader(filePath);
                while ((line = file.ReadLine()) != null)
                {
                    // If its a "valid" line
                    if (line.IndexOf(":") != -1)
                    {
                        int dataLen = line.Length - line.IndexOf(":") - 1;
                        int dataStart = line.IndexOf(":") + 1;

                        if (line.Contains("username"))
                        {
                            uName = line.Substring(dataStart, dataLen);
                            // Console.WriteLine("Username: " + uName);
                        }
                        else if (line.Contains("password"))
                        {
                            uPass = line.Substring(dataStart, dataLen);
                            // Console.WriteLine("Password: " + uPass);
                        }
                    }
                }
                // ======= CHECKS
                if (Equals(userName, uName) && Equals(userPass, uPass))
                    Console.WriteLine("\nLogin Success!");
                else
                    Console.WriteLine("\nGTFO!");

            }
            Console.ReadLine();
        }
    }
}
