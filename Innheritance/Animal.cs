using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innheritance
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound");
        }


    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }

        public new void  MakeSound()
        {
            Console.WriteLine("Bark...");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow...");
        }

        public override void Eat()
        {
            Console.WriteLine("Meowrk meowrk...");
        }
    }
}