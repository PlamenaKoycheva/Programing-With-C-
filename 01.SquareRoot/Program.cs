//Write a program that reads an integer number and calculates and prints its square root. 
//•	If the number is negative, print "Invalid number."
//•	In all cases finally, print "Goodbye."
//Use try-catch-finally.

int number = int.Parse(Console.ReadLine());

try
{
    if (number < 0)
    {
        throw new ArgumentException("Invalid number.");
    }

    double sqrt = Math.Sqrt(number);
    Console.WriteLine(sqrt);

}

catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Goodbye.");
}