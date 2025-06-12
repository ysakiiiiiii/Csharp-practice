namespace List
{

    public class Product
    {
        public string Name { get; set; }
        public double  Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           List<Product> products = new List<Product>
           {
               new Product{Name = "Apple", Price = 3.99},
               new Product{Name = "Bananas", Price = 1.99},
               new Product{Name = "Berries", Price = 3.23},

           };
            products.Add(new Product { Name = "Berries", Price = 1.99 });

            List<Product> cheapProducts = products.Where(p => p.Price <2.00).ToList();

            Console.WriteLine("Cheap Products");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"\nProduct : {product.Name}\nPrice : {product.Price} ");
            }
        


            Console.WriteLine("Available Products");

            foreach (Product product in products)
            {
                Console.WriteLine($"\nProduct : {product.Name}\nPrice : {product.Price} ");
            }
        }
    }
}
