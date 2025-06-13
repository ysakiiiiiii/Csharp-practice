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

            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with  error handling");
                } catch (Exception ex)
                {
                    Console.WriteLine($"Exeption Caught : {ex.Message}");
                }
            }

            if(IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("Log to File Remove");
            }
            else
            {
                Console.WriteLine("Log to File Method not Found");
            }

            InvokeSafely(logHandler, "After removing from the file");


        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }


        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if (logHandler == null)
            {
                return false;
            }

            foreach (var d in logHandler.GetInvocationList())   
            {
                if (d == (Delegate) method)
                    {
                        return true;
                    }
                

            }

            return false;
        } 
    }
}
