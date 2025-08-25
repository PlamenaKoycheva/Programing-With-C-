//Write a program to find statistics about division to 2, 3 and 4:
//•	Read an integer number N and N integers from the console
//•	Find in percentages how many of these integers can divide without a remainder to numbers 2, 3 and 4
//•	Print the percentages, formatted to the second decimal digit:
//o On the first line print percent of the numbers that are divisible by 2
//o	On the first line print percent of the numbers that are divisible by 3
//o	On the first line print percent of the numbers that are divisible by 4

int countNum = int.Parse(Console.ReadLine());
int countDivisible2 = 0;
int countDivisible3 = 0;
int countDivisible4 = 0;

for (int i = 0; i <countNum; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number % 2 == 0)
    {
        countDivisible2++;

    }
    if (number % 3 == 0)
    {
        countDivisible3++;
    }
     if (number % 4 == 0)
    {
        countDivisible4++;
    }
}
double precentDivisible2 = (countDivisible2 * 1.0/ countNum) * 100;
double precentDivisible3 = (countDivisible3 * 1.0 / countNum) * 100;
double precentDivisible4 = (countDivisible4 * 1.0 / countNum) * 100;
Console.WriteLine($"{precentDivisible2:F2}%");
Console.WriteLine($"{precentDivisible3:F2}%");
Console.WriteLine($"{precentDivisible4:F2}%");
