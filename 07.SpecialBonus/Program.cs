//Write a program to apply a 20% bonus for certain number: 
//•	Reads an integer number from the console: the "stop number"
//•	Keep reading integers until it finds the stop number
//•	When the stop number is found, increase the value of the previous number before it with 20% and print it

int stopNum = int.Parse(Console.ReadLine());
int enteredNum = int.Parse(Console.ReadLine());
int prevoiousNum = 0;

while(enteredNum != stopNum)
{
    prevoiousNum = enteredNum;
    enteredNum = int.Parse(Console.ReadLine());
    

}
Console.WriteLine(prevoiousNum * 1.2);