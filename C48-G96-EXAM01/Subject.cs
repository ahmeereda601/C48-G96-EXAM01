using System;
using System.Collections.Generic;
using System.Text;

namespace C48_G96_EXAM01
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public Exam Exam { get; set; }

        public Subject()
        {
        }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
            Exam.Subject = this;
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Subject Name: {SubjectName}";
        }
    }
}
