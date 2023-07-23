using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            -Girilen fiyat ve oran miktarı üzerinden zam yapan method olsun
            -Girilen fiyat değeri 1000 TL ve üzeri ise girilen oran miktarı üzerinden indirim 
            değilse 100 TL indirim yapan bir method
            -Ana ekranda ürün seçimi yapılsın 1-çanta 2-ayakkabı 3-mont, fiyat ve oran girişi istensin
            -Çanta ve mont seçti ise zam ayakkabı seçti ise indirim uygulansın
             */
            Console.WriteLine("Seçim Ekranı");
            Console.WriteLine("1-çanta\n2-ayakkabı\n3-mont");
            int secim = Convert.ToInt32(Console.ReadLine());                                                                   
        }
    }
}
