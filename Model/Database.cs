using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.Model
{
    public class Database
    {
        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id { get { return id; } set { id = value; } }
        private int userId;
        [Indexed]
        public int UserId { get { return userId; } set { userId = value; } }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

    }
}
