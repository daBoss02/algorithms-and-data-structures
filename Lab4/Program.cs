/*
    List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a List of Lists of Integers. 
    It returns a new list with each element representing the maximum number found in the corresponding original list. 

        For example, { {1, 5, 3}, {9, 7, 3, -2}, {2, 1, 2} } returns {5, 9, 2}.
        Output the results with a message like: “List 1 has a maximum of 5. List 2 has a maximum of 9. List 3 has a maximum of 2.”
*/

Console.WriteLine("Getting the maximums");

List<List<int>> numsList = new List<List<int>>();

numsList.Add(new List<int>() { 1, 5, 3 });
numsList.Add(new List<int>() { 9, 7, 3, -2 });
numsList.Add(new List<int>() { 2, 1, 2 });

List<int> MaxNumbersInLists(List<List<int>> numLists)
{
    // O(n)^2
    List<int> maxNums = new List<int>();
    for (int i = 0; i < numLists.Count; i++)
    {
        int maxNum = 0;
        foreach (int num in numLists[i])
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        maxNums.Add(maxNum);
    }
    return maxNums;
}

List<int> maxes = MaxNumbersInLists(numsList);

for (int i = 0; i < maxes.Count; i++)
{
    Console.WriteLine($"List {i + 1} has a maximum of {maxes[i]}.");
}

/*
    String HighestGrade(List<List<int>>) accepts a list of number grades among students in different courses (where each list represents a single course), between 0 and 100. It returns the highest grade among all students in all courses.

        For example: { {85,92, 67, 94, 94}, {50, 60, 57, 95}, {95} } returns "The highest grade is 95. This grade was found in class(es) {index}".
*/

Console.WriteLine("Finding the Highest Grade");
List<List<int>> grades = new List<List<int>>() ;
grades.Add(new List<int> { 85, 92, 67, 94, 94 });
grades.Add(new List<int> { 50, 60, 57, 95 });
grades.Add(new List<int> { 95 });
String HighestGrade(List<List<int>> gradesList)
{
    List<int> courses = new List<int>();
    int highestGrade = 0;
    for (int i = 0; i < gradesList.Count; i++)
    {
        foreach (int num in gradesList[i])
        {
            if (num > highestGrade)
            {
                highestGrade = num;
                courses.Clear();
                courses.Add(i);
            } else if (num == highestGrade)
            {
                courses.Add(i);
            }
        }
    }
    return $"The highest grade is {highestGrade}. This grade was found in class(es) {string.Join(", ", courses)}";
}


Console.WriteLine(HighestGrade(grades));
/*
    List<int> OrderByLooping (List<int>) orders a list of integers, from least to greatest, using only basic control statements (ie. if/else, for/while).

        For example, argument {6, -2, 5, 3} returns {-2, 3, 5, 6}.
*/

List<int> randomNums = new List<int>() { 47, -98, -12, 13, 2, 10 };

List<int> OrderByLooping(List<int> intList)
{
    for (int i = 1; i < intList.Count; i++)
    {
        int previous = intList[i - 1];
        int current = intList[i];
        int count = 1;

            Console.WriteLine(current < previous);
        while (current < previous)
        {
            Console.WriteLine(current);
            Console.WriteLine(previous);
            intList[i - count] = current;
            intList[i - count + 1] = previous;
            count++;
            if (i - count < 0)
            {
                break;
            }
                previous = intList[i - count];
        }

    }
    return intList;
}

Console.WriteLine(string.Join(", ", OrderByLooping(randomNums)));