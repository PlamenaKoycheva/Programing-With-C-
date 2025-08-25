//Write a program that:
//•	Reads a text from the console
//•	Match full names from the given text
//•	A valid full name has the following characteristics:
//o It consists of two words
//o	Each word starts with a capital letter
//o	After the first letter, it only contains lowercase letters afterward
//o	Each of the two words should be at least two letters long
//o	The two words are separated by a single space
//•	Print full names on the console, separated by single space

using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
MatchCollection names = Regex.Matches(text, pattern);

foreach (var name in names)
{
    Console.Write(name + " ");
}