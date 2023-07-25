using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg30
{
    class Student
    {
        private string tc_no, ogrenci_no;
        public string ad_soyad;
        private int not;
        public int burs;

        public string Tc_no
        {
            get
            {
                return tc_no;
            }
            set
            {
                if (value.Length == 11)
                {
                    tc_no = value;
                }
                else
                {
                    Console.WriteLine("TC no 11 haneli olmalıdır!");
                    Console.WriteLine("TC no: ");
                    Tc_no = Console.ReadLine();
                }
            }
        }

        public string Ogrenci_no
        {
            get
            {
                return ogrenci_no;
            }
            set
            {
                if (value.Length == 4)
                {
                    ogrenci_no = value;
                }
                else
                {
                    Console.WriteLine("Öğrenci no 4 haneli olmalıdır!");
                    Console.WriteLine("Öğrenci no: ");
                    Ogrenci_no = Console.ReadLine();
                }
            }
        }

        public int Not
        {
            get
            {
                return not;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    not = value;
                }
                else
                {
                    Console.WriteLine("Not 0-100 aralığında olmalıdır!");
                    Console.WriteLine("Öğrenci notu: ");
                    Not = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
