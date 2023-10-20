
using System.ComponentModel;
using System.Reflection.Metadata;
using WebShop4;
namespace WebShop4;

public class CustomerInfo
{
   
    public static void EditInfo()
    {
        string[] file = File.ReadAllLines("../../../customer.csv"); // läser användare från fil
        List<string> CustomerList = new List<string>(); //skapar ny lista
        Console.WriteLine();
        Console.WriteLine("Registrerade kunder:");
        Console.WriteLine();
        foreach (string item in file)//kopierar användare från fil till lista
        {
            CustomerList.Add(item);
        }

        for (int i = 0; i < CustomerList.Count; i++) //skriver ut lista på användare
        {
            Console.WriteLine(i + 1 + ". " + CustomerList[i]);
        }
        Console.WriteLine();

        Console.WriteLine("För att redigera en användare ange: 1\nFör att gå tillbaka ange: 2");//ger val för edit eller exit
        var choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Clear();
            Console.WriteLine("Välj siffran för den användare som ska redigeras: ");

            for (int i = 0; i < CustomerList.Count; i++) //skriver ut lista på användare
            {
                Console.WriteLine(i + 1 + ". " + CustomerList[i]);
            }
            string number = Console.ReadLine();
            int userNumber = int.Parse(number) - 1;// svaret -1 pga lista börjar på 0

            for (int i = 0; i < file.Length; i++) //loop för att se ifall index = input-1
            {
                if (userNumber == i)
                {
                    var thing = CustomerList[userNumber].Split('-');// separerar vald linje på "-"
                    
                    Console.WriteLine("För att ändra användarnamn ange: 1\nFör att ändra lösenord ange: 2");
                    string nameOrPassword = Console.ReadLine();

                    switch (nameOrPassword)
                    {
                        case "1":
                            Console.WriteLine("Nytt namn: ");
                            var NewName = Console.ReadLine();
                            thing[0] = NewName;
                           
                            break;
                        case "2":
                            Console.WriteLine("Nytt lösenord: ");
                            var NewPassword = Console.ReadLine();
                            thing[1] = NewPassword;
                            break;
                        default:
                            EditInfo();
                            break;
                    }

                    file[userNumber] = thing[0] + "-" + thing[1] +"-"+ thing[2];
                    File.WriteAllLines("../../../customer.csv", file);
                    Console.Clear();
                    AdminMenu.Menu();
                }
            }
        }
        else if(choice == "2")
        {
            Console.Clear();
            AdminMenu.Menu();
        }

        else
        {
            Console.WriteLine("Ogiltigt val. ");
            Console.WriteLine();
            EditInfo();
        }

    }
}
