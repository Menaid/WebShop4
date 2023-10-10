namespace WebShop4;

public class register
{
    string UserName;
    string PassWord;
    public register(string username, string password)
    {
        UserName = username;
        PassWord = password;
    }

    public static void Login()
    {
        Console.WriteLine("Ange ditt användarnamn: ");
        string Usname = Console.ReadLine();
        Console.WriteLine("Ange ditt Lösenord: ");
        string Paword = Console.ReadLine();
        string[] lines = File.ReadAllLines(@"../../../customers.txt");
        List<string> newwords = new List<string>();
        foreach (var item in lines)
        {
            newwords = new List<string>(item.Split("-"));
            if (Usname == newwords[0] && Paword == newwords[1])
            {
                Console.WriteLine("Välkommen tillbaka!");
                break;
            }
        }
        if (Usname != newwords[0] || Paword != newwords[1])
        {
            Console.WriteLine("Fel, försök igen.");
        }
    }
    public static void reg()
    {
        Console.WriteLine("Vänligen ange ett användarnamn: ");
        string Uname = Console.ReadLine();
        Console.WriteLine("Vänligen ange ett lösenord: ");
        string Pword = Console.ReadLine();

        customer custom = new customer(username: Uname, password: Pword);

        string UP = Uname + "-" + Pword;

        string loca = @"../../../customers.txt";
        File.AppendAllText(loca, UP + Environment.NewLine);
    }
}