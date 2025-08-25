//Write a program that:
//•	Reads a list of integers from the console and receives commands to manipulate the list
//•	Then until you receive "end", you will receive different commands:
//o   "Delete {element}" – delete all elements in the list, which are equal to the given element
//o	"Insert {element} {position}" – insert the element at the given position
//•	When you receive the "end" command, print the final state of the list (separated by spaces)



List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

string command =  Console.ReadLine();
while (command != "end")
{
    string[] commandParts = command.Split();
    string commandName = commandParts[0];
    if (commandName == "Delete")
    {
        int numberToBeRemoved = int.Parse(commandParts[1]);
        numbers.RemoveAll(number => number == numberToBeRemoved);


    }
    else if (commandName == "Insert")
    {
        int numberToInsert = int.Parse(commandParts[1]);
        int positionToInsert = int.Parse(commandParts[2]);
        numbers.Insert(positionToInsert, numberToInsert);

    }


        command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));