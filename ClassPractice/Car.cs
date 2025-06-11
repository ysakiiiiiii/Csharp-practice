using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Car
    {
        private string _model;
        private string _brand;

        private bool _isLuxury;
        public string Model { get => _model; 
            set { _model = value ?? "DEFAULT VALUE"; }
        }
        public string Brand { 
            get
            {
                if (_isLuxury)
                {
                    return _brand + " [Luxury Edition] ";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {   
                if (string.IsNullOrEmpty(value)){
                    Console.WriteLine("You entered NOTHING");
                    _brand = "DEFAULT";
                }else{

                    _brand = value;

                }
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public Car(string brand, string model, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
                
            Console.WriteLine($"{Brand} : {Model} has been Created");

        }

        public void Drive()
        {
            Console.WriteLine("I'm driving");
        }

    }
}
