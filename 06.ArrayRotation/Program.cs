//Write a program that:
//•	Reads sequence of integer numbers from the first line of the console
//•	Reads an integer number (rotations you have to perform) from the second line of the console
//•	Each rotation is when the first element goes at the end
//•	Print the resulting sequence


int[] inputArray = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

int rotations = int.Parse(Console.ReadLine());

 for (int i = 0; i < rotations; i++)
{
    int firstElement = inputArray[0];

    for (int j = 1; j < inputArray.Length; j++)
    {
        inputArray[j - 1] = inputArray[j];
    }

    inputArray[inputArray.Length - 1] = firstElement;

}
Console.WriteLine(string.Join(" ", inputArray));