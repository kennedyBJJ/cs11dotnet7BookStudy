int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apple cost {1:C}",
    arg0: numberOfApples,
    arg1: numberOfApples * pricePerApple
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

// Four parameter values can use named arguments.
Console.WriteLine(
    format: "{0} {1} lived in {2}.",
    arg0: "Roger",
    arg1: "Cevung",
    arg2: "Stockholm"
);

// Five or more parameter values cannot use named arguments.
Console.WriteLine(
    format: "{0} {1} lived in {2}, {3} and worked in the {4} team at {5}.",
    "Roger",
    "Cevung",
    "Stockholm",
    "Sweden",
    "Education",
    "Optimizely"
);

//WriteToFile(formatted); // writes the string into a file

//Usando interpolação
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

Console.WriteLine();

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

// { index [, alignment ] [ : formatString ] }
//alignment <0 is  to the left
//alignment >0 is to the right
//formatString N0 is a number if thousand separator and no decimal
//formatString C is the notebook local currency
Console.WriteLine(format: "{0,-10} {1,6}", arg0: "Name", arg1: "Count");

Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: applesText, arg1: applesCount);

Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: bananasText, arg1: bananasCount);

Console.Write("Type your first name and press ENTER: ");
// string? firstName = Console.ReadLine();
Console.Write("Type your age and press ENTER: ");
// string age = Console.ReadLine()!;
// Console.WriteLine($"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine(
    "Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers
);
