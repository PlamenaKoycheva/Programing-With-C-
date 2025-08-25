//Write a program that:
//•	Reads an integer number N from the console
//•	Create a method for printing triangle depending on value of the number N

int n = int.Parse(Console.ReadLine());

PrintingTriangle1(n);
PrintingTriangle2(n);


static void PrintingTriangle1(int number)
{
    for (int i = 1; i <= number; i++ )
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }
}
static void PrintingTriangle2(int number)
{
    for (int i = number - 1; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }
}