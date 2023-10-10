
namespace WebShop4
{
    public class ShoppingCart
    {
        public static void Cart()
        {
            List<Products> Cart = new List<Products>();
            if (Cart == null)
            {
                Console.WriteLine("Din varukorg är just nu tom.");
                Console.WriteLine("Vill du gå till produktlistan eller gå tillbaka till menyn?");
                Console.WriteLine("P för produktlista | M för meny");
                string? choice = Console.ReadLine().ToLower();
                if (choice == "p")
                {

                }
            }
            else
            {
                Console.WriteLine("Din varukorg innehåller: ");
                foreach (var item in Cart)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Vill du ta bort något från din varukorg?");
                Console.WriteLine("Ja för att ta bort | Nej för att gå tillbaka till menyn");
                string? remove = Console.ReadLine().ToLower();
                if (remove == "Ja")
                {
                    RemoveFromCart();
                }
                else
                {
                    Menu.UserMenu();
                }
            }
        }

        public static void RemoveFromCart()
        {

        }

    }
}
