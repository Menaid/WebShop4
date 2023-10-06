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

        for (int i = 0; i < customers.Length; i++)
        {
            var viewCustomers = customers[i];
            Console.WriteLine((i + 1) + ". " + viewCustomers);
        }

        var a = Console.ReadLine();
        int b = int.Parse(a);
        b -= 1;
        var AdminChoice = customers[b];

        if (AdminChoice == customers[b])
        {
            customs = new List<string>(AdminChoice.Split("-"));
            Console.WriteLine("Vill du ändra namn eller lösen");
            Console.WriteLine("Namn = 1 | Lösen = 2");
            Console.WriteLine(" ");
            var read = Console.ReadLine();
            var hej = customs[0];
            var hej1 = customs[1];
            switch (read)
            {
                case "1":
                    Console.WriteLine("Vad för namn?: ");
                    var NewName = Console.ReadLine();
                    customs[0] = NewName;
                    
                    break;
                case "2":
                    Console.WriteLine("Vad för namn?: ");
                    var NewPass = Console.ReadLine();
                    customs[1] = NewPass;
                    break;
            }
           
        }

    }

    //public string ProductList()
    //{

    //}

    //public string Oversight()
    //{

    //}

}
