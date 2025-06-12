namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car ("BMW", "Excellent", 2006);

            car.DisplayCarInfo();
            car.StartEngine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {Age} years old");
        }
    }

    public class Employee : Person
    {
        public Employee(string name, int age) : base(name, age)
        {
            
        }

    }
}
