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

// Goto statement example
Console.WriteLine("Goto statement example:");
int sum = 0;
int n = 0;

LOOP:
    n++;
    //Console.WriteLine($"Current number: {n}");
    if ( n > 100)
    {
        Console.WriteLine("Reached the end of the loop, exiting...");
        goto LOOPEXIT;
    }

    if (n % 2 != 0)
    {
        //Console.WriteLine($"Skipping odd number: {n}");
        goto LOOP;
    }

    //Console.WriteLine($"Adding even number: {n}");
    sum += n;
    goto LOOP;

LOOPEXIT:
Console.WriteLine($"Sum of numbers from 1 to 100: {sum}");

// Escape statement example
bool exitLoop = false;
for (int x = 2; x < 10; x++)
{
    for (int y = 1; y < 10; y++)
    {
        Console.WriteLine("Current values: x = {0}, y = {1}", x, y);

        exitLoop = x == 5 && y == 8;
        if (exitLoop == true)
        {
            break;
        }
    }

    if (exitLoop == true)
    {
        Console.WriteLine("Exiting the loop early due to condition met.");
        break;
    }
}

// Escape statement with goto example
for (int x = 2; x < 10; x++)
{
    for (int y = 1; y < 10; y++)
    {
        Console.WriteLine("Current values: x = {0}, y = {1}", x, y);
        if (x == 5 && y == 8)
        {
            Console.WriteLine("Exiting the loop early using goto.");
            goto LOOP_EXIT;
        }
    }
}

LOOP_EXIT:
    Console.WriteLine("Escape with goto");

