
<<<<<<< HEAD

=======
>>>>>>> 74c8edc365c227980f5ee4da98d20198fc4f73ee
namespace WebShop4;

public class Products
{
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
                    string? item = product + "-" + newPrice + "-" + newQuantity + "\n";
                    File.AppendAllText(productFile, item);
                }
                else
                {
                    Console.Clear();
                    AddItemMenu();
                }
            }
            else
            {
                Console.Clear();
                AddItemMenu();
            }
        }
    }


    public static void RemoveItems()
    {
        ShowItems();
        Console.WriteLine("Vilken produkt vill du ta bort från sortimentet");
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
                var productInfo = line.Split("-");
                int amountItem = int.Parse(productInfo[2]);

                if (amountItem > 1 && amountItem >= newRemoveAmount)
                {
                    amountItem -= newRemoveAmount;
                    productInfo[2] = amountItem.ToString();
                    lines[newRemove] = productInfo[0] + "-" + productInfo[1] + "-" + productInfo[2];
                }
                if (amountItem == 0)
                {
                    var erase = lines.ToList();
                    erase.RemoveAt(newRemove);
                    lines = erase.ToArray();
                }
                File.WriteAllLines(productFile, lines);
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
            Console.WriteLine("Ange en siffra");
            Console.WriteLine("--------------");
            RemoveItems();
        }
    }
}