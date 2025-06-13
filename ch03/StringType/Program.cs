// See https://aka.ms/new-console-template for more information
Console.WriteLine("String Type");

char ch = 'A';
Console.WriteLine("Character value: " + ch);

// \ Example
char ch1 = '\t'; // Tab character
char ch2 = 'T'; // String representation of a tab character
char ch3 = '\n'; // New line character
char ch4 = 'N'; // String representation of a new line character

Console.Write("Character with \\: " + ch1 + ch2 + ch3 + ch4 + "\n");

// Unicode character example
char ch5 = '\u0041'; // Unicode representation of 'A'
Console.WriteLine("Unicode character: " + ch5);

// Backslash character
char ch6 = '\\';
Console.WriteLine("Backslash character: " + ch6);

// String examples
string text1 = "Hello, World!";
Console.WriteLine("String value: " + text1);

string text2 = "\tHello\nWorld";
Console.WriteLine("String with tab and new line: " + text2);

string text3 = "\"Hello, World!\"";
Console.WriteLine("String with quotes: " + text3);

string text4 = @"C:\Users\Public\Documents";
Console.WriteLine("String with backslash: " + text4);

string text5 = "Hello";
Console.WriteLine("String value with +: " + text5 + " World!");

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

