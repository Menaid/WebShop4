Console.WriteLine("Do you want to register or log in?:");
Console.Write("| L = Login | R = Register | ");
Console.WriteLine(" ");
string A = Console.ReadLine();

switch(A.ToString().ToLower())
{
    case "l":
        Console.WriteLine("L");
        break;
    case "r":
        Console.WriteLine("R");
        break;
}   