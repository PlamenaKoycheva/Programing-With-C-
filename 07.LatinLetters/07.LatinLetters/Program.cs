//Write a program to print the Latin letters in certain range:

//· Read two letters (chars), each on separate line

//· Print all letters in the specified range inclusively

char letter1 = char.Parse(Console.ReadLine());
char letter2 = char.Parse(Console.ReadLine());
for (char i = letter1; i <= letter2; i++)
{
    Console.Write(i + " ");
}