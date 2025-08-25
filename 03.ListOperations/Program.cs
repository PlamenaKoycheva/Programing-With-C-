

//The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.
//The possible commands are:
//•	Add {number} – add the given number to the end of the list
//•	Insert {number} { index} – insert the number at the given index
//•	Remove {index} – remove the number at the given index
//•	Shift left {count} – first number becomes last. This has to be repeated the specified number of times
//•	Shift right {count} – last number becomes first. To be repeated the specified number of times
//Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".

List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

string command = Console.ReadLine();
while (command != "End")
{
    string[] commandArg = command.Split(" ");
    string input = commandArg[0];
    if (input == "Add")
    {
        int numberInput = int.Parse(commandArg[1]);
        numbers.Add(numberInput);
    }
    else if(input == "Insert")
    {
        int numberInput = int.Parse(commandArg[1]);
        int index = int.Parse(commandArg[2]);

        if (index >= 0 && index < numbers.Count)
        numbers.Insert(index, numberInput);
        else
        {
            Console.WriteLine("Invalid index");
            
        }
    }
    else if (input == "Remove")
    {
        int index = int.Parse(commandArg[1]);
        if (index >= 0 && index < numbers.Count)
            numbers.RemoveAt(index);
        else
        {
            Console.WriteLine("Invalid index");
            
        }
    }
    else if (input == "Shift")
    {
        string inputArg = commandArg[1];
        int count = int.Parse(commandArg[2]);
        if (inputArg == "left")
        {
            for (int i = 0; i < count; i++)
            {
                int firstElement = numbers[0];
                numbers.Add(firstElement);
                numbers.RemoveAt(0);
            }
        }
        else if(inputArg == "right")
        {
            for (int i = 0; i < count; i++)
            {
                int lastElement = numbers[numbers.Count - 1];
                numbers.Insert(0, lastElement);
                numbers.RemoveAt(numbers.Count - 1);
            }

        }
    }

        command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));