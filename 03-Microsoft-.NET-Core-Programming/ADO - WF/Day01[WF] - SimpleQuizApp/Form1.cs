namespace Day01_WF____SimpleQuizApp
{
    public partial class WelcomScreen : Form
    {
        public WelcomScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm(txt_username.Text);
            if (txt_username.Text.Trim() != "")
            {
                quizForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter your name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
