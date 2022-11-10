using SQLite;

namespace RegistrationApp.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        private string name="";
        [MaxLength(50)]
        public string Name { get { return name; } set { name = value; } }
        private string password = "";
        [MaxLength(50)]
        public string Password { get { return password; } set { password = value; } }
    }
}
