//Write a program that:
//•	Reads an integer number n from the console 
//•	Prints a pyramid of numbers as shown in the examples


int num = int.Parse(Console.ReadLine());
int counter = 0;
for (int row = 1; row <= num; row++)
{
    for (int col = 1; col <= row;col++)
    {
        counter++;
        Console.Write($"{counter} ");
        if (counter == num)
        {
            break;
        }
    }
    if (counter == num)
    {
        break;
    }
    Console.WriteLine();

}
