using System;

namespace PracticeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }

                i++;
            }
           
        }
    }
}
