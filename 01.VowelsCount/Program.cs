//Write a program that:
//•	Read a text (string) from the console
//•	Create a method that receives a text
//•	Find the count of the vowels contained in the text
//•	Print the count of the vowels in the text


string text = Console.ReadLine();

Console.WriteLine(CountVowels(text));

static int CountVowels(string text)
{
    
    int vowelsCount = 0;
    for (int position = 0; position <= text.Length - 1; position++)
    {
        char currentSymbol = text[position];
        if (currentSymbol == 'A' || currentSymbol == 'a' || currentSymbol == 'E' || currentSymbol == 'e' || currentSymbol == 'O' || currentSymbol == 'o' || currentSymbol == 'I' || currentSymbol == 'i' || currentSymbol == 'U' || currentSymbol == 'u')
        {
            vowelsCount++;
        }
    }
    return vowelsCount;
}