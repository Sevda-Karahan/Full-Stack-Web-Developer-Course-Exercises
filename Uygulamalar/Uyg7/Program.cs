using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Başlangıç ve bitiş sayısını belirleyerek bu sayılardan 3e ve 5e bölünenlerin adedini buldur.
            Console.WriteLine("Başlangıç değeri: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitiş değeri: ");
            int bitis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBu aralıkta 3'e ve 5'e bölünen sayılar:");
            for (int i=baslangic; i<=bitis; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
