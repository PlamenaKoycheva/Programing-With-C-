//Write a program that:
//•	Reads a text from the console
//•	Create a regular expression to match a valid dates
//•	Every valid date has the following characteristics:
//o Format: "dd{separator}MMM{separator}yyyy"
//o Always starts with two digits, followed by a separator
//o	After that, it has one uppercase and two lowercase letters (e.g. Jan, Mar)
//o	After that, it has a separator and exactly 4 digits (for the year)
//o	The separator could be either of three things: a period('.'), a hyphen('-') or a forward-slash ('/')
//o	The separator needs to be the same for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is NOT). Use a group backreference to check for this
//•	Use named capturing groups in your regular expression.
//•	Print all valid dates on the console, separated by a new line
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

string text = Console.ReadLine();
string pattern = @"\b(?<day>\d{2})(?<separator>[-.\/])(?<month>[A-Z][a-z]{2})\<separator>(?<year>\d{4})\b";



MatchCollection dates = Regex.Matches(text, pattern);
foreach (Match date in dates)
{
    string day = date.Groups["day"].Value;
    string month = date.Groups["month"].Value;
    string year = date.Groups["year"].Value;
    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}
