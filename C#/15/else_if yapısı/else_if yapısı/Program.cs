using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace else_if_yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            string gun;
            int a;

            Console.WriteLine("1 ile 7 arasında bir deger giriniz.");

            gun = Console.ReadLine();

            a = Convert.ToInt32(gun);

            if (a == 1)
            {
                Console.WriteLine("bugun günlerden pazartesi.");
            }
            else if (a == 2)
            {

                Console.WriteLine("bugun günlerden salı.");
            }
            else if (a == 3)
            {

                Console.WriteLine("bugun günlerden çarşamba.");

            }

            else if (a == 4)
            {

                Console.WriteLine("bugun günlerden perşembe.");
            }
            else if (a == 5)
            {

                Console.WriteLine("bugun günlerden cuma.");
            }

            else if (a == 6)
            {

                Console.WriteLine("bugun günlerden cumartesi.");
            }

            else if (a == 7)
            {

                Console.WriteLine("bugun günlerden pazar.");
            }
        }

    }
}
