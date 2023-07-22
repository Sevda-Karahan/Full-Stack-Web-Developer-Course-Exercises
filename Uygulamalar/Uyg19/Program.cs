using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*20 elemanlı diziye rastgele -100 ile +100 arasında sayılar atan ve daha sonra dizinin elemanlarını,
            pozitif sayı adedini, negatif sayı adedini yazdıran program*/

            int[] numbers = new int[20];
            int negative = 0, positive = 0;
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                numbers[i] = rand.Next(-100, 100);
            }

            Console.Write("Dizi elemanları: ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(numbers[i] + " ");
                if(numbers[i] < 0)
                {
                    negative++;
                }
                else if (numbers[i] > 0)
                {
                    positive++;
                }
            }

            //with foreach
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //    if (number < 0)
            //    {
            //        negative++;
            //    }
            //    else if (number > 0)
            //    {
            //        positive++;
            //    }
            //}
            Console.WriteLine("\nDizideki pozitif sayı adedi: " + positive);
            Console.WriteLine("Dizideki negatif sayı adedi: " + negative);
            Console.ReadLine();
        }
    }
}
