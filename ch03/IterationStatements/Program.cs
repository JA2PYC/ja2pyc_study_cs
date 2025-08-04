// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iteration Statements");
Console.WriteLine("----------------------");

// For loop example
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Iteration {i + 1}");
}

// Nested for loop example
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine($"Outer loop iteration {i + 1}, Inner loop iteration {j + 1}");
    }
}

// Foreach loop example
//int[] arr = new int[] { 1, 2, 3, 4, 5 };
int[] arr = [1, 2, 3, 4, 5];
foreach (int element in arr)
{
    Console.WriteLine($"Foreach Array element: {element}");
}

// While loop example
int sum = 0;
int n = 1;

while (n <= 100)
{
    if (n % 2 == 0)
    {
        sum += n;
    }

    n++;
}
Console.WriteLine($"Sum of even numbers from 1 to 100: {sum}");

// Do-while loop example
sum = 0;
n = 1;
do
{
    if (n % 2 == 0)
    {
        sum += n;
    }
} while (++n <= 100);
Console.WriteLine($"Sum of even numbers from 1 to 100 using do-while: {sum}");

Console.WriteLine("----------------------");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();