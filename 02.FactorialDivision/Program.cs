//Write a program that:
//•	Read two integers numbers from the console in range [1…10]
//•	Calculate the factorial of each number
//•	Divide the first calculated factorial by the second calculated factorial (integer division)
//•	Print the result of the division


int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int factNum1 = CalculateNumber(num1);
int factNum2 = CalculateNumber(num2);
int result = factNum1 / factNum2;
Console.WriteLine(result);



static int CalculateNumber(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact *= i;
    }
    return fact;

   
}


