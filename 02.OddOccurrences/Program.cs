//Write a program that extracts all elements from a given
//sequence of words that are present in it an odd number
//of times (case-insensitive):
//•	Words are given on a single line, space-separated.
//•	Print the result elements in lowercase, in their order
//of appearance.

List<string> words = Console.ReadLine()
                     .Split(" ")
                     .Select(w => w.ToLower())
                     .ToList();

Dictionary<string, int> wordCounts = new Dictionary<string, int>();


foreach (string word in words)
{
    if (wordCounts.ContainsKey(word))
    {
        wordCounts[word]++;
    }
    else
    {
        wordCounts[word] = 1;
    }
}


List<string> printedWords = new List<string>();


foreach (string word in words)
{
    if (wordCounts[word] % 2 == 1 && !printedWords.Contains(word))
    {
        Console.Write(word + " ");
        printedWords.Add(word);
    }
}

Console.WriteLine();



