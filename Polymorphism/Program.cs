namespace Polymorphism
{   
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card Paymount of {amount}");
        }
    }

    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Paypal Paymount of {amount}");
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;
        public PaymentService(IPaymentProcessor processor) 
        {
            _processor = processor;
        }

        public void ProcessPayment(decimal amount) 
        { 
            _processor.ProcessPayment(amount);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCarProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCarProcessor);
            paymentService.ProcessPayment(100.00m);

            IPaymentProcessor paypalProcessor = new PaypalProcessor();
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessPayment(120.00m);
        }
    }
}
