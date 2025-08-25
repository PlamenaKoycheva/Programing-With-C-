
//Write a program that:
//•	Reads three integer numbers (num1, num2 and num3) from the console
//•	 Finds if num1 * num2 * num3 (the product) is negative, positive or zero
//•	Print:
//o negative - if the product is smaller than 0 
//o	positive - if the product is bigger than 0
//o	zero - if the product is equals to 0


int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

PrintNumberType(num1, num2, num3);

 static void PrintNumberType(int num1, int num2, int num3)
{
    int result = num1 * num2 * num3;
    
    if (result == 0)
    {
        Console.WriteLine("zero");
    }
    else if (result < 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("positive");
    }
}