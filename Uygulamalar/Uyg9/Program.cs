using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random
            Random rand= new Random();
            int sayi = rand.Next(0,10);
            Console.WriteLine("Rasgele seçilen sayı: " + sayi);
            Console.ReadLine();
        }
    }
}
