using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, işlem;

            Console.WriteLine("birinci sayıyı giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dört işleme hoşgeldiniz");

            Console.WriteLine("aşagıdan seciminizi yapınız.");

            Console.WriteLine("1-toplama\n2-cıkarma\n3-çarpma\n4-bölme");


            işlem = Convert.ToInt32(Console.ReadLine());

            if (işlem == 1) 
            {
                Console.WriteLine("sayıların toplamı:{0}",a+b);
            
            }

            else if(işlem==2)
            {
                Console.WriteLine(a-b);
            
            
            }


            else if(işlem==3)
            {
             
            Console.WriteLine(a*b);
            }

            
            else if(işlem==4){

                Console.WriteLine(a / b);
            
            }


            Console.ReadKey();
        }
    }
}
