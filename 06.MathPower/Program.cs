

//Write a program that:
//•	Reads two integer numbers from the console: base number and power
//•	Create a method, which receives two numbers as parameters:
//o The first number – the base
//o	The second number – the power
//•	The method should return the base raised to the given power

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(MathPower(num1, num2));

static int MathPower (int baseNum, int powerNum)
{
    int result = (int)Math.Pow(baseNum, powerNum);
    return result;
}