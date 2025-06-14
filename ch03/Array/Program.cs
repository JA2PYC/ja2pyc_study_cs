// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array");

// Array example
int[] products = new int[5]; // Declare an array of integers with a size of 5
products[0] = 100; // Assign a value to the first element of the products array
products[1] = 200; // Assign a value to the second element of the products array

int product = products[0]; // Access the first element of the products array and assign it to book
int sum = products[0] + products[1]; // Calculate the sum of the first two elements of the products array

Console.WriteLine($"Product: {product}, Sum: {sum}"); // Print the values of book and sum

int[] books = new int[5] { 100, 200, 300, 400, 500 }; // Declare and initialize an array of integers with values
// int [] books = new int[] { 100, 200, 300, 400, 500 }; // Another way to declare and initialize an array

Console.WriteLine($"Books Length: {books.Length}"); // Print the length of the books array
Console.WriteLine($"Books[0]: {books[0]}, Books[1]: {books[1]}"); // Print the first two elements of the books array


// String array example
string[] names = new string[10]; // Declare an array of strings with a size of 10
names[0] = "John"; // Assign a value to the first element of the names array (optional, can be left null)

Console.WriteLine($"Names Length: {names.Length}"); // Print the length of the names array
Console.WriteLine($"Names[0]: {names[0]}"); // Print the first element of the names array (which is null by default)

string text = "Hello, World!"; // Declare a string variable and assign a value to it
char ch1 = text[0]; // Access the first character of the string and assign it to ch1
char ch2 = text[7]; // Access the eighth character of the string and assign it to ch2

Console.WriteLine($"First character: {ch1}, Eighth character: {ch2}"); // Print the characters ch1 and ch2

int[] students = new int[60];
students[0] = 50;

Console.WriteLine($"Students Length: {students.Length}"); // Print the length of the students array
Console.WriteLine($"Students[0]: {students[0]}"); // Print the first element of the students array

students = new int[100]; // Reinitialize the students array to a new size of 100
students[1] = 100; // Assign a value to the second element of the new students array

Console.WriteLine($"New Students Length: {students.Length}"); // Print the new length of the students array
Console.WriteLine($"Students[0]: {students[0]}"); // Print the first element of the new students array
Console.WriteLine($"New Students[1]: {students[1]}"); // Print the second element of the new students array

Console.WriteLine ("Press any key to exit...");
Console.ReadKey(); // Wait for the user to press a key before exiting the program
