using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4
{
    class Program
    {
        static void Main(string[] args)
        {
            //if-else-switch
            //kullanıcıdan alınan kullanıcı adı ve şifre doğru ise giriş sayfasına yönlendirilsin

            string kad = "sevda";
            string sifre = "123";

            Console.WriteLine("kullanıcı adı:");
            string kad2 = Console.ReadLine();

            Console.WriteLine("şifre:");
            string sifre2 = Console.ReadLine();

            if (kad == kad2 && sifre == sifre2)
            {
                Console.WriteLine("Giris ekranına hoş geldiniz!");
            }
            else {
                Console.WriteLine("Hatalı giriş!");
            }
            Console.ReadLine();
        }
    }
}
