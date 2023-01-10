
Console.WriteLine("Please enter a number:");

int length = int.Parse(Console.ReadLine());

while (length <= 0)
{
	Console.WriteLine("Please input a positive number:");
	length = int.Parse(Console.ReadLine());
}

string[] words = new string[length];

Console.WriteLine("Please enter " + length.ToString() + " word(s): ");

for (int i = 0; i < length; i++)
{
    Console.Write($"{i + 1}: ");
    words[i] = Console.ReadLine();
    while (words[i].Length < 1 || words[i].Contains(' '))
	{
    	Console.WriteLine("Word must be at least one character");
    	words[i] = Console.ReadLine();
	}
}

Console.Write("Please enter a character: ");
char character = Console.ReadKey().KeyChar;
Console.WriteLine();
bool isLetter = Char.IsLetter(character);

while (!isLetter)
{
    Console.WriteLine("Character must be a letter");
    character = Console.ReadKey().KeyChar;
    Console.WriteLine();
    isLetter = Char.IsLetter(character);
}
int chosenCharCount = 0;
int totalChars = 0;

foreach (string word in words)
{
    string newWord = word.ToLower();
    string chosenLetter = character.ToString().ToLower();
    foreach (char letter in newWord)
    {
        totalChars++;
        if (chosenLetter == letter.ToString())
        {
            chosenCharCount++;
        }
    }
}

double percent = (double)chosenCharCount / (double)totalChars * (double)100;

Console.WriteLine();

Console.Write("The letter " + " '" + character.ToString() + "' appears " + chosenCharCount.ToString() + " times in this array. ");

if (percent > 25)
{
    Console.WriteLine("This letter makes up more than 25% of the total number of characters.");
}
