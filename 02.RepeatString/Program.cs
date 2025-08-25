//Write a program that:
//•	Reads an array of strings from the console
//•	Each string is repeated N times, where N is the length of the string
//•	Print the concatenated string

string[] input = Console.ReadLine()
                 .Split(" ");
string result = "";
for (int i = 0; i < input.Length; i++)
{
    string currentText = input[i];
    string concatText = "";
    for (int j = 0; j < currentText.Length; j++)
    {
        concatText += currentText;
    }

    result += concatText;

}
Console.WriteLine(result);