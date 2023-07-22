using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int fb = rand.Next(0, 5);
            //int gs = rand.Next(0, 5);

            int gs = 4 - fb;

            if(fb == gs)
            {
                Console.WriteLine("Berabere...");
            }
            else if (fb > gs)
            {
                Console.WriteLine("Fb kazandı!");
            }
            else
            {
                Console.WriteLine("Gs kazandı!");
            }


            Console.WriteLine("Fb skor: " + fb);
            Console.WriteLine("Gs skor: " + gs);
            Console.ReadLine();
        }
    }
}
