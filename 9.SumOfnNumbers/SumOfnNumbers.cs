using System;

    class SumOfnNumbers
    {
        static void Main()
        {
            Console.WriteLine("How many numbers do you want to sum?");;
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Eneter number to be summed");
                sum = sum + int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }