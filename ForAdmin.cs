namespace WebShop4;

public class ForAdmin
{
    string ItemName;
    string ItemCost;
    public ForAdmin(string iName, string iCost)
    {
        ItemName = iName;
        ItemCost = iCost;
    }

    bool editCustomerInfo = true;
    bool editeProductList = true;
    bool Oversight = true;

    // string[] products = File.ReadAllLines(".....txt");
    // string[] oversight = File.ReadAllLines("....txt");
    public static void CustomerInfo()
    {

        string[] customers = File.ReadAllLines("../../../admins.txt");
        string[] temp = File.ReadAllLines("../../../tempfile.txt");

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

        if (AdminChoice == customers[b])
        {
            customs = new List<string>(AdminChoice.Split("-"));
            Console.WriteLine("Vill du ändra namn eller lösen");
            Console.WriteLine("Namn = 1 | Lösen = 2");
            Console.WriteLine(" ");
            var read = Console.ReadLine();

            switch (read)
            {
                case "1":
                    Console.WriteLine("Vad ska ditt nya namn vara?: ");
                    var NewName = Console.ReadLine();
                    customs[0] = NewName;
                    string tem = @"../../../tempfile.txt";
                    string tempo = @"../../../customers.txt";
                    File.AppendAllText(tem, NewName + "-" + customs[1] + Environment.NewLine);

                    break;
                case "2":

                    Console.WriteLine("Vad ska ditt nya lösenord vara?: ");

                    Console.WriteLine("Vad för lösen?: ");

                    var NewPass = Console.ReadLine();
                    customs[1] = NewPass;

                    break;
            }
        }


    }
    public static void EditItemList()
    {
        string[] pLista = File.ReadAllLines("../../../produktlista.txt");

        Console.WriteLine("\nLägg till produkt = L\nTa bort produkt = T");
        Console.WriteLine();
        string A = Console.ReadLine();

        switch (A.ToString().ToLower())
        {
            case "t":
                Console.WriteLine("Vad ska tas bort?");
                foreach(string item in pLista)
                {
                    Console.WriteLine(item);
                }
                
                break;
            case "l":
                Console.WriteLine("Vad ska läggas till?");
                
                Console.WriteLine("Namn på produkt: ");
                string iName = Console.ReadLine();
                Console.WriteLine("Produktpris: ");
                string iCost = Console.ReadLine();

                Item product = new Item(itemName: iName, itemCost: iCost);

                string NC = iName + "-" + iCost;

                string loca = @"../../../produktlista.txt";
                File.AppendAllText(loca, NC + Environment.NewLine);

                break;
        }
        
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


