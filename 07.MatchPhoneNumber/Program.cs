//Write a program that:
//•	Reads a text from the console
//•	Create a regular expression to match a valid phone number from Sofia
//•	A valid number has the following characteristics:
//o It starts with "+359"
//o	Then, it is followed by the area code (always 2)
//o	After that, it's followed by the number itself:
//o	The number consists of 7 digits (separated into two groups of 3 and 4 digits respectively) 
//o	The different parts are separated by either a space or a hyphen ('-')
//•	Print all valid numbers on the console, separated by a comma and a space ", "

using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
MatchCollection validNumber = Regex.Matches(text, pattern);
List<string> result = new List<string>();

foreach (Match phoneNumber in validNumber)
{
    result.Add(phoneNumber.Value);
}

Console.WriteLine(string.Join(", ", result));