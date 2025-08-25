

//Write a program that:
//•	Reads an integer number n from the console 
//•	Prints on the console the number two on even powers in the range [0; n] 
//2 ≤ 2n: 20, 22, 24, 26, …, 2n.

int num = int.Parse(Console.ReadLine());

for(int i = 0; i<= num; i += 2)
{
    Console.WriteLine(Math.Pow(2, i));
}
