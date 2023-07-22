using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen iki sayıdan büyük olanı ekrana yazdıran program
            Console.WriteLine("Birinci sayiyi giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayiyi giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if(sayi1 > sayi2)
            {
                Console.WriteLine("Birinci sayi büyüktür. Değeri: " + sayi1);
            } 
            else if(sayi1 < sayi2)
            {
                Console.WriteLine("İkinci sayi büyüktür. Değeri: " + sayi2);
            }
            else
            {
                Console.WriteLine("İki sayi eşittir. Değerleri: " + sayi1);
            }
            Console.ReadLine();
        }
    }
}
