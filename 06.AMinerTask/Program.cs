using System.Resources;

//You will be given a sequence of strings, each on a new line. Every odd line on the console is representing
//a resource (e.g. Gold, Silver, Copper and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line.
//Print the resources and their quantities in the following format:
//"{resource} –> {quantity}"
//The quantities will be in the range [1… 2 000000000].


Dictionary<string, long> resourceList = new Dictionary<string, long>();
string resource = Console.ReadLine();
while (resource != "stop")
{
    
    long quantity = long.Parse(Console.ReadLine());

    if (resourceList.ContainsKey(resource))
    {
        resourceList[resource] += quantity;
    }
    else
    {
        resourceList[resource] = quantity;
    }
    resource = Console.ReadLine();
}

foreach (KeyValuePair<string, long> pair in resourceList)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
    