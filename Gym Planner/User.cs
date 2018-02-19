using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Planner
{
    public class User
    {
        private string name;
        private string pass;

        User()
        {
            name = "default";
            pass = "default";
        }
        public string Login
        {
            get
            {
                return name;
            }
        }

        public User(string name, string pass)
        {
            this.name = name;
            this.pass = pass;
        }
        public bool isAdmin()
        {
            return ((this.name == "admin") && (this.pass == "admin"));
        }

    }
}
