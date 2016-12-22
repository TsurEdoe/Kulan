using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class User
    {
        private String _username;
        private String _password;
        private List<User> _friends;
        private Dictionary<Event,bool> _events; //the bool value represents 'going'=true or 'not going'=false
        
        public User(string username,string pass)
        {

        }
    }
}
