//Write a program that:
//•	Read two arrays with the same length from the console
//•	Check whether they are identical or not
//o	If the arrays are identical, print: "Arrays are identical."
//o If the arrays are NOT identical, print: "Arrays are not identical."
//Note: Arrays are identical if their elements are equal. 

int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
bool isIdentical = true;
for (int i = 0; i < arr1.Length; i++)
{
  
        if (arr1[i] != arr2[i] )
        {
            isIdentical = false;
        break;
           
        }
       
}
if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}