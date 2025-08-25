//Write a program that:
//•	Reads a type (string) and two values of this type from the console
//•	Entered type can be one of the following values: "int", "char" or "string"
//•	Create methods which can compare int, char or string
//•	Return the biggest of the two values





string type = Console.ReadLine();
string firstValue = Console.ReadLine();
string secondValue = Console.ReadLine();


CompareValues(type,firstValue, secondValue);

static void CompareValues(string type,string firstValue, string secondValue)
{
    if (type == "int")
    {
        int a = int.Parse(firstValue);
        int b = int.Parse(secondValue);
        Console.WriteLine(CompareTwoValues(a, b));
    }
    else if (type =="char")
    {
        char a = char.Parse(firstValue);
        char b = char.Parse(secondValue);
       Console.WriteLine(CompareTwoChars(a, b));
    }
    else if (type == "string")
    {
        Console.WriteLine(CompareTwoString(firstValue,secondValue));
       
    }
}

static string CompareTwoString(string firstString, string secondString)
{
    int result = firstString.CompareTo(secondString);
    if (result > 1)
    {
        return firstString;
    }
    else
    {
        return secondString;
    }
}

static char CompareTwoChars(char a, char b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

static int CompareTwoValues(int a, int b)
{
   if (a > b)
    {
        return a;
    }
   else
    {
        return b;
    }
}