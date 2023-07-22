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

            Console.WriteLine("Başta:");
            Console.WriteLine("Kapasite: " + personel.Capacity);
            Console.WriteLine("Eleman Sayısı: " + personel.Count);

            foreach (var item in personel)
            {
                Console.WriteLine(item);
            }

            personel.Insert(0,"Başa");
            personel.Insert(3, "Here");
            personel.Remove("Here");
            personel.Remove("Absent");

            //O indeksteki veriyi siler.
            personel.RemoveAt(0);
            

            Console.WriteLine("\nSonda:");
            Console.WriteLine("Kapasite: " + personel.Capacity);
            Console.WriteLine("Eleman Sayısı: " + personel.Count);

            //Bu verileri ekrana yazdırma
            foreach (var item in personel)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
