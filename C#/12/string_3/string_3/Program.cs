using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace string_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5, sayi2 = 10;

            string yazi1, yazi2;

            yazi1 = sayi1.ToString();
            yazi2 = sayi2.ToString();


            Console.WriteLine(sayi1+sayi2);
            Console.WriteLine(yazi1 + yazi2);
            Console.ReadLine();

        }
    }
}
