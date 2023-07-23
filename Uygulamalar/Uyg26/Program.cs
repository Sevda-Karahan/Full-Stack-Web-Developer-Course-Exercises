using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg26
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine("Öğrenci no giriniz: ");
            student1.ogrenci_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrenci adı soyadı giriniz: ");
            student1.ad_soyad = Console.ReadLine();

            Console.WriteLine("Öğrenci ortalama giriniz: ");
            student1.ort = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Öğrenci branşı giriniz: ");
            student1.brans = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Öğrenci no: " + student1.ogrenci_no);
            Console.WriteLine("Öğrenci adı soyadı: " + student1.ad_soyad);
            Console.WriteLine("Öğrenci ortalama: " + student1.ort);
            Console.WriteLine("Öğrenci branşı: " + student1.brans);
            Student.Burs();
            Console.ReadLine();
        }
    }
}
