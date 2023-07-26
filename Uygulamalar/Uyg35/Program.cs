using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg34
{
    class Program
    {
        //INHERITANCE
        static void Main(string[] args)
        {
            //object of derived class
            Dog labrador = new Dog();

            //access field and method of base class
            labrador.name = "Rohu";
            labrador.display();

            //access method from own class
            labrador.getName();

            Console.ReadLine();
        }
    }
}
