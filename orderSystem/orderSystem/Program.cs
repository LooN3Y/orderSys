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
            string uName, uPass;

            Console.Write("Name: ");
            userName = Console.ReadLine();

            Console.Write("Password: ");
            userPass = Console.ReadLine();

            Console.WriteLine("Name: " + userName + ", Pass: " + userPass + ".");

            string filePath = "credentials.Evoker";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
            }
            else
            {
                StreamReader file = new StreamReader(filePath);
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    if (line.IndexOf(":") != -1)
                    {
                        int labelLen = line.IndexOf(":") - 1;
                        int dataLen = line.Length - line.IndexOf(":") - 1;


                        if (line.Contains("username"))
                        {
                            // uName = ...
                            // check userName / uName
                        }
                        else if (line.Contains("password"))
                        {
                            // uPass = ...
                            // check userPass / uPass
                        }

                        // just for testin
                        Console.WriteLine("Label: " + labelLen + ", Data: " + dataLen + ", break@ " + line.IndexOf(":") + " whole: " + line.Length);

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
