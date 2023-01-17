using System.Text;

// We have a list of integers where elements appear either once or twice. Find the elements that appeared twice in O(n) time.

int[] randomInts = { 1, 2, 3, 4, 7, 9, 2, 4 };
int[] singles = new int[randomInts.Length];
int numDoubles = 0;
StringBuilder intBuilder = new StringBuilder();
for (int i = 0; i < randomInts.Length; i++)
{
    int number = randomInts[i];
    if (!singles.Contains(number))
    {
        singles[i] = number;
    }
    else
    {
        numDoubles++;
        intBuilder.Append($"{randomInts[i]} ");
    }
}
string[] doubles = intBuilder.ToString().Trim().Split(' ');

Console.WriteLine("Duplicated Numbers:");
Console.WriteLine(String.Join(", ", doubles));

// We have two sorted int arrays which could be with different sizes. We need to merge them in a third array while keeping this result array sorted. Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries
// I don't think it's possible because you have to iterate over the number you want to sort, and then iterate over the numbers before it until you find the right place
Console.WriteLine("\nCombining and Sorting 2 int arrays\n");
int[] intArray1 = new int[] { 1, 2, 3, 4, 5 };
int[] intArray2 = new int[] { 2, 5, 7, 9, 13 };

int[] combined = new int[intArray1.Length + intArray2.Length];

Array.Copy(intArray1, combined, intArray1.Length);
Array.Copy(intArray2, 0, combined, intArray1.Length, intArray2.Length);

for (int i = 1; i < combined.Length; i++)
{
    int count = 1;
    int current = combined[i];
    int previous = combined[i - count];
    while (current < previous)
    {
        combined[i - count] = current;
        combined[i - count + 1] = previous;
        count++;
        previous = combined[i - count];
    }
}


foreach (int i in combined)
{
    Console.WriteLine(i);
}

// Given an integer, reverse the digits of that integer, e. g. input is 3415, output is 5143. What is the time complexity of your solution?
// Time Complexity of O(n)

Console.WriteLine("\nReversing a number\n");
Console.WriteLine("\nPlease input a number to be reversed\n");

int x = int.Parse(Console.ReadLine());
while (string.IsNullOrWhiteSpace(x.ToString()))
{
    x =  int.Parse(Console.ReadLine());
}

string str = x.ToString();
StringBuilder sb = new StringBuilder();

for (int i = str.Length - 1;i >= 0; i--)
{
    sb.Append(str[i]);
}

x = int.Parse(sb.ToString());
Console.WriteLine("Reversed: " + x);