
namespace WebShop4
{
    public class ShoppingCart
    {
        public static void EmptyCart()
        {
            List<Products> Cart = new List<Products>();
            if (Cart == null)
            {
                Console.WriteLine("Din varukorg är just nu tom.");
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
                string? taBort = Console.ReadLine().ToLower();
                if (taBort == "Ja")
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
