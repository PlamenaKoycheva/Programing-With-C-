//Create a program that takes a text and a string of banned words. All words included in the ban list should be replaced with a string of
//asterisks '*', whose length must be equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
//The ban list should be entered on the first input line and the text on the second input line. 

string[] bannedWords = Console.ReadLine()
                       .Split(", ");
string textToEdit = Console.ReadLine();

foreach (var wordToReplace in bannedWords)
{
    string asterixWord = "";
    for (int i = 0; i <  wordToReplace.Length; i++)
    {
        asterixWord += '*';
    }
    textToEdit = textToEdit.Replace(wordToReplace, asterixWord);
}
Console.WriteLine(textToEdit);