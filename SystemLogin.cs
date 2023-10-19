using System;
using WebShop4;

public class SystemLogin
{
    private const string FileUName = "../../../users.csv";
    private const string FileAName = "../../../admins.csv";

    public static void startLogin()
    {
<<<<<<< HEAD
        
            Console.WriteLine("VÄLKOMMEN TILL VÅR SHOP\n");
            Console.WriteLine("1. Admin login");
            Console.WriteLine("2. Kund login");
            Console.WriteLine("3. Registrera dig som ny kund");
            Console.WriteLine("4. Exit");
=======
>>>>>>> login

        Console.WriteLine("VÄLKOMMEN TILL VÅR SHOP\n");
        Console.WriteLine("1. Admin login");
        Console.WriteLine("2. Kund login");
        Console.WriteLine("3. Registrera dig som ny kund");
        Console.WriteLine("4. Exit");

        int userChoice;

        while (true)
        {
            Console.Write("\nVälja Alternativ: ");
            if (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 4)
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
                Customer.SignUp();
                break;
            case 4:
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

        User adminLogin = new User { Username = username, Password = password };
        if (AdminExists(adminLogin.Username))
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nVälkommen " + adminLogin.Username);
            Console.WriteLine("____________________________________");
            return;
        }
        else
        {
            int timer = 2000;
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("\nAdminnamn eller lösenord fel. Testa igen.\n");
            Console.WriteLine("_____________________________________________");
            Thread.Sleep(timer);
            Console.Clear();
            startLogin();
        }
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

    public static void userPage()
    {
        Console.Clear();
        Console.Write("\nAnge användarnamn: ");
        string username = Console.ReadLine();
        Console.Write("Ange lösenord: ");
        string password = Console.ReadLine();

        User userLogin = new User { Username = username, Password = password };
        if (UserExists(userLogin.Username))
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nVälkommen " + userLogin.Username);
            Console.WriteLine("____________________________________");

            return;
        }
        else
        {
            int timer = 2000;
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("\användarnamn eller lösenord fel. Testa igen.\n");
            Console.WriteLine("_______________________________________________");
            Thread.Sleep(timer);
            Console.Clear();
            startLogin();
        }

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
