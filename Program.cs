using WebShop4;


Console.WriteLine("Do you want to register or log in?:");
Console.Write("| L = Login | R = Register | ");
Console.WriteLine(" ");
string A = Console.ReadLine();

switch (A.ToString().ToLower())
{
    case "l":
        LogIn();
        break;
    case "r":
        Register();
        break;
}
void Register()
{
    Console.WriteLine("Skriv användarnamn: ");
    string Uname = Console.ReadLine();
    Console.WriteLine("Skriv Lösenord: ");
    string Pword = Console.ReadLine();

    customer custom = new customer(username: Uname, password: Pword);

    string UP = Uname + "-" + Pword;

    string loca = @"../../../customers.txt";
    File.AppendAllText(loca, UP + Environment.NewLine);
}

void LogIn()
{
    Console.WriteLine("Skriv användarnamn: ");
    string Usname = Console.ReadLine();
    Console.WriteLine("Skriv Lösenord: ");
    string Paword = Console.ReadLine();
    string[] lines = File.ReadAllLines(@"../../../customers.txt");
    List<string> newwords = new List<string>();
    foreach (var item in lines)
    {
        newwords = new List<string>(item.Split("-"));
        if (Usname == newwords[0] && Paword == newwords[1])
        {
            Console.WriteLine("Correct");
            break;
        }
    }
    if (Usname != newwords[0] || Paword != newwords[1])
    {
        Console.WriteLine("Not Correct");
    }
}

Console.WriteLine("Hello, World!");
ForAdmin.CustomerInfo();

