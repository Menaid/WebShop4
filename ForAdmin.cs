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

        string[] customers = File.ReadAllLines("../../../customers.txt");
    
        List<string> customs = new List<string>();
        var count = customs.Count();

        for (int i = 0; i < customers.Length; i++)
        {
            var viewCustomers = customers[i];
            Console.WriteLine((i + 1) + ". " + viewCustomers);
        }
        Console.WriteLine("Vilken användare vill du ändra på?");  // La till lite förtydligande där man blir tillfrågad om vem man vill redigera på.

        var a = Console.ReadLine();
        int b = int.Parse(a);
        b -= 1;

        var AdminChoice = customers[b];

        customs = new List<string>(AdminChoice.Split("-"));
        Console.WriteLine("Vill du ändra namn eller lösen");
        Console.WriteLine("Namn = 1 | Lösen = 2");
        Console.WriteLine(" ");
        var read = Console.ReadLine();

        switch (read)
        {
<<<<<<< HEAD
            customs = new List<string>(AdminChoice.Split("-"));
            Console.WriteLine("Vill du ändra namn eller lösen");
            Console.WriteLine("Namn = 1 | Lösen = 2");
            Console.WriteLine(" ");
            var read = Console.ReadLine();
           
            switch (read)
            {
                case "1":
                    Console.WriteLine("Vad för namn?: ");
                    var NewName = Console.ReadLine();
                    customs[0] = NewName;
                    string[] arr = customs.ToArray();
                    customers = arr;
                    break;
                case "2":
                    Console.WriteLine("Vad för lösen?: ");
                    var NewPass = Console.ReadLine();
                    customs[1] = NewPass;
                    arr = customs.ToArray();
                    customers = arr;
                    break;
                
            }
=======
            case "1":
                Console.WriteLine("Vad ska ditt nya namn vara?: ");
                var NewName = Console.ReadLine();
                customs[0] = NewName;               
                break;
            case "2":

                Console.WriteLine("Vad ska ditt nya lösenord vara?: ");

                var NewPass = Console.ReadLine();
                customs[1] = NewPass;

                break;
>>>>>>> c58d1e36b34ec69777fcf8beed17dd49d6293291
        }
        customers[b] = customs[0] + "-" + customs[1];

        File.WriteAllLines("../../../customers.txt", customers);

    }


    //string[] arr = customs.ToArray();
    //customers = arr;

    //public string ProductList()
    //{

    //}

    //public string Oversight()
    //{

    //}

}
