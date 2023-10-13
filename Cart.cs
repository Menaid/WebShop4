
namespace WebShop4;

public class Cart
{
    public List<Products> Items;
    public Cart(string username)
    {
        string[] data = File.ReadAllLines("../../../carts/" + username + ".csv");

        foreach (string item in data)
        {
            Items.Add(new Products(item));
        }

    }
}
