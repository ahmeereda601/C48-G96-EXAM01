using ExamSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace C48_G96_EXAM01
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        public Subject Subject { get; set; }

        protected Exam()
        {
        }

        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
        }

        public abstract void ShowExam();

        public object Clone()
        {
            Exam clonedExam = (Exam)this.MemberwiseClone();

            if (Questions != null)
            {
                clonedExam.Questions = new Question[Questions.Length];

                for (int i = 0; i < Questions.Length; i++)
                {
                    clonedExam.Questions[i] =
                        (Question)Questions[i].Clone();
                }
            }

            return clonedExam;
        }

        public int CompareTo(Exam other)
        {
            if (other == null)
                return 1;

            return NumberOfQuestions.CompareTo(other.NumberOfQuestions);
        }

        public override string ToString()
        {
            return $"Time: {Time} minutes, Questions: {NumberOfQuestions}";
        }
    }
}
