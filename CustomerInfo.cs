
using System.ComponentModel;
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

            for (int i = 0; i < CustomerList.Count; i++) //loop för att se ifall index = input
            {
                if (CustomerList[userNumber] == CustomerList[i])
                {
                    string[] line = CustomerList[i].Split('-');// gör en array av namnet och lösen för att split på "-"
                    foreach(string item in line)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Vill du ändra (1)användarnamn eller (2)lösenord?");
                    string nameOrPassword = Console.ReadLine();

                    var a = file[userNumber];
                    CustomerList = new List<string>(a.Split("-"));

                    switch (nameOrPassword)
                    {
                        case "1":
                            Console.WriteLine("Nytt namn: ");
                            var NewName = Console.ReadLine();
                            line[0] = NewName;

                            break;
                        case "2":
                            Console.WriteLine("Nytt lösenord: ");
                            var NewPassword = Console.ReadLine();
                            line[1] = NewPassword;
                            break;
                    }

                    line[i] = line[0] + "-" + line[1];
                    File.WriteAllLines("../../../customers.txt", line);
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
