using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace basıt_toplama_ıslemı_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sonuc;

             string yazi1,yazi2;


             Console.Write("birinci sayiyi giriniz");
             yazi1 = Console.ReadLine();

             Console.Write("ikinci sayiyi giriniz");
             yazi2 = Console.ReadLine();


             a = Convert.ToInt32(yazi1);

             b = Convert.ToInt32(yazi2);

             sonuc = a + b;

             Console.Write("2 sayinin toplamı:"+sonuc);
             Console.ReadKey();


        }
    }
}
