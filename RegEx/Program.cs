using System; // Importing the System namespace
using System.Text.RegularExpressions; // Importing the System.Text.RegularExpressions namespace

namespace Coding.Exercise // Defining the Coding.Exercise namespace
{
    public class Exercise // Defining the Exercise class
    {
        // Method to extract and print email addresses from the input string
        public void ExtractPatterns(string input)
        {
            // Define the regex pattern for matching email addresses
            string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            // Find all matches of the regex pattern in the input string
            MatchCollection matches = Regex.Matches(input, pattern);

            // Iterate over the matches and print each matched email address
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }

    // Entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Sample input string
            string input = "Please contact us at support@example.com or sales@example.org for assistance.";

            // Create an instance of Exercise and call the method
            Exercise exercise = new Exercise();
            exercise.ExtractPatterns(input);
        }
    }
}
