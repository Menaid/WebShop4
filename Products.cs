
namespace WebShop4;

public class Products
{
    public static string[] lines = File.ReadAllLines("../../../products.csv");

    public static void ShowItems()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(i + 1 + lines[i]);
        }
    }

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
        File.WriteAllText(line, item);
    }

    public void RemoveItems()
    {

    }

}
