

//Write a program that: 
//•	Reads a list of integers
//•	Then until you receive "end", you will receive different commands:
//o   "Add {number}": add a number to the end of the list
//o	"Remove {number}": remove a number from the list
//o	"RemoveAt {index}": remove a number at a given index
//o	"Insert {number} {index}": insert a number at a given index
//•	When you receive the "end" command, print the final state of the list (separated by spaces)
//Note: All the indices will be valid!


List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

string command  = Console.ReadLine();

while (command != "end")
{
    string[] commandArg = command.Split(" ");
    string input = commandArg[0];
    if (input == "Add")
    {
        int number = int.Parse(commandArg[1]);
        numbers.Add(number);
    }
    else if (input == "Remove")
    {
        int number = int.Parse(commandArg[1]);
        numbers.Remove(number);
    }
    else if (input == "RemoveAt")
    {
        int index = int.Parse(commandArg[1]);
        numbers.RemoveAt(index);
    }
    else if (input == "Insert")
    {
        int number = int.Parse(commandArg[1]);
        int index = int.Parse(commandArg[2]);
        numbers.Insert(index, number);
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));