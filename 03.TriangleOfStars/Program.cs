//Write a program to print a triangle of stars like shown in the examples:
//•	Read the size (integer number) of a triangle from the console
//•	Print a triangle of stars

int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    for (int j = 1; j <= i; j++ )
    {
        Console.Write('*');
    }
    Console.WriteLine();
}

