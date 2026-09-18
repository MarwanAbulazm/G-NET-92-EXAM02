using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_92_EXAM02
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            Console.WriteLine("Enter the type of exam (1 for Practical, 2 for Final):");
            int examType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the time for the exam (30 to 180 minutes):");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of questions:");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Question[] questions = new Question[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                if (examType == 1)
                {
                    questions[i] = CreateMCQQuestion();
                }
                else if(examType == 2)
                {
                    Console.WriteLine($"Enter details for question {i + 1}:");
                    Console.WriteLine("Choose question type: 1 for MCQ, 2 for True/False:");
                    int questionType = int.Parse(Console.ReadLine());

                    if (questionType == 1)
                    { 
                        questions[i] = CreateMCQQuestion();
                    }
                    else if(questionType == 2)
                    {
                        questions[i] = CreateTrueFalseQuestion();
                    }
                }
            }

            if (examType == 1)
            {
                Exam = new PracticalExam(time, numberOfQuestions, questions);
            }
            else if(examType == 2)
            {
                Exam = new FinalExam(time, numberOfQuestions, questions);
            }
        }

        private MCQQuestion CreateMCQQuestion()
        {
            Console.WriteLine("Please enter the question body:");
            string body = Console.ReadLine();

            Console.WriteLine("Please enter the question mark:");
            int mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Choices of Question:");
            Answer[] answers = new Answer[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Please enter choice number {i + 1}:");
                string text = Console.ReadLine();
                answers[i] = new Answer(i + 1, text);
            }

            Console.WriteLine("Please enter the ID of the correct answer (1 to 4):");
            int correctId = int.Parse(Console.ReadLine());

            string header = body;
            return new MCQQuestion(header, body, mark, answers, correctId);
        }

        private TrueFalseQuestion CreateTrueFalseQuestion()
        {
            Console.WriteLine("Please enter the question body:");
            string body = Console.ReadLine();

            Console.WriteLine("Please enter the question mark:");
            int mark = int.Parse(Console.ReadLine());

            Answer[] answers = new Answer[2];
            answers[0] = new Answer(1, "True");
            answers[1] = new Answer(2, "False");

            Console.WriteLine("Please enter the ID of the correct answer (1 for True, 2 for False):");
            int correctId = int.Parse(Console.ReadLine());

            string header = body;
            return new TrueFalseQuestion(header, body, mark, answers, correctId);
        }
    }
}
