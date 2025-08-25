//Write a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
//•	Read an integer number from the console
//•	Create a method called GetMultipleOfEvenAndOdds()
//•	Create a method GetSumOfEvenDigits()
//•	Create GetSumOfOddDigits()
//•	You may need to use Math.Abs() for negative numbers


int number = Math.Abs(int.Parse(Console.ReadLine()));


Console.WriteLine(GetMultipleOfEvenAndOdds(number));

static int GetSumOfEvenDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 == 0)
        {
            sum += lastDigit;
        }
        number /= 10;
    }
    return sum;
}
static int GetSumOfOddDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 != 0)
        {
            sum += lastDigit;
        }
        number /= 10;
    }
    return sum;

}
static  int GetMultipleOfEvenAndOdds(int number)
{
    return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

}

