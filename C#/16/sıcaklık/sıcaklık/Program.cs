using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sıcaklık
{
    class Program
    {
        static void Main(string[] args)
        {
            //sıcaklık
            int derece;

            Console.WriteLine("odadaki sıcaklıgı giriniz, lütfen:");

            derece = Convert.ToInt32(Console.ReadLine());


            if (derece > 0 && derece < 20) {
                Console.WriteLine("hava güzel");
            
            }
             if (derece>20&&derece<40){

                 Console.WriteLine("havalar çok sıcak pişmek üzereyiz!");
             }

             if(derece>40&&derece<60){

                 Console.WriteLine("canınızı seviyorsanız hemen oradan kaçın !!!");
             
             }
            Console.ReadKey();

        }
    }
}
