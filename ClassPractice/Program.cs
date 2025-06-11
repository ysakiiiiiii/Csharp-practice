namespace ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer lucky = new Customer("Lucky");

            //Customer customer = new Customer();

            //Console.Write("Enter name : ");
            //string name = Console.ReadLine();

            //Console.Write("Enter address : ");
            //string address = Console.ReadLine();

            //customer.setDetails(name, address, "123456789");

            //customer.showDetails();

            Customer customer = new Customer("Lucky", "Bacarra");
            Customer customer1 = new Customer("Francis", "Bacarra");
            Customer customer2 = new Customer("Lucy", "Bacarra");

            customer.showDetails();
            customer1.showDetails();
            customer2.showDetails();

            Console.WriteLine($"The ID of {customer.Name} is {customer.Id}");



            Console.WriteLine($"Contact number of {customer.Name} is {customer.ContactNumber}");
        }
    }
}
