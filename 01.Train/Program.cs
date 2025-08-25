//On the first line, we will receive a list of wagons (integers). Each integer represents the number of passengers that are currently in each wagon of the
//passenger train. On the next line, you will receive the max capacity of a wagon, represented as a single integer. Until you receive the "end" command, you
//will be receiving two types of input:
//•	Add {passengers} – add a wagon to the end of the train with the given number of passengers.
//•	{passengers} – find a single wagon to fit all the incoming passengers (starting from the first wagon).
//In the end, print the final state of the train (all the wagons separated by a space).

List<int> wagoons = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

int maxCapacity = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
while (command != "end")
{
    string[] commandArg = command.Split(" ");

    if (commandArg[0] == "Add")
    {
        int passengersArg = int.Parse(commandArg[1]);
        wagoons.Add(passengersArg);
    }
    else
    {
        int passengersArg = int.Parse(commandArg[0]);
        for (int i = 0; i < wagoons.Count; i++)
        {
            int passengersSeated = wagoons[i];
            if (passengersSeated + passengersArg <= maxCapacity)
            {
                wagoons[i] = passengersSeated + passengersArg;
                break;
            }
        }


    }
        command = Console.ReadLine();

    

   
}
Console.WriteLine(string.Join(" ", wagoons));
