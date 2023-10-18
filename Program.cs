using WebShop4;



void Menu()
{
    Console.WriteLine("Vänligen ange ett alternativ: ");

    Console.WriteLine("1. För att Visa produktkatalogen");

    Console.WriteLine("2. För att lägga till en ny produkt till katalogen");

    Console.WriteLine("3. För att ta bort en produkt från katalogen");
    string? userInput1 = Console.ReadLine();
    string? userInput2 = Console.ReadLine();
    string? userInput3 = Console.ReadLine();


    int menuChoice1;
    if (int.TryParse(userInput1, out menuChoice1))
    {
        Console.WriteLine("Du har valt att visa produktkatalogen.");
        Products.ShowItems();
    }
    else
    {
        Console.WriteLine("Fel inmatning, försök igen.");
    }

    int menuChoice2;
    if (int.TryParse(userInput2, out menuChoice2))
    {
        Console.WriteLine("Du har valt att lägga till en ny produkt till katalogen.");
        Products.AddItemMenu();
    }
    else
    {
        Console.WriteLine("Fel inmatning, försök igen.");
    }

    int menuChoice3;
    if (int.TryParse(userInput3, out menuChoice3))
    {
        Console.WriteLine("Du har valt att ta bort en produkt från katalogen.");
        Products.RemoveItems();
    }
    else
    {
        Console.WriteLine("Fel inmatning, försök igen.");
    }

}

Menu();