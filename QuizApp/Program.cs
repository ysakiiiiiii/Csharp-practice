namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the Capital of the Philippines?",
                    new string[] {"Bulacan", "Palawan", "Manila", "Bacarra"},
                    2
                ),

                new Question(
                
                    "What is the constitution in 1973?",
                    new string[] {"Malolos", "Martial Law", "Puppet Republic", "CommonWealth"},
                    1
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}
