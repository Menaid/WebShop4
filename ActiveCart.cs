namespace WebShop4;

public class ActiveCart
{
    public static void CartInUse()
    {
        var path = "Cart." + SystemLogin.SignedInUser + ".csv";
    }
}