﻿
namespace WebShop4
{
    public class Products
    {
        public string? ProductName;
        public int Quantity;
        public int Price;

        static void ProductList()
        {
            string[] ItemsInCollection = File.ReadAllLines("../../../produktlista.txt");

            foreach (var item in ItemsInCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

