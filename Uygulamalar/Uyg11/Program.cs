﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try-Catch
            git:
            try
            {
                Console.WriteLine("1. sayıyı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. sayıyı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Hatalı giriş yaptınız, lütfen sayısal bir değer giriniz!");
                goto git;
            }
            Console.ReadLine();
        }
    }
}
