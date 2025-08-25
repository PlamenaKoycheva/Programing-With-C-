
//Write a program to print a countdown to an exam:

//· Read an integer number d: the count of days before an exam

//· For each day d…1 print: "{currentDay} days before the exam"

//· At the end print: "The exam has come"

int num = int.Parse(Console.ReadLine());
for  (int i = num; i >= 1; i--)
{

    
        Console.WriteLine($"{i} days before the exam");

    
}
Console.WriteLine("The exam has come");