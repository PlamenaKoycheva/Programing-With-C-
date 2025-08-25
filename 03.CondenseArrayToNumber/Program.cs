//Write a program that:
//•	Read a sequence of integer numbers from the console
//•	Condense them by summing adjacent couples of elements until a single integer is obtained
//Example: If we have 3 elements {2, 10, 3}. We sum the first two and the second two elements and obtain  {2+10, 10+3} = { 12, 13}. Then we sum again all adjacent elements and obtain {12+13} = { 25}.

int[] inputArray = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();



while (inputArray.Length > 1)
{
    int[] condensedArray = new int[inputArray.Length - 1];

    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        condensedArray[i] = inputArray[i] + inputArray[i + 1];

    }

    inputArray = condensedArray;

}

Console.WriteLine(inputArray[0]);

