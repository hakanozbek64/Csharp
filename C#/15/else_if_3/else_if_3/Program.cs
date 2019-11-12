using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace if_else_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int not;
            Console.WriteLine("sınavlarınız ortalamasını giriniz.");
            not = Convert.ToInt32(Console.ReadLine());

            if (not > 90)
            {
                Console.Write("tebrikler AA aldınız.");


            }

            else if (not > 70)
            {

                Console.WriteLine("tebirikler  BA ile geçtiniz.");
            }


            else if (not > 60)
            {

                Console.WriteLine("tebirikler  BB ile geçtiniz.");
            }

            else if (not < 50)
            {

                Console.WriteLine("tebirikler ÇAN ile geçtin.");
            }
            Console.ReadKey();



        }
    }
}
