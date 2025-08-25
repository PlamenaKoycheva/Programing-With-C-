//Write a program that:
//•	Read first string from the first line of the console
//•	Reads second string from the second line of the console
//•	Remove all of the occurrences of the first string in the second string
//•	Print the remaining string
  
string firstString =Console.ReadLine();
string secondtString =Console.ReadLine();
while (secondtString.Contains(firstString))
{
    int startIndex = secondtString.IndexOf(firstString);
    int length = firstString.Length;
    secondtString = secondtString.Remove(startIndex, length);
}
Console.WriteLine(secondtString);