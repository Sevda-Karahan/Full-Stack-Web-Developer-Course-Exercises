using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dinamik Diziler
            ArrayList personel = new ArrayList();
            personel.Add("Sevda");
            personel.Add(21);
            personel.Add('K');
            personel.Add(95.6f);

            //Bu verileri ekrana yazdırma
            foreach (var item in personel)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
