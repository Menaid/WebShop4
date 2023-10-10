namespace WebShop4;

public class NewAdmin
{
    public static void EditItemList()
    {
        Console.WriteLine("\nLägg till produkt = L\nTa bort produkt = T\nExit = E\n");
        string A = Console.ReadLine(); //admin svar

        string[] lines = File.ReadAllLines("../../../produktlista.txt");//gör en array av fil
        List<string> product = new List<string>();

        switch (A.ToString().ToLower())//gör en switch där admin svar görs till string med små bokstäver
        {
            case "t":
                Console.WriteLine("\nVad ska tas bort?\n");
                for (int i = 0; i < lines.Count(); i++)
                {
                    var a = i + 1;
                    Console.WriteLine(a + ". " + lines[i]);
                }
                foreach (string item in lines)
                {
                    product.Add(item);
                }

                Console.WriteLine("Vilken vill du ta bort?: ");
                string remove = Console.ReadLine();
                int c = int.Parse(remove);
                int NewRemove = c - 1;
                for (int i = 0; i < product.Count(); i++)
                {
                    if (product[i] == product[NewRemove])
                    {
                        product.Remove(product[i]);
                        File.WriteAllLines("../../../produktlista.txt", product);
                        Console.Clear();
                        EditItemList();
                    }
                }

                break;

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

                break;
            case "e":
                UserMenu.Menu();
                break;
        }
    }
}


