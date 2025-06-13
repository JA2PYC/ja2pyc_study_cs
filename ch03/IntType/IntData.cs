using System;

namespace IntType
{
    public class IntData
    {
        public int Value { get; set; }

        public IntData(int value)
        {
            Value = value;
        }

        public void Print()
        {
            Console.WriteLine($"IntData Value: {Value}");
        }
    }
}