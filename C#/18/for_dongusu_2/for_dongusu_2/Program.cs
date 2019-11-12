using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_dongusu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;

            for (int i = 1; i <= 1000; i++)
            {

                toplam = toplam + i;
            }
            Console.WriteLine("sayıların toplamı:{0}", toplam);
            Console.ReadKey();
        }
    }
}
