namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int> {12,42,23,84};

            bool hasLargeNumbers = numbers.Any(x => x > 20);

            if (hasLargeNumbers)
            {
                Console.WriteLine("There is a large number");
            }
            else
            {
                Console.WriteLine("No large numbers in the list");
            }
        }
    }
}
