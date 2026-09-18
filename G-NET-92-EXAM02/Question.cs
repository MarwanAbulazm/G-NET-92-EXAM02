using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_92_EXAM02
{
    internal abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public int CorrectAnswerId { get; set; }

        public Question(string header, string body, int mark, Answer[] answerList, int correctAnswerId)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            CorrectAnswerId = correctAnswerId;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Question other)
        {
            return this.Mark.CompareTo(other.Mark);
        }
    }
}
