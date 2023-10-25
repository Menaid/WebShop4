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
            if (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 5)
            {
                Console.WriteLine("Ogiltigt val. Var god försök igen.");
            }
            else
            {
                break;
            }
        }

        switch (userChoice)
        {
            case 1:
                //Console.Beep(500, 500);
                adminPage();
                break;
            case 2:
                //Console.Beep(500, 500);
                userPage();
                break;
            case 3:
                //Console.Beep(500, 500);
                Console.Clear();
                Customer.Register();
                break;
            case 4:
                //Console.Beep(500, 500);
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

<<<<<<< HEAD
        User adminLogin = new User(username, password);
        if (AdminExists(adminLogin))
=======
        User adminLogin = new User { Username = username, Password = password };
        if (AdminExists(adminLogin.Username, adminLogin.Password))
>>>>>>> d98be2c912347f5ee45b68f30c2df1e6248eaea2
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nVälkommen " + adminLogin.Username);
            Console.WriteLine("____________________________________");
            AdminMenu.Menu();
        }
        else
        {
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("\nAdminnamn eller lösenord fel. Testa igen.\n");
            Console.WriteLine("_____________________________________________");
            Console.Clear();
            startLogin();
        }
    }

<<<<<<< HEAD
    private static bool AdminExists(User admin)
=======
    private static bool AdminExists(string username, string password)
>>>>>>> d98be2c912347f5ee45b68f30c2df1e6248eaea2
    {
        if (File.Exists(FileAName))
        {
            string[] lines = File.ReadAllLines(FileAName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
<<<<<<< HEAD
                if (parts.Length == 2 && parts[0] == admin.Username && parts[1] == admin.Password)
=======
                if (parts.Length == 2 && parts[0] == username.ToLower() && parts[1] == password)
>>>>>>> d98be2c912347f5ee45b68f30c2df1e6248eaea2
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static string SignedInUser = null;

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

<<<<<<< HEAD
        User userLogin = new User (username, password);
        if (UserExists(userLogin))
=======
        User userLogin = new User { Username = username, Password = password };
        if (UserExists(userLogin.Username, userLogin.Password))
>>>>>>> d98be2c912347f5ee45b68f30c2df1e6248eaea2
        {
            SignedInUser = userLogin.Username;
            Console.Clear();
            Console.WriteLine("____________________________________");
            Console.WriteLine("\nVälkommen " + userLogin.Username);
            Console.WriteLine("____________________________________");
            AddProduct.productMenu();
        }
        else
        {
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("\aAnvändarnamn eller lösenord fel. Testa igen.\n");
            Console.WriteLine("_______________________________________________");
            Console.Clear();
            startLogin();
        }
    }

<<<<<<< HEAD
    private static bool UserExists(User userLogin)
=======
    private static bool UserExists(string username, string password)
>>>>>>> d98be2c912347f5ee45b68f30c2df1e6248eaea2
    {
        if (File.Exists(FileUName))
        {
            string[] lines = File.ReadAllLines(FileUName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
<<<<<<< HEAD
                if (parts.Length == 3 && parts[0] == userLogin.Username && parts[1] == userLogin.Password)
=======
                if (parts.Length == 3 && parts[0] == username.ToLower() && parts[1] == password)
>>>>>>> d98be2c912347f5ee45b68f30c2df1e6248eaea2
                {
                    return true;
                }
            }
        }

        return false;
    }
}