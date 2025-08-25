int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());

for (int i = startNum; i <= endNum; i++)
{
    int counter = 0;
    bool isPrime = true;
    for (int n = 1; n <= i; n++)
    {
        if (i % n == 0)
        {
            counter++;
        }
    }
    if (counter > 2)
    
        isPrime = false;
    if (isPrime)
    Console.Write($"{i} ");
    
}
