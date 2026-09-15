namespace C48_G96_EXAM01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new subject and exam by entering values.");

            int subjectId = ReadInt("Enter subject id: ");
            string subjectName = ReadString("Enter subject name: ");

            Subject subject = new Subject(subjectId, subjectName);

            int time = ReadInt("Enter exam time (minutes): ");
            int numberOfQuestions = ReadInt("Enter number of questions: ");

            FinalExam finalExam = new FinalExam(time, numberOfQuestions);

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"\n--- Question {i + 1} ---");

                string header = ReadString("Enter question header: ");
                string body = ReadString("Enter question body: ");
                int mark = ReadInt("Enter question mark: ");

                Console.WriteLine("Question type: 1 = True/False, 2 = MCQ");
                int qtype = ReadIntWithOptions("Choose type (1 or 2): ", new int[] { 1, 2 });

                if (qtype == 1)
                {
                    var q = new TrueFalseQuestion(header, body, mark);
                    Console.WriteLine("Choose correct answer: 1 = True, 2 = False");
                    int correct = ReadIntWithOptions("Correct answer id: ", new int[] { 1, 2 });
                    q.RightAnswer = q.AnswerList[correct - 1];
                    finalExam.Questions[i] = q;
                }
                else
                {
                    int opts = ReadInt("Enter number of options: ");
                    if (opts < 2) opts = 2;

                    Answer[] answers = new Answer[opts];

                    for (int j = 0; j < opts; j++)
                    {
                        string at = ReadString($"Option {j + 1} text: ");
                        answers[j] = new Answer(j + 1, at);
                    }

                    int correct = ReadIntInRange($"Enter correct option id (1-{opts}): ", 1, opts);

                    finalExam.Questions[i] =
                        new MCQQuestion(header, body, mark, answers, answers[correct - 1]);
                }
            }

            subject.CreateExam(finalExam);

            Console.WriteLine();
            Console.WriteLine(subject);
            Console.WriteLine();
            Console.WriteLine(subject.Exam);
            Console.WriteLine();
            subject.Exam.ShowExam();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int v))
                    return v;
                Console.WriteLine("Invalid number, try again.");
            }
        }

        private static int ReadIntWithOptions(string prompt, int[] options)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int v) && System.Array.Exists(options, o => o == v))
                    return v;
                Console.WriteLine("Invalid choice, try again.");
            }
        }

        private static int ReadIntInRange(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int v) && v >= min && v <= max)
                    return v;
                Console.WriteLine($"Enter a number between {min} and {max}.");
            }
        }

        private static string ReadString(string prompt)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            return input ?? string.Empty;
        }
    }
}

