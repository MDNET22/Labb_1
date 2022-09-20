ConsoleColor[] colors ={
        ConsoleColor.Red,
        ConsoleColor.Magenta,
        ConsoleColor.Cyan,
        ConsoleColor.Green,
        ConsoleColor.DarkGreen,
        ConsoleColor.Blue,
        ConsoleColor.DarkBlue,
        ConsoleColor.DarkCyan,
        ConsoleColor.DarkGreen,
        ConsoleColor.DarkYellow,
        ConsoleColor.Yellow,
        ConsoleColor.DarkGray,
        ConsoleColor.DarkMagenta,
        ConsoleColor.DarkRed,
        ConsoleColor.White
    };

Console.WriteLine("Write a string:" );
string originalString = "";
int startIndex = 0;
int endIndex = 0;
long total = 0;
//int Length = (endIndex - startIndex) + 1;
int totalNumbersFound = 0;
string? userInput = Console.ReadLine();

for (int k = 0; k < originalString.Length; k++)
    {
        if (k >= startIndex && k <= endIndex)
        {
            Console.ForegroundColor = colors[totalNumbersFound % colors.Length];
        }
        else
        {
            Console.ResetColor();
        }
        Console.Write(originalString[k]);

if (userInput != null)
{
    for (int i = 0; i < userInput.Length; i++)
    {
        if (char.IsDigit(userInput[i]))
        {
            for (int j = i + 1; j < userInput.Length; j++)
            {
                if (char.IsDigit(userInput[j]))
                {
                    if (userInput[i] == userInput[j])
                    {
                        totalNumbersFound++;
                        startIndex = i;
                        endIndex = j;
                        originalString = userInput;
                        string number = userInput.Substring(i, j - i + 1);
                        total += long.Parse(number);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
    Console.WriteLine($"Total: = {total}");
    // Console.WriteLine();
    // Console.ResetColor();
    // Console.WriteLine();
    //Console.WriteLine(String.Format("Total = {0}", total));
}
else
{
    Console.WriteLine("Incorrect value");
}
    }