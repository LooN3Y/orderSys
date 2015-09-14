using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderSystem
{
    class login
    {
        // Log file path
        private static string logFilePath = "log.txt";
        private bool loggedIn = false;
        private bool logit = false;

        /*
         * Main Constructor
         * Input:
         *      inputData = user object containing user's inputed username password
         *      fileData = username/password to authenticate with (read from file in this solution)
         */
        public login(user inputData, user fileData)
        {
            // Authenticate
            if (loggedIn = check(inputData, fileData))
            {
                // Log the user login 
                logit = log(inputData);
            }
        }

        /*
         * Method that log's the succesfull login info into a file
         * Retrns true if succesfull
         */
        public bool log(user user)
        {
            // Text line to log:
            string logLine = "User: " + user.getuName() + " (" + user.getuPass() + "), logged in at: " + DateTime.Now + Environment.NewLine;

            if (!File.Exists(logFilePath)) // Q = Why include system.IO ???
            {
                File.WriteAllText(logFilePath, logLine);
                return true;
            }
            else if (File.Exists(logFilePath))
            {
                File.AppendAllText(logFilePath, logLine);
                return true;
            }
            // Log to file attempth FAILED
            return false;
        }

        /*
         * Method that returns true if user is Valid 
         */
        public bool check(user inputData, user fileData)
        {
            if (String.Equals(inputData.getuName(),fileData.getuName()) && String.Equals(inputData.getuPass(),fileData.getuPass()) )
                return true;
            return false;
        }

        public bool getLoginStatus()
        {
            return this.loggedIn;
        }
        public bool getLogStatus()
        {
            return this.logit;
        }
    }
}