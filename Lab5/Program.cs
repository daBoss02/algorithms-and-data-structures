/*
Using Stacks and Queues where appropriate, create a simple command line
playlist app that allows a user to add a song to a playlist. Provide
commands to play the next song, skip the upcoming song, or add a new song
to the playlist. Users should be able to rewind by one song many times
to play a previous track.
*/

bool isExit(int num)
{
    if (num == 5)
    {
        return false;
    }
    return true;
}

Console.WriteLine("Please select an option:");
Console.WriteLine("1: Add song to playlist");
Console.WriteLine("2: Play the next song in your playlist");
Console.WriteLine("3: Skip the next song");
Console.WriteLine("4: Rewind one song");
Console.WriteLine("5: Exit");

Queue<string> playlist = new Queue<string>();
Stack<string> rewind = new Stack<string>();
Stack<string> played = new Stack<string>();
string userInp = Console.ReadLine();
bool blank = string.IsNullOrWhiteSpace(userInp);
int numInp;
bool isNumber = int.TryParse(userInp, out numInp);
bool continueRunning = true;
while (blank || !isNumber || numInp < 1 || numInp > 5)
{
    Console.WriteLine("Please input a valid choice");
    userInp = Console.ReadLine();
    blank = string.IsNullOrWhiteSpace(userInp);
    isNumber = int.TryParse(userInp, out numInp);
}

while (continueRunning)
{
    switch (numInp)
    {
        case 1:
            Console.Write("Enter Song Name: ");
            string songName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(songName))
            {
                Console.Write("Please enter a song name:");
                songName = Console.ReadLine();
            }
            playlist.Enqueue(songName);
            Console.WriteLine($"'{songName}' has been added to your playlist");
            Console.WriteLine($"Next Song: {(rewind.Count > 0 ? rewind.Peek() : playlist.Peek())}");
            break;

        case 2:
            if (playlist.Count > 0 || rewind.Count > 0)
            {
                string currentSong = rewind.Count > 0 ? rewind.Pop() : playlist.Dequeue();
                played.Push(currentSong);
                Console.WriteLine($"Now Playing: {currentSong}");
                if (rewind.Count > 0)
                {
                    Console.Write("Next Song: ");
                    Console.WriteLine(rewind.Peek());
                }
                else if (playlist.Count > 0)
                {
                    Console.Write("Next Song: ");
                    Console.WriteLine(playlist.Peek());
                }
                else
                {
                    Console.WriteLine("End of playlist");
                }
            }
            else
            {
                Console.WriteLine("Please add songs to the playlist first");
            }
            break;

        case 3:
            if (playlist.Count > 0 || rewind.Count > 0)
            {
                string skipped = rewind.Count > 0 ? rewind.Pop() : playlist.Dequeue();
                played.Push(skipped);
                Console.WriteLine($"You have skipped: '{skipped}'");
                try
                {
                    Console.WriteLine($"Next Song: '{(rewind.Count > 0 ? rewind.Peek() : playlist.Peek())}'");
                }
                catch
                {
                    Console.WriteLine("End of playlist");
                }
            } else
            {
                Console.WriteLine("End of playlist");
            }
            break;

        case 4:
            try
            {
                rewind.Push(played.Pop());
            }
            catch
            {
                Console.WriteLine("This is the start of the playlist");
            }
            Console.WriteLine(rewind.Count > 0 ? $"Next Song: {rewind.Peek()}" : $"Next Song: {playlist.Peek()}");
            break;
        case 5:
            continueRunning = false;
            break;
    }

    if (continueRunning)
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1: Add song to playlist");
        Console.WriteLine("2: Play the next song in your playlist");
        Console.WriteLine("3: Skip the next song");
        Console.WriteLine("4: Rewind one song");
        Console.WriteLine("5: Exit");
        userInp = Console.ReadLine();
        blank = string.IsNullOrWhiteSpace(userInp);
        isNumber = int.TryParse(userInp, out numInp);
        while (blank || !isNumber || numInp < 1 || numInp > 5)
        {
            Console.WriteLine("Please input a valid choice");
            userInp = Console.ReadLine();
            blank = string.IsNullOrWhiteSpace(userInp);
            isNumber = int.TryParse(userInp, out numInp);
        }
    }
}