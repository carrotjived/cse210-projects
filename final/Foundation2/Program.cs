using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Product> productsFirst = new();
        Product firstProduct = new("Polyjuice Potion", 55652, 25, 3);
        Product secondProduct = new("Amortentia", 56253, 80, 2);
        Product thirdProduct = new("Felix Felicis", 8986, 130, 5);
        productsFirst.Add(firstProduct);
        productsFirst.Add(secondProduct);
        productsFirst.Add(thirdProduct);
        Customer firstCustomer = new("Harry Potter", "Number 12 Grimmauld Place", "Islington", "London", "United Kingdom");
        Order firstOrder = new(productsFirst, firstCustomer);
        Console.WriteLine("Products in order: ");
        firstOrder.GetPackingLabel();
        firstOrder.GetShippingLabel();
        Console.WriteLine($"Total of: {firstOrder.TotalPrice()}\n");

        List<Product> productsSecond = new();
        Product fourthProduct = new("Blue Coke", 4545, 12, 8);
        Product fifthProduct = new("Blue Pancake Syrup", 4546, 11, 15);
        Product sixthProduct = new("Blue Chocolate Chips", 4547, 4, 6);
        Product seventhProduct = new("Blue Food Coloring", 4548, 8, 24);
        productsSecond.Add(fourthProduct);
        productsSecond.Add(fifthProduct);
        productsSecond.Add(sixthProduct);
        productsSecond.Add(seventhProduct);
        Customer secondCustomer = new("Percy Jackson", "3.141 Farm Road Montauk", "New York City", "New York", "United States of America");
        Order secondOrder = new(productsSecond, secondCustomer);
        Console.WriteLine("Products in order: ");
        secondOrder.GetPackingLabel();
        secondOrder.GetShippingLabel();
        Console.WriteLine($"Total of: {secondOrder.TotalPrice()}");
    }
}