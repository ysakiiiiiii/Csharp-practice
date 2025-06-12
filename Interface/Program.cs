namespace Interface
{   
    public interface IAnimal
    {
        void Bark();
    }


    public class Dog : IAnimal
    {
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
        }
    }
}
