using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = {10, 20, 30};
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("**********");
            string[] adlar = { "ali", "veli", "hasan" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(adlar[i]);
            }
            //int[] sayilar2 = new int[3];
            //sayilar2[0] = 10;
            //sayilar2[1] = 20;
            //sayilar2[2] = 30;

            Console.ReadLine();
        }
    }
}
