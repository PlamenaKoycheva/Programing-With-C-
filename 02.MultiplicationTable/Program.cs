
//Write a program that prints a multiplication table:
//•	Reads an integer number n from the console
//•	Print a multiplication table of size 10 for given integer n in the following format:
//              "{n} x {i} = {result}" for each i in the range[1…10]

int num = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 1; i <= 10; i++)
{
     result = num * i;
    
    Console.WriteLine($"{num} x {i} = {result}");
    
}
