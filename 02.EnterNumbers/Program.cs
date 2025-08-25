//Write a method ReadNumber(int start, int end) that enters an integer number in a given range (start…end), excluding the numbers start and end. If an invalid number
//or a non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, … a10,
//such that 1 < a1 < … < a10 < 100. If the user enters an invalid number, continue while there are 10 valid numbers entered. Print the array elements,
//separated with comma and space ", ".
//Hints
//•	When the entered input holds a non-integer value, print: "Invalid Number!"
//•	When the entered input holds an integer that is out of range, print: 
//"Your number is not in range {currentNumber} - 100!"

List<int> tenNumbers = new List<int>();
int start = 1;
while (tenNumbers.Count < 10)
{
    try
    {
        int currentNumber = ReadNumber(start, 100);
        tenNumbers.Add(currentNumber);
        start = currentNumber;
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine($"Your number is not in range {start} - 100!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }
    
}
Console.WriteLine(string.Join(", ", tenNumbers));



int ReadNumber(int start, int end)
{

    int number = int.Parse(Console.ReadLine());
    if (number <= start || number >= end)
    {
        throw new ArgumentOutOfRangeException();
    }
    return number;
}