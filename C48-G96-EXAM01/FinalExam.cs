using ExamSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace C48_G96_EXAM01
{
    public class FinalExam : Exam
    {
        public FinalExam()
            : base()
        {
        }

        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            int totalGrade = 0;

            System.Console.WriteLine("===== Final Exam =====");
            System.Console.WriteLine($"Time: {Time} minutes");
            System.Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                System.Console.WriteLine($"Question {i + 1}");
                System.Console.WriteLine(question.Header);
                System.Console.WriteLine(question.Body);

                foreach (Answer answer in question.AnswerList)
                {
                    System.Console.WriteLine(answer);
                }

                System.Console.WriteLine(
                    $"Right Answer: {question.RightAnswer}"
                );

                totalGrade += question.Mark;

                System.Console.WriteLine(
                    $"Question Mark: {question.Mark}"
                );

                System.Console.WriteLine();
            }

            System.Console.WriteLine($"Total Grade: {totalGrade}");
        }
    }
}
