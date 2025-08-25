
//Write a program that:
//•	Continuously read integers until "End" is entered from the console
//o	Print the sum of digits for each integer, use the following format: 
//"Sum of digits = {sum}"
//•	Finally, print "Goodbye"

string command = Console.ReadLine();
while (command != "End")
{
    int num = int.Parse(command);
    int sum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        sum += lastDigit;
        num /= 10;
        
    }
    Console.WriteLine($"Sum of digits = {sum}");

    command = Console.ReadLine();
}
Console.WriteLine("Goodbye");
