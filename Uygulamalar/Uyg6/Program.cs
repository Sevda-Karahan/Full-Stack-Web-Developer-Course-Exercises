using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler   -> tekrarlayan işlemler
            // 1.for     -> dizi, koleksiyon mantığında kullanılır.
            // 2.foreach -> mvc, .net, core listeleme yaparken
            // 3.while   -> ado.net'de database'den verileri çekerken
            // 4.do-while

            // 1den 10a kadar olan sayıları yazdırma
            for(int  i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**********");

            // 5 ile 40 arasındaki sayıların toplamını yazdıran program
            int toplam = 0;
            for(int sayi = 5; sayi < 41; sayi++)
            {
                toplam += sayi;
            }

            Console.WriteLine("Toplam: " + toplam);

            Console.WriteLine("**********");

            // Dışarıdan girilen 10 sayının çift olanlarının toplamı

            toplam = 0;
            for(int i=0; i<10; i++)
            {
                Console.Write((i+1) + ".sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Sayi çifttir. Değeri: " + sayi);
                    toplam += sayi;
                }
            }

            Console.WriteLine("Girilen çift sayıların toplamı: " + toplam);
            Console.ReadLine();
        }
    }
}
