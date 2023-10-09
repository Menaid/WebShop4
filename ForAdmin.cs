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

    // string[] products = File.ReadAllLines(".....txt");
    // string[] oversight = File.ReadAllLines("....txt");
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
        //string[] arr = customs.ToArray();
        //customers = arr;

        //public string ProductList()
        //{

        //}

        //public string Oversight()
        //{

        //}
    }
    public static void EditItemList()
    {
        Console.WriteLine("\nLägg till produkt = L\nTa bort produkt = T\nExit = E\n");
        string A = Console.ReadLine(); //admin svar
                
        string[] lines = File.ReadAllLines("../../../produktlista.txt");//gör en array av fil
        string tempFile = @"../../../tempfile.txt";
        bool deleted = false;

        switch (A.ToString().ToLower())//gör en switch där admin svar görs till string med små bokstäver
        {
            case "t":
                Console.WriteLine("\nVad ska tas bort?\n");
                foreach(string item in lines)
                {
                    Console.WriteLine(item);
                }//visar hela produktlistan
                Console.WriteLine("\nNamn på produkt: ");
                string pName = Console.ReadLine();

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split("-");
                    if(pName == fields[0])
                    {
                        //lines.Remove(fields[0], fields[1]);
                    }
                }

                
                //int b = int.Parse(pName);//string pName to int pName, to variable b
                //b --;// b-1 pga list index börjar på 0
                //var pChoice = lines[b]; //ny variabel som är lika med lista av användare[platsnummer val]

                //if (pChoice == lines[b])
                //{
                //    string produktlista = @"../../../produktlista.txt";
                //    //File.AppendAllText(produktlista,  );
                //}
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


