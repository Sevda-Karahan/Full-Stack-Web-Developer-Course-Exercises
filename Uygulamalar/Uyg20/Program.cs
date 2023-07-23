using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg20
{
    class Program
    {
        static void Main(string[] args)
        {
            //15 elemanlı bir sayı dizisi oluşturunuz.
            //Kullanıcı bir sayı girsin, bu sayının dizide olup olmadığı ve kaç adet bulunduğu aratılsın.

            int[] arr = { 1, 3, 5, 2, 2, 6, 9, 1, 3, 7, 8, 10, 22, 12, 12};

            Console.WriteLine("Dizide aratmak istediğiniz sayıyı giriniz: ");
            int searched = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (searched == arr[i])
            //    {
            //        count++;
            //    }
            //}

            //foreach kullanımı
            foreach (int num in arr)
            {
                if (searched == num)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Aradığınız sayı dizide bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Aradığınız sayı dizide bulunmaktadır. \nAdedi: " + count);
            }
            Console.ReadLine();
        }
    }
}
