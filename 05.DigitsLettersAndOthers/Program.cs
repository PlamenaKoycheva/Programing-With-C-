//Write a program that:
//•	Read a single string from the console
//•	Print all the digits on the first line
//•	Print all the letters on the second line
//•	Print all the other characters on the third line
//Note: There will always be at least one digit, one letter and one other character.

using System.Text;

string input = Console.ReadLine();
string letters = "";
string digits = "";
string specialCaracters = "";
foreach (char symbol in input)
{
    if (char.IsLetter(symbol))
    {
        letters += symbol;
    }
    else if (char.IsDigit(symbol))
    {
        digits += symbol;
    }
    else
    {
        specialCaracters += symbol;
    }
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(specialCaracters);