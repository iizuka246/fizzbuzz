using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("数字を入力してください");
            int max = int.Parse(Console.ReadLine());
            while (count < max)
            {
                count++;
                
                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (count % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(count);
                }
            }
        }
    }
}
