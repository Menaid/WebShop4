using System.Net.WebSockets;
using System.Runtime.InteropServices.Marshalling;

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
        List<string> customs = new List<string>();
        var count = customs.Count();
        foreach (var item in customers)
        {
            customs.Add(item);
        
            customs = new List<string>(item.Split("-"));
        }

        foreach (var item in customs)
        {
            Console.WriteLine(item);
        }

        for (int i = 0; i < customers.Length; i++)
        {
            var viewCustomers = customers[i];
            Console.WriteLine((i + 1) + ". " + viewCustomers);
        }

        var a = Console.ReadLine();
        int b = int.Parse(a);
        b -= 1;
        var AdminChoice = customers[b];
        Console.WriteLine(customers[b]);

        if (AdminChoice == customers[b])
        {

        }

    }

    //public string ProductList()
    //{

    //}

    //public string Oversight()
    //{

    //}

}
