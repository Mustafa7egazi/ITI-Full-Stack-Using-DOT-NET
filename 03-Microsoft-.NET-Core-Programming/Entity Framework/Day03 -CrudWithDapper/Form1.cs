using Dapper;
using Day03__CrudWithDapper.Models;
using Microsoft.Data.SqlClient;

namespace Day03__CrudWithDapper
{

    public partial class Form1 : Form
    {
        SqlConnection con;
        List<Course> courses;
        List<Topic> topics;
        int selectedCourseId;
        public Form1()
        {
            InitializeComponent();
            courses = new List<Course>();
            topics = new List<Topic>();
            con = new SqlConnection("Server=.;Database=ITI;Integrated Security=true;TrustServerCertificate=True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            courses = con.Query<Course>("select * from Course").ToList();
            topics = con.Query<Topic>("select * from Topic").ToList();

            dgv_courses.DataSource = courses;
            cb_ctopics.DataSource = topics;
            cb_ctopics.DisplayMember = "Top_Name";
            cb_ctopics.ValueMember = "Top_Id";

            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int rowAffected = con.Execute("insert into Course(Crs_Id,Crs_Name,Crs_Duration,Top_Id) values(@Crs_Id,@Crs_Name,@Crs_Duration,@Top_Id)",
                    new { Crs_Id = Convert.ToInt32(txt_crs_id.Text), Crs_Name = txt_crs_name.Text, Crs_Duration = Convert.ToInt32(txt_crs_duration.Text), Top_Id = Convert.ToInt32(cb_ctopics.SelectedValue) });

                if (rowAffected > 0)
                {
                    MessageBox.Show("Course Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1_Load(null, null);

                }
                txt_crs_id.Text = txt_crs_id.Text = txt_crs_name.Text = txt_crs_duration.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Insertion Faild!\n due to:  {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedCourseId = Convert.ToInt32(dgv_courses.SelectedRows[0].Cells[0].Value);
            txt_crs_id.Text = dgv_courses.SelectedRows[0].Cells[0].Value.ToString();
            txt_crs_name.Text = dgv_courses.SelectedRows[0].Cells[1].Value.ToString();
            txt_crs_duration.Text = dgv_courses.SelectedRows[0].Cells[2].Value.ToString();
            cb_ctopics.SelectedValue = (int)dgv_courses.SelectedRows[0].Cells[3].Value;

            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int rowAffected = con.Execute("update Course set Crs_Id = @Crs_Id, Crs_Name=@Crs_Name,Crs_Duration=@Crs_Duration,Top_Id=@Top_Id where Crs_Id=@Crs_Id",
                    new
                    {
                        Crs_Id = Convert.ToInt32(txt_crs_id.Text),
                        Crs_Name = txt_crs_name.Text,
                        Crs_Duration = Convert.ToInt32(txt_crs_duration.Text),
                        Top_Id = Convert.ToInt32(cb_ctopics.SelectedValue)
                    });

                if (rowAffected > 0)
                {
                    MessageBox.Show($"Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Faild!\n due to:  {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_crs_id.Text = txt_crs_id.Text = txt_crs_name.Text = txt_crs_duration.Text = string.Empty;

                Form1_Load(null, null);
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int rowAffected = con.Execute("delete from Course where Crs_Id=@Crs_Id", new { Crs_Id = selectedCourseId });
                    if (rowAffected > 0)
                    {
                        MessageBox.Show($"Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deletion Faild!\n due to:  {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                txt_crs_id.Text = txt_crs_id.Text = txt_crs_name.Text = txt_crs_duration.Text = string.Empty;

                Form1_Load(null, null);
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;

            }
        }
    }
}
