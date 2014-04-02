using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter number 1");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        float num2 = float.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(num1, num2));
    }
}
