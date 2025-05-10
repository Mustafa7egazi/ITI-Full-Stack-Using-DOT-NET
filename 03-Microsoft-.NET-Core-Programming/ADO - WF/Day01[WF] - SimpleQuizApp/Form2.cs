namespace Day01_WF____SimpleQuizApp
{
    public partial class QuizForm : Form
    {
        private string? username;
        private List<(string question, string[] options, int correctIndex)> questions;
        private List<int> userAnswers;
        public QuizForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadQuestions();
        }
        private void LoadQuestions()
        {
            questions = new List<(string, string[], int)>
    {
        ("Capital of Egypt?", new[] { "Cairo", "Alexandria", "Luxor", "Aswan" }, 0),
        ("5 + 3 = ?", new[] { "6", "7", "8", "9" }, 2),
        ("Which is a programming language?", new[] { "Python", "Snake", "Lizard", "Cobra" }, 0),
        ("Sun rises from?", new[] { "West", "East", "North", "South" }, 1),
        ("2 * 6 = ?", new[] { "10", "12", "14", "16" }, 1),
        ("What is H2O?", new[] { "Oxygen", "Hydrogen", "Water", "Helium" }, 2),
        ("Color of the sky?", new[] { "Green", "Blue", "Red", "Yellow" }, 1),
        ("Which one is an animal?", new[] { "Rock", "Car", "Lion", "Chair" }, 2),
        ("Result of 9 - 4?", new[] { "3", "4", "5", "6" }, 2),
        ("Fastest land animal?", new[] { "Tiger", "Horse", "Cheetah", "Elephant" }, 2),
    };

            userAnswers = Enumerable.Repeat(-1, questions.Count).ToList();

            for (int i = 0; i < questions.Count; i++)
            {
                GroupBox groupBox = new GroupBox
                {
                    Text = $"Q{i + 1}: {questions[i].Item1}",
                    Width = 800,
                    Height = 100,
                    AutoSize = false
                };

                for (int j = 0; j < questions[i].Item2.Length; j++)
                {
                    RadioButton rb = new RadioButton
                    {
                        Text = questions[i].Item2[j],
                        Tag = $"{i}_{j}",
                        AutoSize = true,
                        Location = new Point(10 + j * 140, 30),
                    };
                    rb.CheckedChanged += RadioButton_CheckedChanged;
                    groupBox.Controls.Add(rb);
                }

                flowPanelQuestions.Controls.Add(groupBox);
            }

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                int qIndex = int.Parse(rb.Tag.ToString().Split('_')[0]);
                int ansIndex = int.Parse(rb.Tag.ToString().Split('_')[1]);
                userAnswers[qIndex] = ansIndex;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (userAnswers.Contains(-1))
            {
                MessageBox.Show("Please answer all questions.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int score = 0;
            foreach (var item in questions)
            {
                int index = questions.IndexOf(item);
                if (userAnswers[index] == item.correctIndex)
                {
                    score++;
                }
            }

            string result = $"Hello {username}, your score is {score} out of {questions.Count}.";
            MessageBox.Show(result, "Quiz Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
