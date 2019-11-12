using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_case2
{
    class Program
    {
        static void Main(string[] args)
        {

            // dört işlem programı.


            int a, b, işlem;

            Console.WriteLine("birinci sayıyı giriniz.");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz.");

            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("dört işlem programına hoşgeldiniz.\nLütfen aşagıdaki seceneklerden birinini seciniz.\n1-toplama\n2-cıkarma\n3-caprma\nbölme");

            işlem=Convert.ToInt32(Console.ReadLine());

        switch(işlem){
        
            case 1:

              Console.WriteLine(a+b);
                  
                break;
            case 2:

                Console.WriteLine(a-b);

                break;
                 
            default:

                Console.WriteLine("HATA !!! lütfen 1-2-3-4 degerlerinden birini giriniz.");
        
              break;
             

        }

        Console.ReadKey();

        }
    }
}
