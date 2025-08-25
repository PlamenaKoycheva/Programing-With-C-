//Write a program that:
//•	Read an array of integers (from a single line separated with a space)
//•	Print the sum of all elements in the given array

int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);