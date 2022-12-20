partial class Program
{
    // static void TimesTable(byte number, byte size = 12)
    // {
    //     WriteLine($"This is the {number} times table with {size} rows:");
    //     for (int row = 1; row <= size; row++)
    //     {
    //         WriteLine($"{row} x {number} = {row * number}");
    //     }
    //     WriteLine();
    // }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M, // Switzerland
            "DK" => 0.25M, // Denmark
            "NO" => 0.25M, // Norway
            "GB" => 0.2M, // United Kingdom
            "FR" => 0.2M, // France
            "HU" => 0.27M, // Hungary
            "OR" => 0.0M, // Oregon
            "AK" => 0.0M, // Alaska
            "MT" => 0.0M, // Montana
            "ND" => 0.05M, // North Dakota
            "WI" => 0.05M, // Wisconsin
            "ME" => 0.05M, // Maine
            "VA" => 0.05M, // Virginia
            "CA" => 0.0825M, // California
            _ => 0.06M // most US states
        };

        return amount * rate;
    }

    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11: // special cases for 11th to 13th
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                int lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalToOrdinal()
    {
        for (int number = 1; number <= 1500; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(message:
            $"The factorial function is defined for non-negative integers only.Input: {number}",
            paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }

        }
    }

    static void RunFactorial()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }
}