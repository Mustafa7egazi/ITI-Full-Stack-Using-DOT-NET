using System.Text;

namespace Day04
{
    internal class QuestionList : List<Question>
    {
        public static int fileCount = 0;
        public QuestionList()
        {
            fileCount++;
        }

        public void AddQuestion(Question question)
        {
            this.Add(question);
            string filePath = @"F:\ITI - ICC Master Repository\01-Software-Development-Fundamentals\Advanced C#\Labs\Day04\logs\" + $"file{fileCount}.txt";

            using (TextWriter textWriter = new StreamWriter(filePath, append: true))
            {
                textWriter.WriteLine($"Question: {question}");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var question in this)
            {
                sb.AppendLine(question.ToString());
            }
            return sb.ToString();
        }
    }
}
