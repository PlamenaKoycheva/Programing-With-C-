
//Write a program that:
//•	Read a sequence of integer numbers from the first line of the console
//•	Read an integer number (control number) from the second line of the console
//•	Print all unique pairs in an array of integers whose sum is equal to a control number


int[] inputArray = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

int controlNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < inputArray.Length - 1; i++)
{

    int leftElement = inputArray[i];
    for (int j = i + 1; j < inputArray.Length; j++)
    {
        int rightElement = inputArray[j];
        int sum = leftElement + rightElement;
        if (sum == controlNumber)
        {
            Console.WriteLine($"{leftElement} {rightElement}");
        }
    }
    

   
}