namespace CastingDelegates
{   

    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Console message : {message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"File message : {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            logHandler("Log this info");
        }
    }
}
