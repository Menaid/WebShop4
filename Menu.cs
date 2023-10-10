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
                        register.LoginUser();
                        run = false;
                        break;
                    case "r":
                        register.reg();
                        break;
                    case "a":
                        adm.AdminChoice();
                        break;

                }

            }

        }

        public static void UserMenu()
        {
            Console.WriteLine("Menu:");
            Console.Write("Varukorg = V\nProduktlista = P\nGenomförda beställningar och se kvitton = G\nExit = E");
            Console.WriteLine(" ");
            string A = Console.ReadLine();

            switch (A.ToString().ToLower())
            {
                case "v":
                    Console.WriteLine("Varukorg");
                    break;
                case "p":
                    Console.WriteLine("Produktlista");
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
