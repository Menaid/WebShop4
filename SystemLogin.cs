using System;
using WebShop4;

public class SystemLogin
{
    private const string FileUName = "../../../customer.csv";
    private const string FileAName = "../../../admins.csv";

    public static void startLogin()
    {
        Console.WriteLine("VÄLKOMMEN TILL VÅR SHOP\n");
        Console.WriteLine("1. Admin login");
        Console.WriteLine("2. Kund login");
        Console.WriteLine("3. Registrera dig som ny kund");
        Console.WriteLine("4. Exit");

        int userChoice;

        while (true)
        {
            Console.Write("\nVälj alternativ: ");
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
                Console.Beep(500, 500);
                adminPage();
                break;
            case 2:
                Console.Beep(500, 500);
                userPage();
                break;
            case 3:
                Console.Beep(500, 500);
                Console.Clear();
                Customer.Register();
                break;
            case 4:
                Console.Beep(500, 500);
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
        if (AdminExists(adminLogin.Username) && AdminExists(adminLogin.Password))
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nVälkommen " + adminLogin.Username);
            Console.WriteLine("____________________________________");
            AdminMenu.Menu();
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
        Console.WriteLine("----------------");
        Console.Write("Ange användarnamn: ");
        Console.WriteLine("\n----------------");
        string username = Console.ReadLine();
        Console.WriteLine("----------------");
        Console.Write("Ange lösenord: ");
        Console.WriteLine("\n----------------");
        string password = Console.ReadLine();
        Console.WriteLine("----------------");

        User userLogin = new User { Username = username, Password = password };
        if (UserExists(userLogin.Username))
        {
            Console.Clear();
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nVälkommen " + userLogin.Username);
            Console.WriteLine("____________________________________");

            Console.WriteLine("För att gå tillbaka ange: 1");
            var input = Console.ReadLine();
           // Console.WriteLine("Din kundvagn innehåller för tillfället: " + );
            switch (input)
            {
                case "1":
                    Console.Clear();
                    startLogin();
                    break;
            }
        }
        else
        {
            int timer = 2000;
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("\aAnvändarnamn eller lösenord fel. Testa igen.\n");
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
                if (parts.Length == 3 && parts[0] == username.ToLower())
                {
                    return true;
                }
            }
        }

        return false;
    }
}
