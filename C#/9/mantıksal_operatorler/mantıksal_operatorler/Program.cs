using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mantıksal_operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            // mantıksal operatörler

            bool sayi1 = 10 > 5 && 30 < 40;

               Console.WriteLine(sayi1);


               bool sayi2 = 5 < 4 && 7 < 8;

               Console.WriteLine(sayi2);


               bool sayi3 = 10 > 5 || 20 < 5;

               Console.WriteLine(sayi3);



               bool sayı4=!(100==100);

               Console.WriteLine(sayı4);


             Console.ReadKey();

        }
    }
}
