
namespace WebShop4;

public class AdminMenu
{
    public static void Menu()
    {
        Console.WriteLine("Menu:");
        Console.Write("Redigera och visa kund info = R\nÄndra produktlista = P\nVisa transaktioner = T\nExit = E");
        Console.WriteLine(" ");
        string A = Console.ReadLine();

        switch (A.ToString().ToLower())
        {
            case "r":
                //ForAdmin.CustomerInfo();
                break;
            case "p":
                NewAdmin.EditItemList();
                break;
            case "t":
                Console.WriteLine("Genomförda beställningar och kvitton");
                break;
            case "e":
                //register.startCustom();
                break;
        }
    }
}
