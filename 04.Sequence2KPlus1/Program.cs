//Write a program to print a sequence of numbers:
//•	The first number is 1
//•	Each next number is 2 times the previous number + 1
//•	Read an integer number n from the console – the max number
//•	Print the elements of the sequence (starting with 1), which are ≤ n

int range = int.Parse(Console.ReadLine());
int number = 1;
while (number <= range)
{
    Console.WriteLine(number);
    number = number * 2 + 1;
}