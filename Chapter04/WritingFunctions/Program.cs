﻿// TimesTable(7);
// TimesTable(7, 20);

Console.OutputEncoding = System.Text.Encoding.Unicode;
decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax.");

// RunCardinalToOrdinal();
RunFactorial();
// RunFibImperative();
RunFibFunctional();