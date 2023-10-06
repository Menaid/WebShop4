namespace WebShop4;

public class ForAdmin
{
    bool editCustomerInfo = true;
    bool editeProductList = true;
    bool Oversight = true;

    // string[] products = File.ReadAllLines(".....txt");
    // string[] oversight = File.ReadAllLines("....txt");
    public static void CustomerInfo()
    {
        string[] customers = File.ReadAllLines("../../../admins.txt");

        //for (int i = 0; i < customers.Length; i++)
        //{
        //    var viewCustomers = customers[i];
        //    Console.WriteLine((i + 1) + ". " + viewCustomers);
        //}

        for (int i = 0; i < customers.Length; i++)
        {
            Console.WriteLine(customers[i]);
            File.WriteAllLines("../../../customers.txt", customers);
        }

        return;

    }

    //public string ProductList()
    //{

    //}

    //public string Oversight()
    //{

    //}

}
