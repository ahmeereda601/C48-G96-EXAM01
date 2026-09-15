using ExamSystem;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace C48_G96_EXAM01
{
    public class MCQQuestion : Question
    {
        public MCQQuestion()
            : base()
        {
        }

        public MCQQuestion(
            string header,
            string body,
            int mark,
            Answer[] answers,
            Answer rightAnswer)
            : base(header, body, mark)
        {
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }

        public override void Display()
        {
            System.Console.WriteLine(Header);
            System.Console.WriteLine(Body);

            foreach (Answer answer in AnswerList)
            {
                System.Console.WriteLine(answer);
            }
        }
    }
}
