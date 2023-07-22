using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen 10 sayıdan 3 basamaklı sayıların adedi, değerlerinin de toplamını bulan program

            int toplam = 0, adet = 0;
            //1.YOL
            //for(int i=0; i<10; i++)
            //{
            //    Console.Write("\n" + (i + 1) + ". sayı: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

                //    int temp = sayi;
                //    int basamak = 1;
                //    if(temp < 0)
                //    {
                //        temp *= -1;
                //    }
                //    while(temp > 9)
                //    {
                //        temp /= 10;
                //        basamak++;
                //    }

                //    if(basamak == 3)
                //    {
                //        Console.WriteLine(sayi + " 3 basamaklıdır.");
                //        adet++;
                //    }
                //    else 
                //    {
                //        toplam += sayi;
                //    }

            //}

            // 2.YOL
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n" + (i + 1) + ". sayı: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                int temp = sayi;
                if (temp < 0)
                {
                    temp *= -1;
                }

                if(temp>99 && temp < 1000)
                {
                    adet++;
                }
                else
                {
                    toplam += sayi;
                }
            }
            Console.WriteLine("3 basamaklı sayıların adedi: " + adet);
            Console.WriteLine("3 basamaklı sayıların toplamı: " + toplam);
            Console.ReadLine();
        }
    }
}
