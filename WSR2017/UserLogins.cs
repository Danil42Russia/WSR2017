namespace WSR2017
{
    public class UserLogins
    {
        public string Login {get { return login; } set { login = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int Role { get { return role; } set { role = value; } }

        private static string login = "";
        private static string password = "";
        private static int role = 0;
    }
}