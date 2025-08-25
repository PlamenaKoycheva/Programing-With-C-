//Write a program that:
//•	Reads a string on the first line from the console, representing a product:
//"coffee",  "water", "coke" or "snacks"
//•	Reads an integer on the second line from the console, representing the quantity of the product
//•	Create a method that calculates and prints the total price of an order
//•	The method should receive two parameters: product and quantity
//•	The prices for a single item of each product are:
//	coffee – 1.50
//	water – 1.00
//	coke – 1.40
//	snacks – 2.00
//•	Print the result, formatted to the second digit



string product = Console.ReadLine();

int quantity = int.Parse(Console.ReadLine());

TotalPrice(product, quantity);

static void TotalPrice(string? product, int quantity)
{
    
    double totalPrice = 0;

    if (product == "coffee")
    {
        double price = quantity * 1.50;
        totalPrice += price;
       
    }
    else if (product == "water")
    {
        double price = quantity * 1.00;
        totalPrice += price;

    }
    else if (product == "coke")
    {
        double price = quantity * 1.40;
        totalPrice += price;

    }
    else if (product == "snacks")
    {
        double price = quantity * 2.00;
        totalPrice += price;

    }
    Console.WriteLine($"{totalPrice:F2}");

}