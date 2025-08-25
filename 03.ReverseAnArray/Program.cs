//Write a program that:
//•	Read an integer number N from the console
//•	After that read N integer numbers from the console, each on separate line
//•	Store the numbers in the array of integers
//•	Reverse the numbers in the array
//•	Print elements of the array on a single line, space-separated

int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());

}
for (int j = numbers.Length - 1; j >= 0; j--)
{
    Console.Write(numbers[j] + " ");
}