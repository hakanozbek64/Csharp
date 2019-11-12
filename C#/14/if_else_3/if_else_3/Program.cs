using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace if_else_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 20;

            if (a > b)
            {
                a--;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("B büyüktür A dan.");


            }
            Console.ReadKey();

            }
        
    }
}
