using WebShop4;

Console.WriteLine("Hello, World!");
ForAdmin.CustomerInfo();

void LogIn()
{
    Console.WriteLine("Skriv användarnamn: ");
    string Usname = Console.ReadLine();
    Console.WriteLine("Skriv Lösenord: ");
    string Paword = Console.ReadLine();
    string[] lines = File.ReadAllLines(@"../../../admins.txt");
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
LogIn();