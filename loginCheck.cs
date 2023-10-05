namespace Webshop4;

public class CheckLogin
{
    public static void Main()
    {
        // Skapar en temporär lista på anv.n och lösen i.o.m programmet inte än läser in någon textfil
        List<User> User = new List<User>();
        {
            new User("user1", "password1");
        }

        // Frågar efter anv.n och lösen
        Console.WriteLine("Username: ");
        string UsernameEntered = Console.ReadLine();
        Console.WriteLine("Username: ");
        string PasswordEntered = Console.ReadLine();

        // kollar ifall anv och lösen finns i temporär lista
        bool isCorrcet = false;
        foreach (User user in User)
        {
            if (user.Username == UsernameEntered && user.Password == PasswordEntered)
            {
                isCorrcet = true;
                break;
            }
        }

        // Ifall uppgifter stämmer skriver programmet "welcome", annars skriver det "wrong username or password"
        if (isCorrcet)
        {
            Console.WriteLine("Welcome!");

        }
        else 
        {
            Console.WriteLine("Wrong username or password");
        }
    }
}

class User
{
    public string Username { get; }
    public string Password { get; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
