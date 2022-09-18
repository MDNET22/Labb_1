// Användaren får mata in en sträng
Console.WriteLine("Insert a string:" );
// Deklarera variabler
long total = 0;
string? userInput = Console.ReadLine();
// Kolla om strängen inte är null
if (userInput != null)
{
    // loopar igenom strängen
    for (int i = 0; i < userInput.Length; i++)
    {
        // Kollar om tecknet är en siffra
        if (char.IsDigit(userInput[i]))
        {   // Loopar igenom strängen efter i:s position
            for (int j = i + 1; j < userInput.Length; j++)
            {
                // Kollar om tecknet är en siffra
                if (char.IsDigit(userInput[j]))
                {
                    // Om siffra i är samma som siffra j
                    if (userInput[i] == userInput[j])
                    {   // bryter ut siffrorna från i till j och lägger i en variabel
                        string number = userInput.Substring(i, j - i + 1);
                        // konverterar strängen till long och adderar till totalen
                        total += long.Parse(number);
                        break;
                    }
                }
                // Bryter loopen om tecknet inte är en siffra
                else
                {
                    break;
                }
            }
        }
    }
    // Skriver ut totalem
    Console.WriteLine($"Total: = {total}");
}
// Strängen får inte vara null
else
{
    // Om strängen är null skrivs incorrect value ut
    Console.WriteLine("Incorrect value");
}