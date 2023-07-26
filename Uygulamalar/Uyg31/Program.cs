using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg31
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABSTRACTION

            //create an object of Dog class
            Dog obj = new Dog();
            obj.makeSound();

            obj.Name = "Tom";
            Console.WriteLine("Name: " + obj.Name);

            Console.ReadLine();
        }
    }
}
