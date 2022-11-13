using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.Model
{
    public class Database : HasId
    {
        //private int id;
        //public int Id { get { return id; } set { id = value; } }
        private string userId;
    
        public string UserId { get { return userId; } set { userId = value; } }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private string date = "";
        public string Date
        {
            get { return date; }
            set { date = value; }

        }

        public string Id { get;
            set; }
    }
}
