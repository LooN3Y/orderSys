using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderSystem
{
    class user
    {
        private string username, password, line;

        // Constructor that takes a filepath and sets the username/password accordingly
        public user(string dataFilePath)
        {
            // Check for file
            if (File.Exists(dataFilePath))
            {
                StreamReader sr = new StreamReader(dataFilePath);
                while ( (line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(':');
                    if (data[0].Contains("username"))
                        username = data[1];
                    else if (data[0].Contains("password"))
                        password = data[1];
                }
            }
            
        }

        // Constructor that takes username/password as input
        public user(string name, string pass)
        {
            this.username = name;
            this.password = pass;
        }

        public string getuName()
        {
            return username;
        }
        public string getuPass()
        {
            return password;
        }
    }
}
