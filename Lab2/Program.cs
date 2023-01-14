/*
    
        For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t'].
        For example, the string “To be or not to be” returns ["to","be","or","not"].
        For example, the string "Tiptoe through the tulips" would print "through"
        If there are multiple words tied for greatest length, print the last one
*/

using System.Text;

string testSentence = "the the who what where where why how how";

// A program that produces an array of all of the characters that appear more than once in a string.

Console.WriteLine("\nProducing an array of repeated characters\n");

// A program returns an array of strings that are unique words found in the argument.

Console.WriteLine("\nProducing an array of unique words\n");

string[] allWords = testSentence.Split(' ');
StringBuilder uniqueWords = new StringBuilder();

foreach (string word in allWords)
{
    if (!uniqueWords.ToString().Contains(word))
    {
        uniqueWords.Append(word + ' ');
    }
}

Console.WriteLine(uniqueWords.ToString());


/*
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
*/