namespace WebShop4;

public static void SignUp()
{
    Console.WriteLine("Registrera dig som ny kund");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Ange ditt namn: ");
    string name = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Ange önskat lösenord: ");
    string pw = Console.ReadLine();
    Console.WriteLine("Bekräfta lösenordet: ");
    string pw1 = Console.ReadLine();

    while (pw != pw1)
    {
        Console.WriteLine("Du angav inte samma lösenord, försök igen");
    }
    if (pw == pw1)
    {
        Console.WriteLine("Grattis, du är nu en registrerad kund!");
    }


}