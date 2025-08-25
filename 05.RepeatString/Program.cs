//Write a program that:
//•	Reads a text (string) and repeat count (integer number) from the console
//•	Write a method that receives a string and a repeat count 
//•	The method should return a new string, containing the initial one, repeated count times without space


string text = Console.ReadLine();
int repeatCount = int.Parse(Console.ReadLine());

 
Console.WriteLine(RepeatString(text, repeatCount));

static string RepeatString(string txt, int count)
{
    string result = "";
    for (int i = 0; i < count; i++)
    {
        result += txt;
    }
    return result;
}
