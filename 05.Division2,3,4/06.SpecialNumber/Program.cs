
//Write a program to check if given number is special: 
//•	Special numbers are divisible by all of their digits without remainder
//•	Reads an integer number and check whether it is a special number
//•	If the number IS special print: "{num} is special"
//•	If the number is NOT special print: "{num} is not special"
//Note: There will not be numbers with digit 0 in them.
int number = int.Parse(Console.ReadLine());
int startNumber = number;
bool isSpecial = true;
while (number > 0)
{
    int lastDigit = number % 10;

    if (startNumber % lastDigit != 0)
    {
        isSpecial = false;
        break;
    }
    number = number / 10;
}



if (isSpecial == true)
{
    Console.WriteLine($"{startNumber} is special");
}
else
{
    Console.WriteLine($"{startNumber} is not special");
}