using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme (Encapsulation)
            Customer customer1 = new Customer();
            Console.WriteLine("Müşteri no: ");
            customer1.Customer_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri adı: ");
            customer1.Customer_name = Console.ReadLine();
            Console.WriteLine("Bakiye giriniz: ");
            customer1.Balance = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Müşteri no: " + customer1.Customer_no);
            Console.WriteLine("Müşteri adı: " + customer1.Customer_name);
            Console.WriteLine("Müşteri bakiye: " + customer1.Balance);

            Console.ReadLine();
        }
    }
}
