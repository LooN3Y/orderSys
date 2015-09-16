using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderSystem
{
    class User
    {
        private string _username, _password;

        public string username
        {
            get { return this._username; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Username should not be empty!");
                else
                    this._username = value;
            }
        }
        public string password
        {
            get { return this._password; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Password should not be empty!");
                else
                    this._password = value;
            }
        }
        
        /*
         * Constructor.
         * Input: username, password (strings)
         */
        public User(string uName, string uPass)
        {
            this._username = uName;
            this._password = uPass;
        }
    }
}
