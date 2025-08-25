//Write a program that:
//•	Read an array of integers (from a single line separated with a space)
//•	Calculates the difference between the sum of the even and the sum of the odd numbers in an array
//•	Print the difference

int[] numbers = Console.ReadLine().
    Split(" ")
    .Select(int.Parse)
    .ToArray();
int evenSum = 0;
int oddSum = 0;
foreach(int item in numbers)
{
    if (item % 2 == 0)
    {
        evenSum += item;
    }
    else
    {
        oddSum += item;
    }
   
}
Console.WriteLine(evenSum - oddSum);
