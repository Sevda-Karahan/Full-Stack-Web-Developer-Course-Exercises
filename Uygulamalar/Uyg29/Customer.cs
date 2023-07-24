using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg29
{
    class Customer
    {
        private int customer_no=0;
        private string customer_name;
        float balance=0; //varsayılan erişim şekli private olduğu için, private yazılmaması hataya sebep olmaz.

        public int Customer_no
        {
            get
            {
                return customer_no;
            }
            set
            {
                if(value>=2 && value <= 100)
                {
                    customer_no = value;
                }
                else
                {
                    Console.WriteLine("2 ile 100 arasında değer giriniz.");
                }
            }
        }

        public string Customer_name
        {
            get;
            set;
        }

        public float Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value>=1000 && value <= 2000)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Bakiyeniz 1000-2000 arasında olmalı, bakiyenizi güncellemelisiniz!");
                }
            }
        }

    }
}
