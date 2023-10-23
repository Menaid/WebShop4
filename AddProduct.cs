using System.Runtime.Intrinsics.Arm;
using WebShop4;

public class AddProduct
{
    const string productList = "../../../products.csv";
    public static string[] products = File.ReadAllLines(productList);

    public static void productMenu()
    {
        Console.Clear();
        Console.WriteLine("Hej " + SystemLogin.SignedInUser);
        Console.WriteLine("------------------------------");
        Console.WriteLine("1. lägga till produkt");
        Console.WriteLine("2. ta bort produkt");
        Console.WriteLine("3. logga ut:");
        Console.WriteLine("------------------------------");
        int userChoice;

        while (true)
        {
            Console.Write("\nVälj alternativ: ");
            if (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 3)
            {
                Console.WriteLine("\nOgiltigt val. Var god försök igen.\n");
                continue;
            }

            break;
        }

        switch (userChoice)
        {
            case 1:
                addToCart();
                break;
            case 2:
                RemoveFromCart();
                break;
            case 3:
                Console.WriteLine("Hej då!");
                SystemLogin.startLogin();
                break;
        }
    }

    public static void showProductsList()
    {
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + products[i]);
        }
    }


    public static void addToCart()
    {
        var userFilePath = "../../../Carts/Cart." + SystemLogin.SignedInUser + ".csv";
        Console.Clear();
        Console.WriteLine("Tillgängliga produkter:");
        Console.WriteLine("-------------------");
        showProductsList();
        Console.WriteLine("-------------------");
        Console.WriteLine("Vill du lägga till någon produkt till din varukorg? (J) \n" +
                          "eller vill du gå tillbaka till menyn? (N) \n (J / N)");
        string? answer = Console.ReadLine().ToLower();

        if (answer == "j")
        {
            Console.Clear();
            Console.WriteLine("--------------");
            showProductsList();
            Console.WriteLine("--------------");
            Console.WriteLine("Vilken produkt vill du lägga till ? ");

            int newChoice;
            if (int.TryParse(Console.ReadLine(), out newChoice))
            {
                if (newChoice >= 1 && newChoice <= products.Length)
                {
                    string selectedProduct = products[newChoice - 1];
                    File.AppendAllLines(userFilePath, selectedProduct.Split(""));
                    Console.WriteLine($"{selectedProduct} lagt till i din kundvagn.");
                    addToCart();
                }
                else
                {
                    int timmer = 2000;
                    Console.Clear();
                    Console.WriteLine("---------------");
                    Console.WriteLine("Fel inmatning.");
                    Console.WriteLine("---------------");
                    Thread.Sleep(timmer);
                    Console.Clear();
                    addToCart();
                }
            }
            else
            {
                int timmer = 2000;
                Console.Clear();
                Console.WriteLine("---------------");
                Console.WriteLine("Fel inmatning.");
                Console.WriteLine("---------------");
                Thread.Sleep(timmer);
                Console.Clear();
                addToCart();
            }
        }

        else if (answer == "n")
        {
            productMenu();
        }
        else if (answer != "j" || answer != "n")
        {
            int timmer = 2000;
            Console.WriteLine("Fel inmatning, försök på nytt.");
            addToCart();
        }
        
    }

    public static void RemoveFromCart()
    {
        int timmer = 2000;
        Console.WriteLine("NotImplementedException");
        Thread.Sleep(timmer);
        productMenu();
    }
}