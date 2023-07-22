using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayi icin pozitif, negatif, sifir yazdiran program
            Console.WriteLine("Sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi > 0)
            {
                Console.WriteLine("Pozitif!");
            }
            else if(sayi < 0)
            {
                Console.WriteLine("Negatif!");
            }
            else
            {
                Console.WriteLine("Sifir!");
            }

            Console.ReadLine();
        }
    }
}
