using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan double olan dizi eleman sayısı ve dizi elemanları alınsın. Elemanların ort hesaplansın.

            Console.Write("Dizi eleman sayısı: ");
            int length = Convert.ToInt32(Console.ReadLine());
            double total = 0;

            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write(i + 1 + ". elemanı giriniz: ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
                total += arr[i];
            }

            Console.Write("\nDizi elemanları: ");
            foreach (double num in arr)
            {
                Console.Write(" " + num);
            }

            Console.WriteLine("\nDizi elemanlarının ortalaması: " + (total / length));
            Console.ReadLine();
        }
    }
}
