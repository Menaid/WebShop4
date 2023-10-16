namespace WebShop4;

public static void SignUp()
{
    
Console.WriteLine("Registrera dig som ny kund");
Console.WriteLine("--------------------------");
Console.WriteLine("Ange ditt namn: ");
string name = Console.ReadLine();
Console.Clear();

string[] customer = File.ReadAllLines("../../../customer.txt");
if (customer.Contains(name))
{
    Console.WriteLine("Det finns redan en användare med namnet " + name +  " vänligen välj ett annat.");
    return;
}

Console.WriteLine("Ange önskat lösenord: ");
string pw = Console.ReadLine();
Console.WriteLine("Bekräfta lösenordet: ");
string pw1 = Console.ReadLine();

while (pw != pw1)
{
    Console.WriteLine("Du angav inte samma lösenord, försök igen");
}
if (pw == pw1)
{
    Console.WriteLine("Grattis, du är nu en registrerad kund!");
}

string newCustomer = name + "-" + pw;
File.AppendAllText(customer[], newCustomer, Environment.NewLine);

}




/*
// Läser innehållet i filen
string fileContent = File.ReadAllText(filePath);

// Kontrollerar om filen är tom
if (string.IsNullOrEmpty(fileContent))
{
    // Tar bort filen om den är tom
    File.Delete(filePath);
*/