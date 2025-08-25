//Write a program that:
//•	Reads a series of strings from the console, until you receive an "end" command
//•	Reverse given strings
//•	Print each pair (old text and reversed text) on a separate line in the format:
// "{word} = {reversed word}"

using System.Globalization;

string command = Console.ReadLine();

while(command != "end")
{
    string result = "";

    for (int i = command.Length - 1;  i >= 0; i--)
    {
        result += command[i];
        
    }
    Console.WriteLine($"{command} = {result}");
    

    command = Console.ReadLine();
}
