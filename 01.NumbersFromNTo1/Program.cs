
//Write a program that:
//•	Reads an integer number N from the console
//•	Prints the numbers from N to 1, each on separate line



int num = int.Parse(Console.ReadLine());
for (int i = num; i>= 1; i--)
{
    Console.WriteLine(i);
}
