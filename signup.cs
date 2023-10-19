using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace WebShop4;
public class Customer
{
    public string UserName { get; set; }
    public string UserPw { get; set; }
    public string Cart { get; set; }
    public int UserId { get; set; }
    
    public Customer(string userName, string userPw, string userCart, int userId)
    {
        UserName = userName;
        UserPw = userPw;
        Cart = userCart;
        UserId = userId;
    }


    public static void SignUp()
    {
        string[] customer = File.ReadAllLines("../../../customer.csv");
        Console.WriteLine("Registrera dig som ny kund");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Ange ditt namn: ");
        string name = Console.ReadLine();
        Console.Clear();

        List<string> split = new List<string>();
        foreach (var item in customer)
        {
            split = new List<string>(item.Split("-"));
            if (name == split[0])
            {
                Console.WriteLine("Det finns redan en användare med namnet " + name + " vänligen välj ett annat.");
                SignUp();
            }
        }


        string pw = ""; string pw1 = "";
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
            Console.WriteLine("Grattis, du är nu en registrerad kund!");
            // GÅ TILL USER MENY
        }


<<<<<<< HEAD
        //lägger till alla som registrerar sig i customer.csv
        string newCustomer = string.Format("{0} - {1} - {2}", name, pw, GenerateUniqueId());
=======
        string newCustomer = name + "-" + pw + GenerateUniqueId();
>>>>>>> 45e4ef8bf6c01ef91d7db8216e24ae0fa6ea2111
        string path = "../../../customer.csv";
        File.AppendAllText(path, newCustomer + Environment.NewLine);


        //skapar en ny .csv fil för var person som registrerar sig
        string cartName = $"Cart + {name}";
        string pathCart = $"../../../{cartName}.csv";
        string newCart = string.Format("{0} - {1} - {2}", name, pw, GenerateUniqueId());
        File.WriteAllText(pathCart, newCart);


        Customer Costumer = new Customer(userName: name, userPw: pw, userCart: newCart, userId: GenerateUniqueId());


        static int GenerateUniqueId()
        {
            return Guid.NewGuid().GetHashCode();
        }
    }
}