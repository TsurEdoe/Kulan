using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class DB_Handler
    {
        private List<User> _users;
        private List<Event> _events;

        public DB_Handler() 
        { 
            refresh();
        }

        public List<Event> getEventResults(string searchPar);
        public List<User> getUserResults(string searchPar);

        private void refresh() {}

        private User getUser(string username)
        {
            return null;

        }

        private Event getEvent(string eventname)
        {
            return null;
        }
        private Event getEvent(int id)
        {
            return null;
        }

        private void addEvent(Event eventToAdd) { }
        private void addUser(User UserToAdd) { }



    }
}
