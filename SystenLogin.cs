public class SystemLogin
{
    private const string FileUName = "../../../users.txt";
    private const string FileAName = "../../../admins.txt";

    public static void startLogin()
    {
        
            Console.WriteLine("VÄLKOMMEN TILL VÅR SHOP\n");
            Console.WriteLine("1. Admin login");
            Console.WriteLine("2. Kund login");
            Console.WriteLine("3. Exit");

            int userChoice;

        while (true)
        {
            Console.Write("\nVälja Alternativ: ");
            if (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 3)
            {
                Console.WriteLine("\nOgiltigt val. Var god försök igen.\n");
                continue;
            }
            break;
        }

        switch (userChoice)
        {
            case 1:
                SystemLogin.adminPage();
                break;
            case 2:
                SystemLogin.userPage();
                break;
            case 3:
                Console.WriteLine("Hej då!");
                Environment.Exit(0);
                break;
        }
       
    }

    public static void adminPage()
    {
        Console.Clear();
        Console.Write("\nAnge adminnamn: ");
        string username = Console.ReadLine();
        Console.Write("Ange lösenord: ");
        string password = Console.ReadLine();
        Console.Clear();

        User newUser = new User { Username = username, Password = password };
        CreateAdmin(newUser);
    }

    public static void userPage()
    {
        Console.Clear();
        Console.Write("\nAnge användarnamn: ");
        string username = Console.ReadLine();
        Console.Write("Ange lösenord: ");
        string password = Console.ReadLine();

        User newUser = new User { Username = username, Password = password };
        CreateUser(newUser);
    }

    public static void CreateAdmin(User user)
    {
        if (AdminExists(user.Username))
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nAdminnamn finns redan. Testa igen.\n");
            Console.WriteLine("____________________________________");
            return;
        }

        using (StreamWriter writer = File.AppendText(FileAName))
        {
            string line = $"{user.Username}-{user.Password}";
            writer.WriteLine(line);
        }

        Console.Clear();
        Console.WriteLine("__________________________");
        Console.WriteLine("\nVälkommen "+ user.Username);
        Console.WriteLine("__________________________");
    }

    private static bool AdminExists(string username)
    {
        if (File.Exists(FileUName))
        {
            string[] lines = File.ReadAllLines(FileAName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('-');
                if (parts.Length == 2 && parts[0] == username.ToLower())
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static void CreateUser(User user)
    {
        if (UserExists(user.Username))
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("användarnamn finns redan.");
            Console.WriteLine("____________________________________");

            return;
        }

        using (StreamWriter writer = File.AppendText(FileUName))
        {
            string line = $"{user.Username}-{user.Password}";
            writer.WriteLine(line);
        }

        Console.Clear();
        Console.WriteLine("__________________________");
        Console.WriteLine("\nVälkommen " + user.Username);
        Console.WriteLine("__________________________");

    }

    private static bool UserExists(string username)
    {
        if (File.Exists(FileUName))
        {
            string[] lines = File.ReadAllLines(FileUName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('-');
                if (parts.Length == 2 && parts[0] == username.ToLower())
                {
                    return true;
                }
            }
        }

        return false;
    }
}
