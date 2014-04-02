using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number a");
        short num = short.Parse(Console.ReadLine());
        while (!(num >= 0 && num <= 500))
        {
            Console.WriteLine("Enter number which is 0 ≤ a ≤ 500");
            num = short.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter number b");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c");
        float c = float.Parse(Console.ReadLine());
        Console.Write("|{0,-10:X}|", num);
        String binary = Convert.ToString(num, 2).PadLeft(10, '0');
        Console.WriteLine("{0}|{1,10:F2}|{2,-10:F3}", binary, b, c);
    }
}
