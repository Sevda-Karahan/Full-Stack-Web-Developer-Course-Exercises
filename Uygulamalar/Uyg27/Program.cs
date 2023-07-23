using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg27
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier1 = new Soldier();
            Console.WriteLine("Ad soyad: ");
            soldier1.ad_soyad = Console.ReadLine();
            Console.WriteLine("Rutbe: ");
            soldier1.rutbe = Console.ReadLine();
            Console.WriteLine("Görev bölgesi: ");
            soldier1.gorev_bolgesi = Console.ReadLine();
            Console.WriteLine("Kan grubu: ");
            soldier1.kan_grubu = Console.ReadLine();
            Console.WriteLine("Hastalık durumu: ");
            soldier1.hastalik_durumu = Console.ReadLine();
            Console.WriteLine("Yas: ");
            soldier1.yas = Console.ReadLine();
            Console.WriteLine("Meslek: ");
            soldier1.meslek = Console.ReadLine();

            Soldier.uyari();
            Soldier.rapor();

            Console.Clear();
            Console.WriteLine("Ad soyad: " + soldier1.ad_soyad);
            Console.WriteLine("Rutbe: " + soldier1.rutbe);
            Console.WriteLine("Görev bölgesi: " + soldier1.gorev_bolgesi);
            Console.WriteLine("Kan grubu: " + soldier1.kan_grubu);
            Console.WriteLine("Hastalık durumu: " + soldier1.hastalik_durumu);
            Console.WriteLine("Yas: " + soldier1.yas);
            Console.WriteLine("Meslek: " + soldier1.meslek);

            Console.ReadLine();
        }
    }
}
