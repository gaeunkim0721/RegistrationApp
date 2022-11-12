using SQLite;

namespace RegistrationApp.Model
{
    public class User
    {
        public int UserId { get; set; }
        private string username = "";
        public string Username { get { return username; } set { username = value; } }
        private string name = "";
        public string Name { get { return name; } set { name = value; } }
        private string lastname = "";
        public string Lastname { get { return lastname; } set { lastname = value; } }
        private string password = "";
        public string Password { get { return password; } set { password = value; } }
        private string confirmPassword = "";
        public string ConfirmPassword { get { return confirmPassword; } set { confirmPassword = value; } }
    }
}
