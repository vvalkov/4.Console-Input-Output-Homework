using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter radius");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("Perimeter: {0:00}\r\nArea: {1:00}", perimeter, area);
    }
}
