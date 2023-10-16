
namespace WebShop4;

public class Products
{
    public static string[] lines = File.ReadAllLines("../../../products.csv");

    public static void ShowItems()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(i + 1 + ": " + lines[i]);
        }
    }
    /*
    public static void AddItems(string product, float price, int quantity)
    {
        string? productName = product;
        float cost = price;
        int amount = quantity;
        string newCost = cost.ToString();
        string newAmount = amount.ToString();

        string? item = productName + "-" + newCost + "-" + newAmount;
        Console.ReadKey();
        string line = "../../../products.csv";
        File.AppendAllText(line, item);
    }
    */

    public static void RemoveItems()
    {
        List<string> productInfo = new List<string>();
        ShowItems();

        Console.WriteLine("Vilken produkt vill du ta bort från sortimentet");
        int remove = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Hur många vill du ta bort?");
        int removeAmount = int.Parse(Console.ReadLine());

		var line = lines[remove];
		productInfo = line.Split("-");



        //for (int i = 0; i < lines.Length; i++)
        //{
          //  productInfo = new List<string>(lines[remove].Split("-"));

        //}

        int amountItem = int.Parse(productInfo[2]);

        string local = "../../../products.csv";

        if (amountItem > 1 && amountItem >= removeAmount)
        {
            amountItem -= removeAmount;
            productInfo[2] = amountItem.ToString();
            lines[remove] = productInfo[0] + "-" + productInfo[1] + "-" + productInfo[2];
                    }
        if (amountItem == 0)
        {
			// Använd remove at 
			lines.RemoveByIndex(remove);
			//lines = lines.ToList().RemoveAt(remove).ToArray();
        }
		File.WriteAllLines(local, lines);
    }

}
