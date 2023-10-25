namespace WebShop4;

public class CustomerInfo
{
    public static string[] file = File.ReadAllLines("../../../customer.csv"); // läser användare från fil
    public static List<string> CustomerList = new List<string>(); //skapar ny lista
    public static int count = 0;

    public static void ShowCustomers()
    {
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
            count++;
        }

        Console.WriteLine();
    }
    public static void EditCustomer()
    {

        Console.Clear();
        ShowCustomers();
        Console.WriteLine("Välj siffran för den användare som ska redigeras: ");
        Console.WriteLine("Eller ange 0 för att gå tillbaka");
        int userNumber;
        string number = Console.ReadLine();
        if (int.TryParse(number, out userNumber))
        {
            if (userNumber <= count)
            {

                userNumber -= 1;

                for (int i = 0; i < file.Length; i++) //loop för att se ifall index = input-1
                {
                    if (userNumber == i)
                    {
                        var thing = CustomerList[userNumber].Split(',');// separerar vald linje på "-"

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
                                EditCustomer();
                                break;
                        }

                        file[userNumber] = thing[0] + "," + thing[1] + "," + thing[2];
                        File.WriteAllLines("../../../customer.csv", file);
                        Console.Clear();
                        AdminMenu.Menu();

                    }
                    else if (number == "0")
                    {
                        Console.Clear();
                        AdminMenu.Menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Ogiltigt val. ");
                        Console.WriteLine();
                        EditCustomer();
                    }
                }
            }
            else if (count < userNumber)
            {
                Console.Clear();
                Console.WriteLine("Ogiltigt val. ");
                Console.WriteLine();
                EditCustomer();
            }

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Ogiltigt val!");
            EditCustomer();
        }

    }
}
