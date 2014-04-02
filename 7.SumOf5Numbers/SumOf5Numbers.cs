using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 numbers separated space");
        string input = Console.ReadLine();
        double sum = 0;
        string[] separator = input.Split(' ');
        for (int i = 0; i < separator.Length; i++)
        {
            sum = sum + double.Parse(separator[i]);
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}