//Write a program that:
//•	Reads an integer number N
//•	Print the numbers from N down to 1 (inclusively), each on separate line
//Note: N will always be bigger than 1.
int num = int.Parse(Console.ReadLine());
while (num >= 1)
{
    Console.WriteLine(num);
    num--;
}
