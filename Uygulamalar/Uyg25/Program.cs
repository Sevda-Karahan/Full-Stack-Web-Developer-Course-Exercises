using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                //CLASSES
namespace Uyg25
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.ad_soyad = "Sevda Karahan";
            person1.boy = 166;
            person1.kilo = 60;
            person1.adres = "Türkiye";

            Console.WriteLine("Ad soyad: " + person1.ad_soyad);
            Console.WriteLine("Boy: " + person1.boy);
            Console.WriteLine("Kilo: " + person1.kilo);
            Console.WriteLine("Adres: " + person1.adres);

            Console.ReadLine();
        }
    }
}
