using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderSystem
{
    public static class Credentials
    {
        public static string[] Get()
        {
            return new string[] { "admin", "password" };
        }
    }
}
