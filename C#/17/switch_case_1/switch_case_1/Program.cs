using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("1-2 degerlerinden birini giriniz.");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a) { 
            
                case 1:

                    Console.WriteLine("1 degeri girildi.");
                    break;
                case 2:

                    Console.WriteLine("2 degeri girildi.");

                    break;
               
                default:

                    Console.WriteLine("1 ve 2 degeri dışında bir deger girildi.");

                    break;
            
            
            }

            Console.ReadKey();
        }
    }
}
