using WebShop4;

Console.WriteLine("Vänligen ange varans namn:");
string productName = Console.ReadLine();
Console.WriteLine("Vänligen ange varans pris:");
string cost = Console.ReadLine();
Console.WriteLine("Vänligen ange varans antal:");
string amount = Console.ReadLine();
Products.AddItems(productName, cost, amount);

//Products.RemoveItems();