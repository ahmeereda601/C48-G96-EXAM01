using ExamSystem;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace C48_G96_EXAM01
{
   
        public class TrueFalseQuestion : Question
        {
            public TrueFalseQuestion()
                : base()
            {
            }

            public TrueFalseQuestion(string header, string body, int mark)
                : base(header, body, mark)
            {
                AnswerList = new Answer[]
                {
                new Answer(1, "True"),
                new Answer(2, "False")
                };
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

