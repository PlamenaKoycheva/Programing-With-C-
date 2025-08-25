//Write a program that:
//•	Read an array of strings
//•	Take only words, whose length is an even number
//•	Print each word on a new line

string[] words = Console.ReadLine()
                 .Split()
                 .Where(word => word.Length % 2  == 0)  
                 .ToArray();

foreach(string word in words)
{
    Console.WriteLine(word);
}