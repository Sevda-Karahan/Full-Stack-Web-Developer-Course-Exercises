using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] id_no = { "452", "453", "454", "455" };
            string[] adlar = { "Ali", "Hasan", "Ayşe", "Fatma" };
            string[] telefon = { "123", "456", "789", "1011" };

            Console.WriteLine("Personel no giriniz: ");
            string girdi = Console.ReadLine();

            int index = Array.IndexOf(id_no, girdi);
            if(index != -1)
            {
                Console.WriteLine(girdi + "  nolu personel bilgileri: ");
                Console.WriteLine("İsim: " + adlar[index]);
                Console.WriteLine("Telefon no: " + telefon[index]);
            }
            else
            {
                Console.WriteLine("Bu personel numarasına sahip herhangi bir personel bulunamadı...");
            }
            Console.ReadLine();
        }
    }
}
