namespace QuizApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany", // Question Text
                    new string[] {"Paris", "Berlin", "London", "Madrid"}, // Answers Array
                    1 // Correct Answer Index
                ),
                new Question(
                    "What is 2 + 2",
                    new string[] { "3", "4", "5", "6" },
                    1
                ),
                new Question(
                    "Who wrote 'Hamblet'",
                    new string[] { "Goethe", "Austen", "Shakespeare", "Dickens"},
                    2
                )
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
