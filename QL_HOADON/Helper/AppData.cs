public class AppData
{
    public static User? user;
}
public class User
{
    public string username;
    public string name;
    public string password;
    public string perrmission;
    public User(string username, string name, string password, string perrmission)
    {
        this.username = username;
        this.name = name;
        this.password = password;
        this.perrmission = perrmission;
    }
    public bool IsAdmin()
    {
        return this.perrmission == "ADMIN";
    }
}