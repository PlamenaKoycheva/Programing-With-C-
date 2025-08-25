
//Write a program that prints numbers ending in 7 in given range:

//· Reads an integer number n – end of the range

//· Prints all numbers from 7 to n, ending in 7

int num = int.Parse(Console.ReadLine());
for (int i = 7; i <= num; i += 10) 
{
    Console.WriteLine(i);
}