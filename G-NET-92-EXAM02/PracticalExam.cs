using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace G_NET_92_EXAM02
{
    internal class PracticalExam : Exam
    {

        public PracticalExam(int time, int numberOfQuestions, Question[] questions): base(time, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            StudentAnswers = new int[Questions.Length];

            Console.WriteLine("Practical Exam");
            for (int i = 0; i < Questions.Length; i++)
            {
                Question q = Questions[i];
                Console.WriteLine($"Question {i + 1}: {q.Body}");
                Console.WriteLine($"MCQ Question: Mark {q.Mark}");

                foreach (Answer a in q.AnswerList)
                {
                   Console.WriteLine($"{a.AnswerId}- {a.AnswerText}");
                }

                Console.WriteLine("Enter your answer ID:");
                StudentAnswers[i] = int.Parse(Console.ReadLine());
            }

            stopwatch.Stop();

            Console.WriteLine(); 

            Console.WriteLine("Practical Exam Results: ");
            for (int i = 0; i < Questions.Length; i++)
            {
                Question q = Questions[i];
                Console.WriteLine($"Question {i + 1}: {q.Body}");
                Console.WriteLine($"Your Answer => {GetAnswerText(q, StudentAnswers[i])}");
                Console.WriteLine($"Correct Answer => {GetAnswerText(q, q.CorrectAnswerId)}");
                Console.WriteLine();
            }

            Console.WriteLine($"Your Grade is {CalculateGrade()} from {GetTotalMark()}");
            Console.WriteLine($"Time = {stopwatch.Elapsed}");
            Console.WriteLine("Thank you");
        }
    }
}
