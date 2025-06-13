using System;

public class ImplicitConversion
{
    public static void Convert()
    {
        int num = 100;
        long bigNum = num;
        Console.WriteLine($"Implicit Conversion : {bigNum}");
    }
}