//Write a program that:
//•	Read two integer arrays with the same length from the console
//•	Prints common elements in two arrays, space-separated


int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i < arr1.Length; i++)
{
    for ( int x = 0; x < arr2.Length; x++)
    {

        if (arr1[i] == arr2[x])
        {
            Console.Write(arr1[i] + " ");
        }
        
    }
}