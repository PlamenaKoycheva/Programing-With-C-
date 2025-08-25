
//Define a class Item, which contains these properties: Name and Price.
//Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
//Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
//The Price of one box has to be calculated: itemQuantity* itemPrice.
//Print all the boxes ordered descending by price for a box, in the following format: 
//{ boxSerialNumber}
//-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
//-- ${ boxPrice}
//The price should be formatted to the 2nd digit after the decimal separator.


List<Box> boxes = new List<Box>();

string[] input = Console.ReadLine().Split();

while (input[0] != "end")
{
    string serialNumber = input[0];
    string itemName = input[1];
    int itemsQuantity = int.Parse(input[2]);
    double itemPrice = double.Parse(input[3]);

    Item currentItem = new Item(itemName, itemPrice);
    Box currentBox = new Box(serialNumber, currentItem, itemsQuantity);

    boxes.Add(currentBox);

    input = Console.ReadLine().Split();
}

foreach (Box box in boxes.OrderByDescending(b => b.PriceOfTheBox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceOfTheBox:F2}");
}



