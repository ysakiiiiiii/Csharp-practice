using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Vehicle
    {
        public abstract void startEngine();

    }

    partial class Engine
    {
        public string Model { get; set; }
        public string Status { get; set; }

        public Engine(string model, string status)
        {
            Model = model;
            Status = status;
        }

        public void DisplayEngineInfo()
        {
            Console.WriteLine("Engine Base Class Called...");
            Console.WriteLine($"Model:{Model} - {Status}");
        }
    }
    class Car : Engine
    {
        public int ManufacturingDate { get; set; }
        public Car(string model, string status, int date) : base(model, status)
         {
            ManufacturingDate = date;
         }


        public void DisplayCarInfo()
        {
            Console.WriteLine("Car constructor called");
            DisplayEngineInfo();
            Console.WriteLine($"Manufacturing Date : {ManufacturingDate}");
        }
    }

    partial class Engine {

        public void StartEngine()
        {
            Console.WriteLine("Starting engine");
        }
    }


}
