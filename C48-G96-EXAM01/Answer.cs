using System;
using System.Collections.Generic;
using System.Text;

namespace C48_G96_EXAM01
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer()
        {
        }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }
    }
}
