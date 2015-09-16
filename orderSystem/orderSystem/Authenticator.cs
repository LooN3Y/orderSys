using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderSystem
{
    /*
     * Takes an "user" object as input and compares it with the one that reads from the file.
     * 
     */
    class Authenticator
    {
        
        private User _inputUser;

        public Authenticator(User usr)
        {
            this._inputUser = usr;
        }
        
        
        public bool Check()
        {
            User dataUser = DataFetch.Fetch();
            if (_inputUser.username == dataUser.username && _inputUser.password == dataUser.password)
                return true;
            else
                return false;
        }
    }
}
