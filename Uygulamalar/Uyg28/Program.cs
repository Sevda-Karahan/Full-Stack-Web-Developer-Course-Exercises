using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg28
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            Console.WriteLine("Urun no: ");
            product1.urun_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Urun adı: ");
            product1.urun_adı = Console.ReadLine();
            Console.WriteLine("Urun rengi: ");
            product1.renk = Console.ReadLine();
            Console.WriteLine("Urun kdvsiz fiyatı: ");
            product1.fiyat = Convert.ToSingle(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Urun no: " + product1.urun_no);
            Console.WriteLine("Urun adı: " + product1.urun_adı);
            Console.WriteLine("Urun rengi: " + product1.renk);
            Console.WriteLine("Urun kdvsiz fiyatı: " + product1.fiyat);
            Console.WriteLine("Urun kdvli fiyatı: " + product1.kdvli_fiyat(product1.fiyat));

            Console.ReadLine();
        }
    }
}
