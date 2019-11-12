using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_dongusu_3
{
    class Program
    {
        static void Main(string[] args)
        {
          // iç içe for döngüsü


            int x, y;

            for (y = 0; y <= 5;y++ )
            {
                for (x = 0; x <= y;x++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.ReadKey();

        }
    }
}
