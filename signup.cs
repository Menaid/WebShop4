namespace WebShop4;
public class Customer
{
    public string UserName { get; set; }
    public string UserPw { get; set; }
    public int UserId { get; set; }

    public Customer(string userName, string userPw, int userId)
    {
        UserName = userName;
        UserPw = userPw;
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

        if (customer.Contains(name))
        {
            Console.WriteLine("Det finns redan en användare med namnet " + name + " vänligen välj ett annat.");  // varför kollar den inte namnet i customer?
            SignUp();
        }

        Console.WriteLine("Ange önskat lösenord: ");
        string pw = Console.ReadLine();
        Console.WriteLine("Bekräfta lösenordet: ");
        string pw1 = Console.ReadLine();

        while (pw != pw1 || string.IsNullOrWhiteSpace(pw))  // ska återgå och låta användaren skriva in igen
        {
            Console.WriteLine("Du angav inte samma lösenord eller så lämnade du fältet tomt, försök igen");
        }
        if (pw == pw1)
        {
            Console.Clear();
            Console.WriteLine("Grattis, du är nu en registrerad kund!");
        }

        Customer Costumer = new Customer(userName: name, userPw: pw, userId: GenerateUniqueId());

        string newCustomer = name + " - " + pw + " - " + GenerateUniqueId();
        string path = "../../../customer.csv";
        File.AppendAllText(path, newCustomer + Environment.NewLine);


        static int GenerateUniqueId()
        {
            return Guid.NewGuid().GetHashCode();
        }
    }
}




/*
// Läser innehållet i filen
string fileContent = File.ReadAllText(filePath);

// Kontrollerar om filen är tom
if (string.IsNullOrEmpty(fileContent))
{
    // Tar bort filen om den är tom
    File.Delete(filePath);
*/