int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine(
 format: "{0} apples cost {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
 format: "{0} apples cost {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);
//WriteToFile(formatted); // writes the string into a file

// The following statement must be all on one line.
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
Console.WriteLine(
 format: "{0,-10} {1,6}",
 arg0: "Name",
 arg1: "Count");
Console.WriteLine(
 format: "{0,-10} {1,6:N0}",
 arg0: applesText,
 arg1: applesCount);
Console.WriteLine(
 format: "{0,-10} {1,6:N0}",
 arg0: bananasText,
 arg1: bananasCount);

Console.Write("Type your first name and press ENTER: "); 
string firstName = Console.ReadLine()!;
Console.Write("Type your age and press ENTER: "); 
string age = Console.ReadLine()!;   // ! is null giving operator, ReadLine will not return null;
Console.WriteLine($"Hello {firstName}, you look good for {age}.");



// // Four parameter values can use named arguments.
// Console.WriteLine(
//  format: "{0} {1} lived in {2}, {3}.", 
//  arg0: "Roger", arg1: "Cevung", 
//  arg2: "Stockholm", arg3: "Sweden");
// // Five or more parameter values cannot use named arguments.
// Console.WriteLine(
//  format: "{0} {1} lived in {2}, {3} and worked in the {4} team at {5}.", 
//  "Roger", "Cevung", "Stockholm", "Sweden", "Education", "Optimizely");
