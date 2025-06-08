using AppConsumer.Models;
using System.Net;

namespace AppConsumer
{
    public partial class Form1 : Form
    {
        HttpClient client;
        int selectedCourseId;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage res = client.GetAsync("https://localhost:7026/api/courses").Result;
            if (res.IsSuccessStatusCode)
            {
                dgv_courses.DataSource = res.Content.ReadAsAsync<List<Course>>().Result;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_add.Enabled = true;
            }

        }

        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedRow = dgv_courses.SelectedRows[0];

            selectedCourseId = Convert.ToInt32(selectedRow.Cells[0].Value);
            txt_crs_name.Text = selectedRow.Cells[1].Value.ToString();
            txt_crs_desc.Text = selectedRow.Cells[2].Value.ToString();
            txt_crs_duration.Text = selectedRow.Cells[3].Value.ToString();

            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_add.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Course c = new Course
            {
                Crs_name = txt_crs_name.Text,
                Crs_desc = txt_crs_desc.Text,
                Crs_duration = Convert.ToInt32(txt_crs_duration.Text)
            };


            HttpResponseMessage res = client.PostAsJsonAsync("https://localhost:7026/api/courses", c).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Course added successfully");
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Error adding course: " + res.ReasonPhrase);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            HttpResponseMessage res = client.GetAsync($"https://localhost:7026/api/courses/{selectedCourseId}").Result;
            if (res.IsSuccessStatusCode)
            {
                Course c = res.Content.ReadAsAsync<Course>().Result;
                c.Crs_name = txt_crs_name.Text;
                c.Crs_desc = txt_crs_desc.Text;
                c.Crs_duration = Convert.ToInt32(txt_crs_duration.Text);
                HttpResponseMessage updateRes = client.PutAsJsonAsync($"https://localhost:7026/api/courses/{selectedCourseId}", c).Result;
                if (updateRes.IsSuccessStatusCode)
                {
                    MessageBox.Show("Course updated successfully");
                    Form1_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error updating course: " + updateRes.ReasonPhrase);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            HttpResponseMessage res = client.DeleteAsync($"https://localhost:7026/api/courses/{selectedCourseId}").Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Course deleted successfully");
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Error deleting course: " + res.ReasonPhrase);
            }
        }
    }
}
