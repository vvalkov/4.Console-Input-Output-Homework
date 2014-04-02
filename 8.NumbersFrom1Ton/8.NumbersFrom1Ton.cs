using System;

    class NumbersFrom1Ton
    {
        static void Main()
        {
            Console.WriteLine("Please enter a whole number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine(i);                
            }
        }
    }