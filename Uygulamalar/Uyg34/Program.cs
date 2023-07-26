using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg34
{
    class Program
    {
        //POLYMORPHISM -> Overriding
        static void Main(string[] args)
        {
            // obj1 is the object of Polygon class
            Polygon obj1 = new Polygon();
            // calls render() method of Polygon Superclass 
            obj1.render();

            Console.WriteLine("***********************************");

            // here, obj2 is the object of derived class Square 
            Polygon obj2 = new Square();
            // calls render() method of derived class Square
            obj2.render();

            Console.ReadLine();
        }
    }
}
