
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
                List<string> things = new List<string>();

                for (int i = 0; i < ItemsInCollection.Length; i++)
                {
                    if (ItemsInCollection[i] == a)
                    {
                        things.Add(a);
                        
                    }
                }
                foreach (string item in things)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Menu.UserMenu();
            }
        }
    }
}

