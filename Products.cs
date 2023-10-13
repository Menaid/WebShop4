
namespace WebShop4
{
    public class Products
    {
        public string? ProductName;
        public int Quantity;
        public int Price;

        public static void ProductList()
        {
            string[] ItemsInCollection = File.ReadAllLines("../../../produktlista.txt");

            foreach (var item in ItemsInCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Vill du lägga till någon produkt till din varukorg? \n eller vill du gå tillbaka till menyn? \n Ja för att lägga till | Nej för att gå tillbaka till menyn");
            string? DoOrDoNot = Console.ReadLine().ToLower();

            if (DoOrDoNot == "ja")
            {
                ForAdmin.addItem();
            }
            else
            {
                Menu.UserMenu();
            }
        }

    }
}

