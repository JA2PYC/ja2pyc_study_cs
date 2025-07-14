// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iteration Statements");
Console.WriteLine("----------------------");

// For loop example
for (int i = 0; i <10; i++)
{
    Console.WriteLine($"Iteration {i + 1}");
}

// Nested for loop example
for ( int i = 0; i < 3; i++)
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



Console.WriteLine("----------------------");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();