using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Dizi için değer giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nDizi elemanları: ");
            foreach (var item in sayilar)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
