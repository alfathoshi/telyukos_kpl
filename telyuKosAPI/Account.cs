namespace API
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public Account(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
    }
}
