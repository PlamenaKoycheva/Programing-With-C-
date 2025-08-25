//Write a program to sum the digits of given number:
//•	Read an integer positive number from the console
//•	Sum its digits and print the sum
//Example: The number is 3451. Digits sum is 3 + 4 + 5 + 1 = 13.


int num = int.Parse(Console.ReadLine());
int sum = 0;
while (num > 0)
{
    int lastDigit = num % 10;
    sum += lastDigit;
    num /= 10;
}
Console.WriteLine(sum);