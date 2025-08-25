//Create a program that keeps the information about products and their prices. Each product has a name, a price and a quantity. If the product doesn't
//exist yet, add it with its starting quantity.
//If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, replace the price as well.
//You will receive products' names, prices and quantities on new lines. Until you receive the command "buy", keep adding items. When you do receive the
//command "buy", print the items with their names and the total price of all the products with that name.

Dictionary<string, double> prices = new Dictionary<string, double>();
Dictionary<string, int> quantities = new Dictionary<string, int>();
string input = Console.ReadLine();
while (input != "buy")
{
    
    string[] tokens = input.Split(' ');
    string product = tokens[0];
    double price = double.Parse(tokens[1]);
    int quantity = int.Parse(tokens[2]);

    if (!prices.ContainsKey(product))
    {
        prices[product] = price;
        quantities[product] = quantity;
    }
    else
    {
        prices[product] = price; 
        quantities[product] += quantity; 
    }
    input = Console.ReadLine();
}

foreach (var item in prices)
{
    string product = item.Key;
    double price = item.Value;
    int quantity = quantities[product];
    double total = price * quantity;

    Console.WriteLine($"{product} -> {total:F2}");
}