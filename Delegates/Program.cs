namespace Delegates
{
    public delegate void Notify(string message);
    
    public class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine($"Event Raise : {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised;

            publisher.RaiseEvent("test");

        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
