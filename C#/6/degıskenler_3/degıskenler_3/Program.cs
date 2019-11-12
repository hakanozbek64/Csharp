using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace degıskenler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan ad soyad alalım ,daha sonra ekranda bunu göstersin.

            string a;

            Console.WriteLine("LUTFEN _ADINIZI VE SOYADINIZI GIRINIZ");
            a = Console.ReadLine();

            Console.WriteLine("MERHABA " +a+ " HOŞGELDİNİZ");
            Console.ReadKey();
        }
    }
}
