using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg31
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        
        //abstract method
        public abstract void makeSound();


        protected string name;
        // abstract method
        public abstract string Name
        {
            get;
            set;
        }
    }
}
