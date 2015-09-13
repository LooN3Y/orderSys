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
            string uPass = ""; // Q

            Console.Write("Name: ");
            userName = Console.ReadLine();

            Console.Write("Password: ");
            userPass = Console.ReadLine();

            string filePath = "credentials.Evoker";
            // File check
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File (" + filePath + ") not found.");
                Console.ReadLine();
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
                {
                    // Log succesfull login
                    Console.WriteLine("\n > Succesfull Login!");
                    if (log(uName, uPass))
                        Console.WriteLine("[Login attempt logged]");
                    else
                        Console.WriteLine("[Login attempt not logged]");
                }
                else
                    Console.WriteLine("\nGTFO!");

            }
            Console.ReadLine();
        }

        // Login loging function ==============================
        public static bool log(string username, string password)
        {
            string logFilePath = "loginLog.txt";
            string line = "User: " + username + " (password: " + password + "), when: " + DateTime.Now + Environment.NewLine;

            // First log attempt
            if (!File.Exists(logFilePath))
            {
                Console.WriteLine("Log file (" + logFilePath + ") created.");
                File.WriteAllText(logFilePath, line);
                Console.WriteLine(line);
                return true;
            }
            else if (File.Exists(logFilePath)) // Log file found
            {
                File.AppendAllText(logFilePath, line);
                Console.WriteLine(line);
                return true;
            }
            else // Could not create file ???????????????????? Q
                return false;
        }

    }
}
