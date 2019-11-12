using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1 den 100 e kadar olan sayılar içerisinde 5 e tam bölünen aynı zamanda 7 ye tam bölünmeyen 
           sayıları sayan toplayan programı yazınız.*/
        
            int toplam =0, adet=0;

            for(int i=1; i<=100;i++){
            if(i%5==0 && i%7!=0)
                {
                toplam=toplam+i;
            adet++;

            }

                
            }

                Console.WriteLine("{0} sayı bulundu",adet);
                Console.WriteLine("sayıların toplamı:{0}",toplam);

            Console.ReadKey();

        }
    }
}
