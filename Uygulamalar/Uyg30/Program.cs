using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg30
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            Console.WriteLine("Tc no: ");
            student.Tc_no = Console.ReadLine();
            Console.WriteLine("Ogrenci no: ");
            student.Ogrenci_no = Console.ReadLine();
            Console.WriteLine("Ogrenci adı: ");
            student.ad_soyad = Console.ReadLine();
            Console.WriteLine("Ogrenci notu: ");
            student.Not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ogrenci bursu: ");
            student.burs = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            
        }
    }
}
