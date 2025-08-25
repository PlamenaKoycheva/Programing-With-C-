//Write a program that:
//•	Reads a sequence of integer numbers from the first line of the console
//•	Read a special bomb number (integer) and its power (integer) from the second line of the console
//•	Detonate every occurrence of the special bomb number and according to its power - his neighbors from left and right
//•	 Detonations are performed from left to right, and all detonated numbers disappear
//•	Print the sum of the remaining elements in the sequence


List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

int[] bombAndPower = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

int bombNumber = bombAndPower[0];
int bombPower = bombAndPower[1];

while (numbers.Contains(bombNumber))
{
    int bombIndex = numbers.IndexOf(bombNumber);

    int startIndex = bombIndex - bombPower;
    int count = bombPower * 2 + 1;

    if (startIndex < 0)
    {

        count += startIndex;
        startIndex = 0;
    }
        
    if (bombIndex + bombPower > numbers.Count)
    {
        int indexToRemove = bombIndex + bombPower - numbers.Count + 1;
        count -= indexToRemove;
    }
    

    numbers.RemoveRange(startIndex, count);


}

Console.WriteLine(numbers.Sum());