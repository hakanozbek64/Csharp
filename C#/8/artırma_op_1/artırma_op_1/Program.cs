using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace artırma_op_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // artırma azaltma operatörleri(++ ve --)

            int a = 15, b;

            b = a++;
            b = ++a;

            Console.WriteLine(a);

            Console.WriteLine(b);

            Console.ReadKey();



        }
    }
}
