namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\CODES\FILES-2025-2026\C#\Text_Folders";
            string filePath = Path.Combine(directoryPath, "log.txt");
            string message = "This is a file entry";

            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message + "\n");
        }
    }
}
