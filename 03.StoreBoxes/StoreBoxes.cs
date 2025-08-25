using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Item
{

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public double Price { get; set; }
}

class Box
{
    public Box(string serialNumber, Item item, int quantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = quantity;
    }

    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public double PriceOfTheBox => ItemQuantity * Item.Price;
}



