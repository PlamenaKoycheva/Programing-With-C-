//Write a program to find the biggest among given n numbers:
//•	Read an integer number n (the amount of input numbers) and n integer numbers from the console
//•	Find and print the biggest number

int countn = int.Parse(Console.ReadLine());
int maxNumber = int.MinValue;
for (int i = 1; i <= countn; i++)
{
      int n = int.Parse(Console.ReadLine());
    if (n > maxNumber)
    {
        maxNumber = n;
    }
    
    
}
Console.WriteLine(maxNumber);
