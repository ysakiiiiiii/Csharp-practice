using System; // Importing the System namespace

namespace Coding.Exercise // Defining the Coding.Exercise namespace
{
    // Define the delegate that will be used for the event
    public delegate void StockPriceChangedHandler(string message);

    // Define the Stock class which includes the event system
    public class Stock
    {
        // Declare the event using the delegate
        public event StockPriceChangedHandler OnStockPriceChanged;

        // Private field to store the stock price
        private decimal _price;
        // Private field to store the threshold
        private decimal _threshold;
        //TODO

        // Property to get and set the stock price
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (value < _threshold)
                {
                    RaiseStockPriceChangedEvent($"Stock Alert: Stock price [ {_price} ] is below threshold [ {_threshold} ]!");

                }
            }
            // Set the new price
            // Raise the event if the price drops below the threshold
            //TODO

        }

        // Property to get and set the alert threshold
        public decimal Threshold
        {
            get { return _threshold; }
            set
            {
                _threshold = value;
            }
            //TODO
        }

        // Method to raise the stock price changed event
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            // Invoke the event
            //TODO
            OnStockPriceChanged?.Invoke(message);
        }
    }

    // Define the subscriber class which reacts to the event
    public class StockAlert
    {
        // Method that handles the event and prints a message to the console
        //TODO
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Program class to simulate the stock price changes and test the event system
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Stock and StockAlert
            //TODO
            Stock stock = new Stock();
            StockAlert alert = new StockAlert();

            // Subscribe to the stock price changed event
            //TODO
            stock.OnStockPriceChanged += alert.OnStockPriceChanged;

            // Set the alert threshold
            //TODO
            stock.Threshold = 120;
            // Simulate stock price changes
            //TODO
            stock.Price = 150;
            stock.Price = 130;
            stock.Price = 110;

            // Wait for user input to close the console
            //TODO
            Console.ReadKey();
        }
    }
}
