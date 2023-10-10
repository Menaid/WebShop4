namespace WebShop4;

public class Adm
{
    bool run = true;
    public static void AdminChoice()
    {
        bool run = true;

        string adminChoice;

        Console.WriteLine("Vad vill du göra? ");
        Console.WriteLine("Välj ett av följande alternativ. ");
        Console.WriteLine("1. Lägga till en produkt i sortimentet");
        Console.WriteLine("2. Tabort en produkt i sortimentet");
        Console.WriteLine("3. Visa och redigera kundinfo");
        Console.WriteLine("4. Visa transaktioner");
        adminChoice = Console.ReadLine();

        while (run)
        {

            switch (adminChoice)
            {
                case "1":
                    NewAdmin.addItem();
                    break;
                case "2":
                    NewAdmin.remItem();
                    break;
                case "3":
                    NewAdmin.CustomerInfo();
                    break;
                case "4":
                    
                    break;
                case "5":
                    Console.WriteLine("Du loggas nu ut.");
                    Menu.MenuChoice();
                    break;
                default:
                    break;
            }
        }
    }
}
