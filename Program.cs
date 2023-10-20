using System.Threading.Channels;
using WebShop4;


string[] carts = Directory.GetFiles(($"../../../Carts/"));

var contains = File.ReadAllText(carts[1]);

foreach (var item in carts)
{
    Console.WriteLine(item);
}


SystemLogin.startLogin();