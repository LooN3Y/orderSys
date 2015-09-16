using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderSystem
{
    /*
     * Class that after user authentication, performs the login task
     */
    class Login
    {
        private bool _authSuccess;
        private User _inputUser;

        public Login(bool status, User usr)
        {
            this._authSuccess = status;
            this._inputUser = usr;
        }

        /*
         * Logs succesfull login attempt in log file
         */
        public string LoginTask()
        {
            if (this._authSuccess)
            {
                string line = "\n> User: " + _inputUser.username + " logged in at: " + DateTime.Now + Environment.NewLine;
                // Log method call:
                Logger.Log(line);
                return "\n> Welcome!";
            }
            else
            {
                string line = "\n> User: " + _inputUser.username + " tried to login at: " + DateTime.Now + Environment.NewLine;
                // Log method call:
                Logger.Log(line, "falseLogins.txt");
                return "\n> Try again...";
            }
        }
    }
}