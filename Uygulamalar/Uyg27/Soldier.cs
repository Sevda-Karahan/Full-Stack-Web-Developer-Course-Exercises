using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg27
{
    class Soldier
    {
        public string ad_soyad, rutbe, gorev_bolgesi, kan_grubu, hastalik_durumu, yas, meslek;

        public static void uyari()
        {
            Console.WriteLine("Kan grubu 0Rh- ve 0Rh+ olanlar 1 saat fazla uyusun!");
        }
        
        public static void rapor()
        {
            Console.WriteLine("Hastalığınız varsa cumartesi revir günüdür, bilginize!");
        }
    }
}
