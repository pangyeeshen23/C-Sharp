using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp2
{
    public class Question
    {
        public string Description { get; }
        public string[] Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string description, string[] answers, int answerIndex)
        {
            Description = description;
            Answers = answers;
            CorrectAnswerIndex = answerIndex;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return choice == CorrectAnswerIndex;
        }
    }
}
