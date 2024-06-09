namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions[] questions = new Questions[]
            {
                new Questions("How many stars in the Philippine flag?", // Question Text
                new string[] {"one", "seven", "three", "nine"}, // Answer selection array
                2), // Correct answer index
                new Questions("What is the capital of the Philippines?", // Question Text
                new string[] {"Manila", "Cubao", "Cebu", "Davao"}, // Answer selection array
                0),
                new Questions("Who discovered the Philippines?", // Question Text
                new string[] {"Lapu-Lapu", "Alexander the Great", "Vasco de Gama", "Magellan"}, // Answer selection array
                3),
            };

           Quiz q = new Quiz(questions);
           q.StartQuiz();
           Console.ReadLine();

        }
    }
}
