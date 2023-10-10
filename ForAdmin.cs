namespace WebShop4;

public class ForAdmin
{
    string ItemName;
    string ItemCost;
    public ForAdmin(string iName, string iCost)
    {
        ItemName = iName;
        ItemCost = iCost;
    }

    bool editCustomerInfo = true;
    bool editeProductList = true;
    bool Oversight = true;

    public static void CustomerInfo()
    {

        string[] customers = File.ReadAllLines("../../../admins.txt");// gör array av fil med användare
        string[] temp = File.ReadAllLines("../../../tempfile.txt");

        List<string> customs = new List<string>(); // skapar ny lista med namnet customs
        var count = customs.Count();

        for (int i = 0; i < customers.Length; i++)//skriver ut lista med användare
        {
            var viewCustomers = customers[i];
            Console.WriteLine((i + 1) + ". " + viewCustomers);
        }
        
        Console.WriteLine("Vilken användare vill du ändra på?");
        var a = Console.ReadLine();
        int b = int.Parse(a);//string a to int a, to variable b
        b -= 1;// b-1 pga list index börjar på 0
        var AdminChoice = customers[b]; //ny variabel som är lika med lista av användare[platsnummer val]

        if (AdminChoice == customers[b])
        {
            customs = new List<string>(AdminChoice.Split("-"));//tar bort "-" från lista customs och
            Console.WriteLine("Vill du ändra namn eller lösen");
            Console.WriteLine("Namn = 1 | Lösen = 2");
            Console.WriteLine(" ");
            var read = Console.ReadLine();

            switch (read)
            {
                case "1":
                    Console.WriteLine("Vad ska ditt nya namn vara?: ");
                    var NewName = Console.ReadLine();
                    customs[0] = NewName;
                    string tem = @"../../../tempfile.txt";
                    string tempo = @"../../../customers.txt";
                    File.AppendAllText(tem, NewName + "-" + customs[1] + Environment.NewLine);

                    break;
                case "2":

                    Console.WriteLine("Vad ska ditt nya lösenord vara?: ");

                    Console.WriteLine("Vad för lösen?: ");

                    var NewPass = Console.ReadLine();
                    customs[1] = NewPass;

                    break;
            }
        }
        
    }
    public static void EditItemList()
    {
        Console.WriteLine("\nLägg till produkt = L\nTa bort produkt = T\nExit = E\n");
        string A = Console.ReadLine(); //admin svar
                
        string[] lines = File.ReadAllLines("../../../produktlista.txt");//gör en array av fil
        List<string> product = new List<string>();
        
        bool deleted = false;

        switch (A.ToString().ToLower())//gör en switch där admin svar görs till string med små bokstäver
        {
            case "t":
                Console.WriteLine("\nVad ska tas bort?\n");
                for (int i = 0; i < lines.Count(); i++)
                {
                    var a = i + 1;
                    Console.WriteLine(a +". "+ lines[i]);
                }
                foreach (string item in lines)
                {
                    product.Add(item);
                }

                Console.WriteLine("Vilken ta bort?: ");
                string remove = Console.ReadLine();
                int c = int.Parse(remove);
                int NewRemove = c - 1;
                string d = NewRemove.ToString();
                for (int i = 0; i < product.Count(); i++)
                {
                    if (product[i] == product[NewRemove])
                    {                     
                        product.Remove(product[i]);
                        File.WriteAllLines("../../../produktlista.txt", product);
                        Console.Clear();
                        EditItemList();
                    }
                }
                break;

            case "l":
                Console.WriteLine("Vad ska läggas till?");
                
                Console.WriteLine("Namn på produkt: ");
                string iName = Console.ReadLine();
                Console.WriteLine("Produktpris: ");
                string iCost = Console.ReadLine();

                string NC = iName + "-" + iCost;

                string loca = @"../../../produktlista.txt";
                File.AppendAllText(loca, NC + "\n");
                Console.Clear();
                EditItemList();

                break;
            case "e":
                AdminMenu.Menu();
                break;
        }
    }
}


