using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        double a = 0;
        double b = 1;
        if (n <= 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("0\n1");
            for (int y = 0; y < n - 2; y++)
            {
                double fiNumber = a + b;
                a = b;
                b = fiNumber;
                Console.WriteLine(fiNumber);
            }
        }
    }
}