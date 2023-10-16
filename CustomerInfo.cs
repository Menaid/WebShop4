
using System.ComponentModel;
using WebShop4;
namespace WebShop4;

public class CustomerInfo
{
    

    public static void EditInfo()
    {
        string[] file = File.ReadAllLines("../../../customers.txt");
        List<string> CustomerList = new List<string>();

        foreach (string item in file)
        {
            CustomerList.Add(item);
            CustomerList = new List<string>(item.Split("-"));

        }

        for (int i = 0; i < file.Length; i++)
        {
            var viewCustomers = file[i];
            Console.WriteLine((i + 1) + ". " + viewCustomers);

        }

        Console.WriteLine("Vilken användare vill du ändra på?: ");


        var input = Console.ReadLine();
        if (input == "")
        {
            Console.Clear();
            //Menu.AdminChoice();
        }
        
        switch (input)
        {
            case "1":
                Console.WriteLine("Nytt namn: ");
                var NewName = Console.ReadLine();
                CustomerList[0] = NewName;

                break;
            case "2":
                Console.WriteLine("Nytt lösenord: ");
                var NewPassword = Console.ReadLine();
                CustomerList[1] = NewPassword;
                break;
        }

        int b = int.Parse(input);
        b -= 1;
        file[b] = CustomerList[0] + "-" + CustomerList[1];
        File.WriteAllLines("../../../customers.txt", file);
        Console.Clear();


    }
}
