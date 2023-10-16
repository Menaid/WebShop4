
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
            Console.WriteLine(i + 1 + ". " + file[i]);

        }

        Console.WriteLine("Vill du (1)ändra på en användare eller (2)gå tillbaka?");
        var choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Välj siffran för den användare som ska redigeras: ");
            string number = Console.ReadLine();
            int userNumber = int.Parse(number) - 1;

            for (int i = 0; i < CustomerList.Count; i++)
            {
                if (i == userNumber)
                {
                    Console.WriteLine("Vill du ändra (1)användarnamn eller (2)lösenord?");
                    string nameOrPass = Console.ReadLine();
                    switch (nameOrPass)
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

                    int b = int.Parse(nameOrPass);
                    b -= 1;
                    file[b] = CustomerList[0] + "-" + CustomerList[1];
                    File.WriteAllLines("../../../customers.txt", file);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Kunde inte hitta siffran i listan.");
                    EditInfo();
                }
            }
        }

        else
        {
            Console.WriteLine("exit");
        }

        

        var input = Console.ReadLine();
        if (input == "")
        {
            Console.Clear();
            //Menu.AdminChoice();
        }
        
        


    }
}
