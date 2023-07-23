using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg22
{
    class Program
    {
        public static void Alan(int kisak, int uzunk)
        {
            int alan = kisak * uzunk;
            Console.WriteLine("Alan method sonucu: " + alan);
        }

        public static int Alan2(int x, int y)
        {
            return x*y;
        }

        static void Main(string[] args)
        {
            //METHODS

            //dikdörtegin alanı

            Alan(3, 5);
            Console.WriteLine("Alan2 method sonucu: " + Alan2(3, 5));
            Console.WriteLine("************");

            Console.WriteLine("Kısa kenar değeri: ");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenar değeri: ");
            int uk = Convert.ToInt32(Console.ReadLine());
           
            Alan(kk, uk);
            Console.WriteLine("Alan2 method sonucu: " + Alan2(kk, uk));
            Console.ReadLine();

        }
    }
}
