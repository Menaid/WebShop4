namespace WebShop4;

public class UserMenu
{
    public static void Menu()
    {
        Console.WriteLine("Menu:");
        Console.Write("Varukorg = V\nProduktlista = P\nGenomförda beställningar och se kvitton = G\nExit = E");
        Console.WriteLine(" ");
        string A = Console.ReadLine();

        switch (A.ToString().ToLower())
        {
            case "v":
                Console.WriteLine("Varukorg");
                break;
            case "p":
                Console.WriteLine("Produktlista");
                break;
            case "g":
                Console.WriteLine("Genomförda beställningar och kvitton");
                break;
            case "e":
                register.LoginUser();
                break;
        }
    }
}
