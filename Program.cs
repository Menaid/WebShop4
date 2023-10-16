using WebShop4;

Console.WriteLine("Vänligen ange varans: namn, pris och kvantitet.");

string productName = Console.ReadLine();
float cost = float.Parse(Console.ReadLine());
int amount = int.Parse(Console.ReadLine());
Products.AddItems(productName, cost, amount);

//Products.RemoveItems();