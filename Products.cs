namespace WebShop4;

public class Products
{
    public static void EditCatalog()
    {
        Console.Clear();
        ShowItems();
        Console.WriteLine("------------------------------");
        Console.WriteLine("Vill du lägga till produkt ange: 1");
        Console.WriteLine("Vill du ta bort produkt ange: 2");
        Console.WriteLine("Vill du gå tillbaka ange: 3");
        Console.WriteLine("------------------------------");
        var input = Console.ReadLine();
        switch (input)
        {
            case "1":
                AddItemMenu();
                break;
            case "2":
                RemoveItems();
                break;
            case "3":
                Console.Clear();
                AdminMenu.Menu();
                break;
        }
    }

const string productFile = "../../../products.csv";
    public static string[] lines = File.ReadAllLines(productFile);
    public static void ShowItems()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(i + 1 + ": " + lines[i]);
        }
    }

    public static void AddItemMenu()
    {
        ShowItems();
        Console.WriteLine("Vänligen ange varans namn:");
        string productName = Console.ReadLine();
        Console.WriteLine("Vänligen ange varans pris:");
        string cost = Console.ReadLine();
        Console.WriteLine("Vänligen ange varans antal:");
        string amount = Console.ReadLine();
        AddItems(productName, cost, amount);
    }

    public static void AddItems(string product, string price, string quantity)
    {
        int newProduct;
        float newPrice;
        int newQuantity;
        if (int.TryParse(product, out newProduct))
        {
            Console.Clear();
            AddItemMenu();
        }
        else
        {

            if (float.TryParse(price, out newPrice))
            {
                if (int.TryParse(quantity, out newQuantity))
                {
                    string? item = product + "," + newPrice + "," + newQuantity + "\n";
                    File.AppendAllText(productFile, item);
                    Console.Clear();
                    EditCatalog();
                }
                else
                {
                    EditCatalog();
                }
            }
            else
            {
                EditCatalog();
            }
        }
    }


    public static void RemoveItems()
    {
        ShowItems();
        Console.WriteLine("Vilken produkt vill du ta bort från sortimentet? Ange siffra:");
        string remove = Console.ReadLine();
        int newRemove;
        int newRemoveAmount;
        if (int.TryParse(remove, out newRemove))
        {
            newRemove -= 1;
            Console.WriteLine("Hur många vill du ta bort?");
            string removeAmount = Console.ReadLine();
            if (int.TryParse(removeAmount, out newRemoveAmount))
            {

                var line = lines[newRemove];
                var productInfo = line.Split(",");
                int amountItem = int.Parse(productInfo[2]);

                if (amountItem > 1 && amountItem >= newRemoveAmount)
                {
                    amountItem -= newRemoveAmount;
                    productInfo[2] = amountItem.ToString();
                    lines[newRemove] = productInfo[0] + "," + productInfo[1] + "," + productInfo[2];
                }
                if (amountItem <= 0)
                {
                    var erase = lines.ToList();
                    erase.RemoveAt(newRemove);
                    lines = erase.ToArray();
                }
                File.WriteAllLines(productFile, lines);
                Console.Clear();
                EditCatalog();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ange en siffra");
                Console.WriteLine("--------------");
                RemoveItems();
            }
        }
        else if (!int.TryParse(remove, out newRemove))
        {
            Console.Clear();
            EditCatalog();
        }
    }
}