using System.Text;

string testSentence = "Programmatic Python";

// A program that produces an array of all of the characters that appear more than once in a string.

Console.WriteLine("\nProducing an array of repeated characters\n");

string input = testSentence;
StringBuilder repeatedChars = new StringBuilder();
for (int i = 0; i < input.Length; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[i] == input[j] && !repeatedChars.ToString().Contains(input[i]))
        {
            repeatedChars.Append(input[i]);
        }
    }
}

string repeatedString = repeatedChars.ToString();
foreach (char c in repeatedString)
{
    if (repeatedString.IndexOf(c) == repeatedString.Length - 1)
    {
        Console.WriteLine($"'{c}']");
    } else if (repeatedString.IndexOf(c) == 0)
    {
        Console.Write($"['{c}', ");
    } else
    {
        Console.Write($"'{c}', ");
    }
}

// A program returns an array of strings that are unique words found in the argument.

Console.WriteLine("\nProducing an array of unique words\n");

Console.WriteLine("Please input a phrase");
string[] allWords = Console.ReadLine().Split(' ');
StringBuilder uniqueWords = new StringBuilder();

foreach (string word in allWords)
{
    if (!uniqueWords.ToString().Contains(word))
    {
        uniqueWords.Append(word + ' ');
    }
}

Console.WriteLine(uniqueWords.ToString());

// A program that reverses a provided string

Console.WriteLine("\nReversing a string\n");

Console.WriteLine("Please input a phrase");
string nonReversed = Console.ReadLine();
char[] reversed = new char[nonReversed.Length];
for (int i = reversed.Length - 1;i >= 0; i--)
{
    int newIndex = reversed.Length - 1 - i;
    reversed[newIndex] = nonReversed[i];
}


Console.WriteLine("\nReversed:\n" + string.Join("", reversed));

// A program that finds the longest unbroken word in a string and prints it

Console.WriteLine("\nFinding the longest unbroken word in a sentence\n");

Console.WriteLine("Please input a phrase");
string[] wordArray = Console.ReadLine().Split(' ');

string longestWord = "";

foreach (string word in wordArray)
{
    if (word.Length >= longestWord.Length)
    {
        longestWord = word;
    }
}

Console.WriteLine($"\n{longestWord} is the longest word in this text");