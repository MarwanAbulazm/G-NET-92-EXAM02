using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_92_EXAM02
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public int[] StudentAnswers { get; set; }

        public Exam(int time, int numberOfQuestions, Question[] questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public abstract void ShowExam();
        protected string GetAnswerText(Question question, int answerId)
        {
            foreach (Answer a in question.AnswerList)
            {
                if (a.AnswerId == answerId)
                {
                   return a.AnswerText;
                }
            }
            return "";
        }

        protected int CalculateGrade()
        {
            int grade = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                if (StudentAnswers[i] == Questions[i].CorrectAnswerId)
                {
                   grade += Questions[i].Mark;
                }
            }
            return grade;
        }

        protected int GetTotalMark()
        {
            int total = 0;
            foreach (Question q in Questions)
            {
               total += q.Mark;
            }
            return total;
        }
    }
}
