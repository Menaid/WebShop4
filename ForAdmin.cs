namespace WebShop4;

public class ForAdmin
{
    bool editCustomerInfo = true;
    bool editeProductList = true;
    bool Oversight = true;

    // string[] products = File.ReadAllLines(".....txt");
    // string[] oversight = File.ReadAllLines("....txt");
    public static void CustomerInfo()
    public static void EditItemList()
    {
        Console.WriteLine("\nLägg till produkt = L\nTa bort produkt = T\nExit = E\n");
        string A = Console.ReadLine(); //admin svar
                
        string[] lines = File.ReadAllLines("../../../produktlista.txt");//gör en array av fil
        List<string> product = new List<string>();
        string[] customers = File.ReadAllLines("../../../customers.txt");

        switch (A.ToString().ToLower())//gör en switch där admin svar görs till string med små bokstäver
        List<string> customs = new List<string>();
        var count = customs.Count();

        for (int i = 0; i < customers.Length; i++)
        {
            case "t":
                Console.WriteLine("\nVad ska tas bort?\n");
                for (int i = 0; i < lines.Count(); i++)
                {
                    var a = i + 1;
                    Console.WriteLine(a +". "+ lines[i]);
                }
                foreach (string item in lines)
                {
                    product.Add(item);
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

                Console.WriteLine("Vilken vill du ta bort?: ");
                string remove = Console.ReadLine();
                int c = int.Parse(remove);
                int NewRemove = c - 1;
                for (int i = 0; i < product.Count(); i++)
        switch (read)
                {
                    if (product[i] == product[NewRemove])
                    {                     
                        product.Remove(product[i]);
                        File.WriteAllLines("../../../produktlista.txt", product);
                        Console.Clear();
                        EditItemList();
                    }
                }

            case "1":
                Console.WriteLine("Vad ska ditt nya namn vara?: ");
                var NewName = Console.ReadLine();
                customs[0] = NewName;               
                break;
            case "2":

            case "l":
                Console.WriteLine("Vad ska läggas till?");
                Console.WriteLine("Namn på produkt: ");
                string iName = Console.ReadLine();
                Console.WriteLine("Produktpris: ");
                string iCost = Console.ReadLine();
                string NC = iName + "-" + iCost;
                string loca = @"../../../produktlista.txt";
                File.AppendAllText(loca, NC + "\n");
                Console.Clear();
                EditItemList();
                Console.WriteLine("Vad ska ditt nya lösenord vara?: ");

                var NewPass = Console.ReadLine();
                customs[1] = NewPass;

                break;
            case "e":
                UserMenu.Menu();
                break;
        }
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
