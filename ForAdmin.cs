using System.Runtime.Intrinsics.Arm;

namespace WebShop4;

public class ForAdmin
{
    public static void CustomerInfo()
    {
        string[] customers = File.ReadAllLines("../../../customers.txt");
        List<string> customs = new List<string>();
        var count = customs.Count();
        foreach (var item in customers)
        {
            customs.Add(item);

            customs = new List<string>(item.Split("-"));
        }

        customers = File.ReadAllLines("../../../customers.txt");
        Console.Clear();
        Console.WriteLine("Vilken användare vill du ändra på?: ");
        Console.WriteLine("----------");
        
        for (int i = 0; i < customers.Length; i++)
        {
            var viewCustomers = customers[i];
            Console.WriteLine((i + 1) + ". " + viewCustomers);
        }
        Console.WriteLine("----------");
        // La till lite förtydligande där man blir tillfrågad om vem man vill redigera på.

        var a = Console.ReadLine();
        if (a == "")
        {
            Console.Clear();
            Menu.AdminChoice();
        }
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
        }
        customers[b] = customs[0] + "-" + customs[1];
        File.WriteAllLines("../../../customers.txt", customers);
        Console.Clear();
        Menu.AdminChoice();

    }

    public static void remItem()
    {
        string[] lines = File.ReadAllLines(@"../../../produktlista.txt");//gör en array av fil
        List<string> product = new List<string>();

        Console.WriteLine("\nVad ska tas bort?\n");
        Console.WriteLine("----------");
        for (int i = 0; i < lines.Count(); i++)
        {
            var a = i + 1;
            Console.WriteLine(a + ". " + lines[i]);
        }
        foreach (string item in lines)
        {
            product.Add(item);
        }

        Console.WriteLine("----------");
        string remove = Console.ReadLine();
        if (remove != "")
        {
            int c = int.Parse(remove);
            int NewRemove = c - 1;
            for (int i = 0; i < product.Count(); i++)
            {
                if (product[i] == product[NewRemove])
                {
                    product.Remove(product[i]);
                    File.WriteAllLines("../../../produktlista.txt", product);
                    Console.Clear();
                    Menu.AdminChoice();
                }
            }
        }
        else
        {
            Console.Clear();
            Menu.AdminChoice();
        }
    }

    public static void addItem()
    {
        Console.WriteLine("Vad ska läggas till?");
        Console.WriteLine("Namn på produkt: ");
        string iName = Console.ReadLine();
        Console.WriteLine("Produktpris: ");
        string iCost = Console.ReadLine();

        if (iName == "" || iCost == "")
        {
            Console.Clear();
            Menu.AdminChoice();
        }

        string NC = iName + "-" + iCost;
        string loca = @"../../../produktlista.txt";
        File.AppendAllText(loca, NC + Environment.NewLine);
        Console.Clear();
        Menu.AdminChoice();
    }
}
