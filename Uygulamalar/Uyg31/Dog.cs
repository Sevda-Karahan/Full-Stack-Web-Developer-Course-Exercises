using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg31
{   
    // inheriting from abstract class
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }

        //provide implementation of abstract class
        public override void makeSound()
        {
            Console.WriteLine("Bark Bark");
        }

        // provide implementation of abstract method
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
