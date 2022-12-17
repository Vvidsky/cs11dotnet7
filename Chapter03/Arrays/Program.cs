﻿string[] names; // can reference any size array of strings
// allocating memory for four strings in an array
names = new string[4];
// storing items at index positions
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";
// looping through the names

string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };

for (int i = 0; i < names2.Length; i++)
{
    // output the item at index position i
    WriteLine(names[i]);
}

string[,] grid1 = new[,] // two dimensions
{
 { "Alpha", "Beta", "Gamma", "Delta" },
 { "Anne", "Ben", "Charlie", "Doug" },
 { "Aardvark", "Bear", "Cat", "Dog" }
};

string[,] grid2 = new string[3,4]; // allocate memory
grid2[0, 0] = "Alpha"; // assign values
grid2[0, 1] = "Beta";
// and so on
grid2[2, 3] = "Dog";

WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid2[row, col]}");
    }
}


