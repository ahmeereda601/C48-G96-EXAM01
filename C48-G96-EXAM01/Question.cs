using C48_G96_EXAM01;

namespace ExamSystem
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }

        public Answer RightAnswer { get; set; }

        protected Question()
        {
        }

        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void Display();

        public object Clone()
        {
            Question clonedQuestion = (Question)this.MemberwiseClone();

            if (AnswerList != null)
            {
                clonedQuestion.AnswerList = new Answer[AnswerList.Length];

                for (int i = 0; i < AnswerList.Length; i++)
                {
                    clonedQuestion.AnswerList[i] =
                        new Answer(
                            AnswerList[i].AnswerId,
                            AnswerList[i].AnswerText
                        );
                }
            }

            if (RightAnswer != null)
            {
                clonedQuestion.RightAnswer =
                    new Answer(
                        RightAnswer.AnswerId,
                        RightAnswer.AnswerText
                    );
            }

            return clonedQuestion;
        }

        public int CompareTo(Question other)
        {
            if (other == null)
                return 1;

            return Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"{Header}: {Body} - Mark = {Mark}";
        }
    }
}