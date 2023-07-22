using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen iki sayinin ort 70 ve ustu ise iyi, degilse kotu yazan program

            Console.WriteLine("1. not:");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. not:");
            int not2 = Convert.ToInt32(Console.ReadLine());

            int ort = (not1 + not2) / 2;
            if (ort >= 70)
            {
                Console.WriteLine("Iyi!");
            }
            else
            {
                Console.WriteLine("Kotu!");
            }

            Console.ReadLine();
        }
    }
}
