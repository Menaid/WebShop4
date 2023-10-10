
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
            }
        }

        public static void RemoveFromCart()
        {

        }

    }
}
