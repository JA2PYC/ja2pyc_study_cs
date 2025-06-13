using System;

public class ExplicitConversion
{
    public static void Convert()
    {
        double num = 9.75;
        int smallNum = (int)num;
        Console.WriteLine($"Explicit Conversion : {smallNum}");

        ushort u = 65;
        // char c = u; // This line will cause a compile-time error in C# 12.0 and later
        char c = (char) u;
        Console.WriteLine($"Explicit Conversion from ushort to char : {c}");


        int n = 40000;
        short s = (short)n; // This will truncate the value
        Console.WriteLine($"Explicit Conversion from int to short : {s}");
    }
}