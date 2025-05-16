using Microsoft.Data.SqlClient;
using System.Drawing;
namespace Day02_ADO__simpleCRUD
{
    public partial class CourseCRUDConnected : Form
    {
        SqlConnection connection;

        public CourseCRUDConnected()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=MUSTAFA7EGAZI;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmdCourses = new SqlCommand("select * FROM course", connection);
            SqlCommand cmdTpics = new SqlCommand("select * FROM topic", connection);
            connection.Open();

            SqlDataReader coursesReader = cmdCourses.ExecuteReader();

            List<Course> courses = new List<Course>();
            List<Topic> topics = new List<Topic>();

            while (coursesReader.Read())
            {
                Course course = new Course();
                course.crs_id = (int)coursesReader["crs_id"];
                course.crs_name = (string)coursesReader["crs_name"];
                course.crs_duration = (int)coursesReader["crs_duration"];

                course.top_id = coursesReader["top_id"] != DBNull.Value ? (int?)coursesReader["top_id"] : null;

                courses.Add(course);
            }
            coursesReader.Close();
            SqlDataReader topicsReader = cmdTpics.ExecuteReader();

            while (topicsReader.Read())
            {
                Topic topic = new Topic();
                topic.top_id = (int)topicsReader["top_id"];
                topic.top_name = (string)topicsReader["top_name"];
                topics.Add(topic);
            }


            topicsReader.Close();

            data_courses.DataSource = courses;
            cb_courses.DataSource = courses;
            cb_topic_add.DataSource = topics;
            cb_topic_delete.DataSource = topics;

            cb_courses.DisplayMember = "crs_name";
            cb_courses.ValueMember = "crs_id";

            cb_topic_add.DisplayMember = "top_name";
            cb_topic_add.ValueMember = "top_id";

            cb_topic_delete.DisplayMember = "top_name";
            cb_topic_delete.ValueMember = "top_id";

            connection.Close();

        }

        private void ShowNTierForm()
        {
            NTierForm ntierForm = new NTierForm();
            ntierForm.Show();
            Hide();
        }

        private void ShowDisconnectedForm()
        {
            CourseCRUDDisconnected courseCRUDDisconnected = new CourseCRUDDisconnected();
            courseCRUDDisconnected.Show();
            Hide();
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO course (crs_name, crs_duration, top_id) VALUES (@crs_name, @crs_duration, @top_id)", connection);
            cmd.Parameters.AddWithValue("@crs_name", txt_crs_name.Text);
            cmd.Parameters.AddWithValue("@crs_duration", int.Parse(txt_crs_duration.Text));
            cmd.Parameters.AddWithValue("@top_id", cb_topic_add.SelectedValue);


            connection.Open();

            int roweffect = cmd.ExecuteNonQuery();
            connection.Close();

            if (roweffect > 0)
            {
                txt_crs_name.Text = txt_crs_duration.Text = "";

                Form1_Load(null, null);
                MessageBox.Show("Successfully added new course");
            }
        }

        private void btn_remove_crs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this course?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from course where crs_id =@id", connection);
                cmd.Parameters.AddWithValue("@id", cb_courses.SelectedValue);
                connection.Open();

                int roweffect = cmd.ExecuteNonQuery();

                connection.Close();
                if (roweffect > 0)
                {

                    Form1_Load(null, null);
                    MessageBox.Show("course deleted successfully!");
                }
            }
        }

        private void btn_remove_topic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this topic with its child courses?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from topic where top_id =@id", connection);
                cmd.Parameters.AddWithValue("@id", cb_topic_delete.SelectedValue);
                connection.Open();

                int roweffect = cmd.ExecuteNonQuery();

                connection.Close();
                if (roweffect > 0)
                {

                    Form1_Load(null, null);
                    MessageBox.Show("topic deleted successfully!");
                }
            }
        }

        int selectedCourseId;
        private void btn_update_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Update course set crs_name=@name ,crs_duration=@duration ,top_id=@top  where crs_id=@id", connection);
            cmd.Parameters.AddWithValue("name", txt_crs_name.Text);
            cmd.Parameters.AddWithValue("duration", txt_crs_duration.Text);
            cmd.Parameters.AddWithValue("top", cb_topic_add.SelectedValue);
            cmd.Parameters.AddWithValue("id", selectedCourseId);
            connection.Open();
            int roweffect = cmd.ExecuteNonQuery();
            connection.Close();
            if (roweffect > 0)
            {
                Form1_Load(null, null);
                txt_crs_name.Text = txt_crs_duration.Text = "";
                btn_addnew.Visible = true;
                btn_update.Visible = false;
                MessageBox.Show("updated");
            }

        }

        private void data_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = data_courses.SelectedRows[0];
            selectedCourseId = (int)row.Cells[0].Value;
            txt_crs_name.Text = row.Cells[1].Value.ToString();
            txt_crs_duration.Text = row.Cells[2].Value.ToString();
            cb_topic_add.SelectedValue = row.Cells[3].Value == null ? 1 : row.Cells[3].Value;

            btn_addnew.Visible = false;
            btn_update.Visible = true;
        }

        private void lbl_goto_disconnected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowDisconnectedForm();
        }

        private void lbl_goto_ntier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowNTierForm();
        }

        
    }
}
