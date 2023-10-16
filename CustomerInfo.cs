
using System.ComponentModel;
using WebShop4;
namespace WebShop4;

public class CustomerInfo
{
    



    public static void ShowInfo()
    {
        string[] file = File.ReadAllLines("../../../customers.txt");
        List<string> CustomerList = new List<string>();

        foreach (string item in file)
        {
            CustomerList.Add(item);
            //CustomerList = new List<string>(item.Split("-"));
        }
        foreach(string item in CustomerList)
        {
            Console.WriteLine(item);
        }
    }

    public void EditInfo()
    {

    }
}
