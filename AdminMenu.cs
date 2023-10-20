namespace WebShop4;

public class AdminMenu
{
    public static void Menu()
    {
        Console.WriteLine("För att redigera en användare ange: 1");
        Console.WriteLine("För att redigera katalogen ange: 2");
        Console.WriteLine("För att logga ut ange: 3");
        var Admininput1 = Console.ReadLine();
        
        switch (Admininput1)
        {
            case "1":
                CustomerInfo.EditInfo();
                break;
            case "2":
                Products.EditCatalog();
                break;
            case "3":
                Console.Clear();
                SystemLogin.startLogin();
                break;
        }
    }
}
