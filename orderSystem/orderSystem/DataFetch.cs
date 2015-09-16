using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderSystem
{
    /*
     * Public class. Fetches an user object after reading username/password from a file. 
     * 
     */
    class DataFetch
    {
        private static string _dataFilePath;

        static DataFetch()
        {
            _dataFilePath = "credentials.Evoker";
        }

        public static User Fetch()
        {
            User usr = new User("", "");
            StreamReader sr = null;

            //if (File.Exists(_dataFilePath))
            try
            {
                string line;
                sr = new StreamReader(_dataFilePath);

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(':');
                    if (data[0].Contains("username"))
                        usr.username = data[1];
                    else if (data[0].Contains("password"))
                        usr.password = data[1];
                }
            }
            //else
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }

            return usr;
        }
    }
}
