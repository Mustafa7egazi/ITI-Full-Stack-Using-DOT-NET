namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Try QuestionList*/

            QuestionList questionList = new QuestionList();
            questionList.AddQuestion(new Question(1, "Header 1", "Body 1"));
            questionList.AddQuestion(new Question(2, "Header 2", "Body 2"));

            QuestionList questionList2 = new QuestionList();
            questionList2.AddQuestion(new Question(3, "Header 3", "Body 3"));
            questionList2.AddQuestion(new Question(4, "Header 4", "Body 4"));


            List<Answer> answers = new List<Answer>()
                {
                    new Answer(1, "Answer 1"),
                    new Answer(2, "Answer 2"),
                    new Answer(3, "Answer 3"),
                    new Answer(4, "Answer 4"),
                };



            Dictionary<Question, List<Answer>> exam = new Dictionary<Question, List<Answer>>();
            exam.Add(new Question(1, "Question 1", "What is your name?"), answers);
            exam.Add(new Question(2, "Question 2", "What is your age?"), answers);
            exam.Add(new Question(3, "Question 3", "What is your favorite color?"), answers);

            foreach (KeyValuePair<Question, List<Answer>> question in exam)
            {
                Console.WriteLine(question.Key);
                foreach (var answer in question.Value)
                {
                    Console.WriteLine(answer);
                }
                Console.WriteLine("-------------------------");
            }

        }
    }
}
