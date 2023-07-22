using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telefon modeli giriniz:");
            Console.WriteLine("Samsung için 1'e basınız.");
            Console.WriteLine("Iphone için 2'e basınız.");
            Console.WriteLine("Nokia için 3'e basınız.");

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Samsung!");
                    break;
                case 2:
                    Console.WriteLine("Iphone!");
                    break;
                case 3:
                    Console.WriteLine("Nokia!");
                    break;
                default:
                    Console.WriteLine("Hatalı seçim!");
                    break;
            }
        }
    }
}
