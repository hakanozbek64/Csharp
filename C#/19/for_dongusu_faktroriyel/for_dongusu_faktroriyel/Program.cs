using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_dongusu_faktroriyel
{
    class Program
    {
        static void Main(string[] args)
        {

            int a,sonuc=1;
            Console.WriteLine("faktoriyeli alınacak sayıyı giriniz...");

            a = Convert.ToInt32(Console.ReadLine());

            for (int b = 1; b <= a;b++ )
            {
                sonuc = sonuc * b;

            }

            Console.WriteLine("faktoriyeli:{0}",sonuc);
            Console.ReadLine();
        }
    }
}
