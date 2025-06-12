namespace FileHandling
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\CODES\FILES-2025-2026\C#\Text_Folders";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath, message + "\n");

        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging into the Databse : {message} ");
        }
    }
     
    public class Application
    {   
        private readonly ILogger _ilogger;
        public Application(ILogger logger)
        {
            _ilogger = logger;
        }

        public void loggerMethod(string message)
        {
            _ilogger.Log(message);

            Console.WriteLine("Done Logging the Text...");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application application = new Application(fileLogger);
            application.loggerMethod("Sample File text");

            ILogger databaseLogger = new DatabaseLogger();
            application = new Application(databaseLogger);
            application.loggerMethod("Sample Database text");
        }
    }
}
