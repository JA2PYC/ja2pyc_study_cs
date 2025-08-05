// See https://aka.ms/new-console-template for more information
Console.WriteLine("Jump Statements");
Console.WriteLine("----------------------");

int i = 0;
while(i<10)
{
    // Continue statement example
    // If i is 4, skip the rest of the loop iteration
    if (i == 4)
    {
        Console.WriteLine("Skipping the rest of the loop iteration at i = 4");
        i++; // Increment i to avoid infinite loop
        continue; // Skip to the next iteration of the loop
    }

    // Break statement example
    // If i is 5, break the loop
    if (i == 5)
    {
        Console.WriteLine("Breaking the loop at i = 5");
        break; // Exit the loop when i is 5
    }

    Console.WriteLine($"Current value of i: {i}");
    i++;
}
