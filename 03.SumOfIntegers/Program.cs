using System.Diagnostics.Metrics;
using System.Xml.Linq;

//You will receive a sequence of elements of different types, separated by space. Your task is to calculate the sum of all valid integer numbers in the input.
//Try to add each element of the array to the sum and write messages for the possible exceptions while processing the element:
//•	If you receive an element, which is not in the correct format (FormatException):
//"The element '{element}' is in wrong format!"
//•	If you receive an element, which is out of the integer type range (OverflowException):
//"The element '{element}' is out of range!"
//After each processed element add the following message:
//	"Element '{element}' processed - current sum: {sum}"
//At the end print the total sum of all integers:
//	"The total sum of all integers is: {sum}"

List<int> numbers = new List<int>(); 
string[] input = Console.ReadLine().Split(" ");

foreach(var item in input)
{
    try
    {
        int number = int.Parse(item);
        numbers.Add(number);
    }
    catch(FormatException)
    {
        Console.WriteLine($"The element '{item}' is in wrong format!");

    }
    catch(OverflowException)
    {
        Console.WriteLine($"The element '{item}' is out of range!");

    }
    finally
    {
        Console.WriteLine($"Element '{item}' processed - current sum: {numbers.Sum()}");
    }
}
Console.WriteLine($"The total sum of all integers is: {numbers.Sum()}");