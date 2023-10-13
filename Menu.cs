namespace WebShop4
{
    internal class Menu
    {
        public static void MenuChoice()
        {
            Console.WriteLine("Hej och välkommen till WebShop 4");
            Console.WriteLine("Vänligen ange om du vill logga in eller registrera dig som ny användare.");
            Console.WriteLine("För att logga in som befintlig användare ange | L | för att registrera dig som ny ange | R |");
            Console.WriteLine("Är du admin och vill logga in som admin ange | A |");

            string? userInput = Console.ReadLine().ToLower();

            bool run = true;
            while (run)
            {

                switch (userInput)
                {
                    case "l":
                        register.Login();
                        run = false;
                        break;
                    case "r":
                        register.reg();
                        run = false;
                        break;
                    case "a":
                        AdminChoice();
                        run = false;
                        break;

                }

            }

        }

        public static void AdminChoice()
        {
            bool run = true;

            string adminChoice;

            Console.WriteLine("Vad vill du göra? ");
            Console.WriteLine("Välj ett av följande alternativ. ");
            Console.WriteLine("1. Lägga till en produkt i sortimentet");
            Console.WriteLine("2. Tabort en produkt i sortimentet");
            Console.WriteLine("3. Visa och redigera kundinfo");
            Console.WriteLine("4. Visa transaktioner");
            Console.WriteLine("5. Logga ut");
            adminChoice = Console.ReadLine();

            while (run)
            {

                switch (adminChoice)
                {
                    case "1":
                        ForAdmin.addItem();
                        run = false;
                        break;
                    case "2":
                        ForAdmin.remItem();
                        run = false;
                        break;
                    case "3":
                        ForAdmin.CustomerInfo();
                        run = false;
                        break;
                    case "4":
                        AdminChoice();
                        run = false;
                        break;
                    case "5":
                        Console.WriteLine("Du loggas nu ut.");
                        MenuChoice();
                        run = false;
                        break;
                    default:
                        break;

                }

            }

        }


        public static void UserMenu()
        {
            Console.WriteLine("Menu:");
            Console.Write("Se din varukorg = V\nProduktlista = P\nGenomförda beställningar och se kvitton = G\nExit = E");
            Console.WriteLine(" ");
            string A = Console.ReadLine();

            switch (A.ToString().ToLower())
            {
                case "v":
                    Console.WriteLine("Se din varukorg");
                    ShoppingCart.Cart();
                    break;
                case "p":
                    Products.ProductList();
                    break;
                case "g":
                    Console.WriteLine("Genomförda beställningar och kvitton");
                    break;
                case "e":
                    UserMenu();
                    break;
            }
        }

    }
}
