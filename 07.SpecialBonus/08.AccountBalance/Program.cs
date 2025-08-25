
//Write a program to calculate an account balance:
//•	Read a sequence of incomes / expenses, until "End" is read
//•	Add the money to the balance (starting form 0)
//•	Print "Increase: {money}" or "Decrease: {money}", where value is formatted to the second decimal digit
//•	Finally, print the account balance, formatted to the second decimal digit in the following format: "Balance: {account balance}"

string command = Console.ReadLine();
double balance = 0;
while (command != "End")
{
    double money = double.Parse(command);
    
    if (money > 0)
    {
        balance += money;
        Console.WriteLine($"Increase: {money:F2}");
    }
    else if (money < 0)
    {
        balance += money;
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
    }
        command = Console.ReadLine();
}
Console.WriteLine($"Balance: {balance:F2}");
