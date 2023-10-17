
using System.ComponentModel;
using System.Reflection.Metadata;
using WebShop4;
namespace WebShop4;

public class CustomerInfo
{
    public static void EditInfo()
    {
        string[] file = File.ReadAllLines("../../../customers.txt"); // läser användare från fil
        List<string> CustomerList = new List<string>(); //skapar ny lista

        foreach (string item in file)//kopierar användare från fil till lista
        {
            CustomerList.Add(item);
        }

        for (int i = 0; i < CustomerList.Count; i++) //skriver ut lista på användare
        {
            Console.WriteLine(i + 1 + ". " + CustomerList[i]);
        }

        Console.WriteLine("Vill du (1)ändra på en användare eller (2)gå tillbaka?");//ger val för edit eller exit
        var choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Välj siffran för den användare som ska redigeras: ");
            string number = Console.ReadLine();
            int userNumber = int.Parse(number) - 1;// svaret -1 pga lista börjar på 0

            for (int i = 0; i < file.Length; i++) //loop för att se ifall index = input
            {
                if (userNumber == i)
                {
                    var thing = CustomerList[userNumber].Split('-');// gör en array av namnet och lösen för att split på "-"
                    foreach(string item in thing)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Vill du ändra (1)användarnamn eller (2)lösenord?");
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
                    }

                    file[userNumber] = thing[0] + "-" + thing[1];
                    File.WriteAllLines("../../../customers.txt", file);
                    Console.Clear();
                }
            }
        }

        else
        {
            Console.WriteLine("exit");
        }

    }
}
