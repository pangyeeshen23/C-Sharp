﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp2
{
    public class Quiz
    {
        private readonly Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            this._score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1;
            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct !");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was : {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResutls();
        }

        private void DisplayResutls()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is : {_score} out of {_questions.Length}");

            double percentage = (double) _score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work !");
            }
            else if(percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good Effort !");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep Practicing");
            }
            Console.ResetColor();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(question.Description);

            for (int i = 0; i < question.Answers.Length; i ++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }
            Console.WriteLine("");
        }

        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.Write("Invalid choice. please enter a number between 1 and 4: ");
                input = Console.ReadLine();
            }
            return choice - 1;
        }
    }
}
