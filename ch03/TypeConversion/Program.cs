// See https://aka.ms/new-console-template for more information
// Project Reference
using System;
using IntType;

Console.WriteLine("Type Conversion");

// Implicit Conversion
ImplicitConversion.Convert();

// Explicit Conversion
ExplicitConversion.Convert();

// IntType Example
IntData intData = new IntData(13);
intData.Print();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();