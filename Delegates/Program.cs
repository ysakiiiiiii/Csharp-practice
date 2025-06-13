namespace Delegates
{
    internal class Program
    {
        public delegate void Notify(string message);
        static void Main(string[] args)
        {

            Notify notifyDelegate = ShowMessage;
            //Notify notify = new Notify(notifyDelegate);

            notifyDelegate("Hello Delegates");
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
