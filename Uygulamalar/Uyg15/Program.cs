using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama15
{
    class Program
    {
        static void Main(string[] args)
        {
            //çok boyutlu diziler 
            // 2 bölge, her birinde 3 il için
            string[,] bolgenin_illeri = new string[2, 3]
            {
                {"istanbul", "çanakkale", "balıkesir"},
                {"trabzon", "ordu", "giresun"}
            };

            Console.WriteLine(bolgenin_illeri[0, 0]);
            Console.WriteLine(bolgenin_illeri[1, 2]);
            Console.ReadLine();

        }
    }
}
