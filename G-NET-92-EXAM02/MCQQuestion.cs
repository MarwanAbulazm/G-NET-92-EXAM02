using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_92_EXAM02
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answerList, int correctAnswerId) : base(header, body, mark, answerList, correctAnswerId)
        {
        }
    }
}
