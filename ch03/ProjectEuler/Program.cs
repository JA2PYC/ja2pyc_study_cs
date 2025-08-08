// See https://aka.ms/new-console-template for more information
Console.WriteLine("Project Euler");
Console.WriteLine("----------------------");

Console.WriteLine("Quiz 1");
Console.WriteLine("Sum of all multiples of 3 or 5 below 1000:");

for (int i = 0, sum = 0; i < 1000; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sum += i;
    }
    if (i == 999)
    {
        Console.WriteLine($"Sum : {sum}");
    }
}
