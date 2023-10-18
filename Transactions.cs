namespace WebShop4;

public record Transactions(string userID, string product, float price, int quantity, DateTime transcationtime)
{
    public Transactions
    {
        UserID = userID;
        Product = product;
        Price = price;
        Quantity = quantity;
        Transactiontime = transcationtime;
    }
}
