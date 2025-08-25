//Write a program that:
//•	Reads sequence of integer numbers from the first line of the console
//•	Find all the top integers in a sequence
//•	Top integer is an integer that is bigger than all the elements to its right

int[] inputArray = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();
for (int i = 0; i < inputArray.Length; i++)
{
    int currentElement = inputArray[i];
    bool isBigger = true;

    for (int j = i + 1; j < inputArray.Length; j++)
    {
        int nextRightElement = inputArray[j];

        if (currentElement <= nextRightElement)
        {
            isBigger = false;
            break;
        }
    }

    if (isBigger)
    {
        Console.Write(currentElement + " ");
    }
} 