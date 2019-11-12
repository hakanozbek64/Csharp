using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace artırma_op_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 100, b, c, d;

            b = ++a;
            c = a++;
            d = ++b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
