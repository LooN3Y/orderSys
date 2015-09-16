using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderSystem
{
    /*
     * Logs the succesfull login attempt to a txt file.
     */
    class Logger
    {
        private static string _logFilePath;

        static Logger()
        {
            _logFilePath = "log.txt";
        }
        
        public static void Log(string logLine)
        {
            try
            {
                File.AppendAllText(_logFilePath, logLine);
            }
            catch (Exception e) // General exception handler
            {
                Console.WriteLine(e.Message + "\n");
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Log(string logline, string filePath)
        {
            try
            {
                File.AppendAllText(filePath, logline);
            }
            catch (Exception e) // General exception handler
            {
                Console.WriteLine(e.Message + "\n");
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
