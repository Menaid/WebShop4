namespace WebShop4;

public class SignUp
{
    public static void Register()
    {
        string[] customer = File.ReadAllLines("../../../customer.csv");
        Console.WriteLine("Registrera dig som ny kund");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Ange ditt namn: ");
        string name = Console.ReadLine();


        List<string> split = new List<string>();
        foreach (var item in customer)
        {
            split = new List<string>(item.Split(","));
            if (name == split[0])
            {
                Console.WriteLine("Det finns redan en användare med namnet " + name + " vänligen välj ett annat.");
                Register();
            }
        }

        string pw = "";
        string pw1 = "";
        while (pw != pw1 || string.IsNullOrWhiteSpace(pw))
        {
            Console.WriteLine("Ange önskat lösenord: ");
            pw = Console.ReadLine();
            Console.WriteLine("Bekräfta lösenordet: ");
            pw1 = Console.ReadLine();
            Console.WriteLine("Du angav inte samma lösenord eller så lämnade du fältet tomt, försök igen");
        }

        if (pw == pw1)
        {
            Console.Clear();
            Console.WriteLine(
                "Grattis, du är nu en registrerad kund!\nVänligen logga in för att få tillgång till ditt nya konto!\n");
        }

        //lägger till alla som registrerar sig i customer.csv
        string newCustomer = $"{name},{pw},{GenerateUniqueId()}";
        string path = "../../../customer.csv";
        File.AppendAllText(path, newCustomer + "\n");

        //skapar en ny .csv fil för var person som registrerar sig
        string cartName = $"Cart.{name}";
        string pathCart = $"../../../Carts/{cartName}.csv";
        string newCart = name + "," + pw + "," + GenerateUniqueId();
        File.WriteAllText(pathCart, newCart);


        SystemLogin.startLogin();

        static int GenerateUniqueId()
        {
            return Guid.NewGuid().GetHashCode();
        }
    }
}