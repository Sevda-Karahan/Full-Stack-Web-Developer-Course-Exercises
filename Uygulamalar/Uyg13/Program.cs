using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diziler Devam...
            // foreach kullanımı
            string[] adlar = { "ali", "veli", "hasan" };

            for (int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine(adlar[i]);
            }

            Console.WriteLine("**********");
            foreach (var item in adlar)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
