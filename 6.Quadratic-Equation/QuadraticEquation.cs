using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient a");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient c");
        float c = float.Parse(Console.ReadLine());
        double d = (b * b - 4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (d > 0)
        {
            double x1 = ((-b + Math.Sqrt(d)) / (2 * a));
            double x2 = ((-b - Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("x1={0}\r\nx2= {1}", x1, x2);
        }
        else
        {
            Console.WriteLine("x1=x2={0}", -b /( 2 * a));
        }
    }
}
