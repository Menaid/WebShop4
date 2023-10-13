
namespace WebShop4
{
    public class Products
    {
        public Products(string item)
        {

        }

        public string? ProductName;
        public int Quantity;
        public int Price;
        
        public static void ProductList()
        {
            
            string[] ItemsInCollection = File.ReadAllLines("../../../produktlista.txt");
            Console.Clear();
            Console.WriteLine("----------");
            for (int i = 0; i < ItemsInCollection.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + ItemsInCollection[i]);
            }
            Console.WriteLine("----------");
            Console.WriteLine("Vill du lägga till någon produkt till din varukorg? \n eller vill du gå tillbaka till menyn? \n J för att lägga till | N för att gå tillbaka till menyn");
            string? DoOrDoNot = Console.ReadLine().ToLower();

            if (DoOrDoNot == "j")
            {
                Console.Clear();
                Console.WriteLine("----------");
                for (int i = 0; i < ItemsInCollection.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + ItemsInCollection[i]);
                }
                Console.WriteLine("----------");
                Console.WriteLine("Vilken produkt vill du lägga till?: ");
                int input = int.Parse(Console.ReadLine())-1;
                string a = input.ToString();

                for (int i = 0; i < ItemsInCollection.Length; i++)
                {
                    if (input == i)
                    {
                        string username = "username";
                        string loca = "../../../carts/" + username + ".csv";
                        File.AppendAllText(loca, ItemsInCollection[i] + Environment.NewLine);

                    }
                    
                }
            }
            else
            {
                Menu.UserMenu();
            }
        }
    }
}

