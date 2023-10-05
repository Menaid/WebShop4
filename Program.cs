using WebShop4;

Console.WriteLine("Do you want to register or log in?:");
Console.Write("| L = Login | R = Register | ");
Console.WriteLine(" ");
string A = Console.ReadLine();

switch (A.ToString().ToLower())
{
    case "l":
        Console.WriteLine("L");
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

    string UP = Uname +"-"+ Pword;

    string loca = @"../../../customers.txt";
    File.AppendAllText(loca, UP + Environment.NewLine);
}

