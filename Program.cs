using WebShop4;


Console.WriteLine("Do you want to register or log in?:");
Console.Write("| L = Login | R = Register | ");
Console.WriteLine(" ");
string A = Console.ReadLine();

switch (A.ToString().ToLower())
{
    case "l":
        register.Login();
        break;
    case "r":
        register.reg();
        break;
}
