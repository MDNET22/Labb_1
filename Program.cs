Console.WriteLine("Insert a string:" );
long total = 0;
string? userInput = Console.ReadLine();
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
}
else
{
    Console.WriteLine("Incorrect value");
}