using System.Text.RegularExpressions; // Regex

WriteLine("The default regular expression checks for at least one digit.");
do
{
    Write("Enter a regular expression (or press ENTER to use the default): ");
    string inputRegex = ReadLine()!;
    Regex customRegex;
    if (string.IsNullOrWhiteSpace(inputRegex)) // if they enter nothing...
    {
        // ... set a default Regex
        customRegex = new(@"^\d+$");
    }
    customRegex = new(inputRegex);

    Write("Enter some input: ");
    string input = ReadLine()!;
    WriteLine($"{input} matches {customRegex.ToString()}? {customRegex.IsMatch(input)}");
    WriteLine("Press ESC to end or any key to try again.");
} while (ReadKey(intercept: true).Key != ConsoleKey.Escape);

