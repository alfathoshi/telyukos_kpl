
public class Account
{
    public int ID {  get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string role { get; set; }

    public Account(int id, string username, string password, string role)
    {
        this.ID = id;
        this.username = username;
        this.password = password;
        this.role = role;
    }
}

