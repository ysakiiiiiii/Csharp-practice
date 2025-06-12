using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Vehicle
    {
        public abstract void startEngine();
    }

     class Car : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Needs to be override");
        }
          
    }
}
