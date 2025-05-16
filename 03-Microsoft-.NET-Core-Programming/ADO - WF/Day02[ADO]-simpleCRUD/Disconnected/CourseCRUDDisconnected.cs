using Microsoft.Data.SqlClient;
using System.Data;

namespace Day02_ADO__simpleCRUD
{
    public partial class CourseCRUDDisconnected : Form
    {
        SqlConnection connection;
        DataTable coursesTable;
        DataTable topicsTable;
        int selectedCourseId;

        public CourseCRUDDisconnected()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=MUSTAFA7EGAZI;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
        }

        private void CourseCRUDDisconnected_Load(object sender, EventArgs e)
        {
            SqlCommand cmdCourses = new SqlCommand("select * from course", connection);
            SqlCommand cmdTopics = new SqlCommand("select * from topic", connection);

            SqlDataAdapter coursesAdapter = new SqlDataAdapter(cmdCourses);
            SqlDataAdapter topicsAdapter = new SqlDataAdapter(cmdTopics);

            coursesTable = new DataTable();
            topicsTable = new DataTable();

            coursesAdapter.Fill(coursesTable);
            topicsAdapter.Fill(topicsTable);

            // Set primary keys for DataTables
            coursesTable.PrimaryKey = new DataColumn[] { coursesTable.Columns["crs_id"] };
            topicsTable.PrimaryKey = new DataColumn[] { topicsTable.Columns["top_id"] };

            RefreshCoursesData(coursesTable);
            RefreshTopicsData(topicsTable);

            btn_update.Visible = false;
        }

        private void RefreshCoursesData(DataTable data)
        {
            data_courses.DataSource = null;
            data_courses.DataSource = data;
            cb_courses.DataSource = data;
            cb_courses.DisplayMember = "crs_name";
            cb_courses.ValueMember = "crs_id";
        }

        private void RefreshTopicsData(DataTable data)
        {
            cb_topic_add.DataSource = null;
            cb_topic_delete.DataSource = null;

            cb_topic_add.DataSource = data;
            cb_topic_add.DisplayMember = "top_name";
            cb_topic_add.ValueMember = "top_id";


            cb_topic_delete.DataSource = data;
            cb_topic_delete.DisplayMember = "top_name";
            cb_topic_delete.ValueMember = "top_id";
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {


            DataRow r = coursesTable.Rows[coursesTable.Rows.Count - 1];
            int lastInserted = (int)r["crs_id"];

            DataRow dr = coursesTable.NewRow();

            dr["crs_id"] = lastInserted + 1;
            dr["crs_name"] = txt_crs_name.Text;
            dr["crs_duration"] = txt_crs_duration.Text;
            dr["top_id"] = cb_topic_add.SelectedValue;
            coursesTable.Rows.Add(dr);

            RefreshCoursesData(coursesTable);
            RefreshTopicsData(topicsTable);

            txt_crs_name.Text = txt_crs_duration.Text = "";
            MessageBox.Show($"Course successfully Added !", "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            foreach (DataRow dr in coursesTable.Rows)
            {

                if ((int)dr["crs_id"] == selectedCourseId)
                {
                    dr["crs_name"] = txt_crs_name.Text;
                    dr["crs_duration"] = txt_crs_duration.Text;
                    dr["top_id"] = cb_topic_add.SelectedValue;

                }

            }

            RefreshCoursesData(coursesTable);
            RefreshTopicsData(topicsTable);
            txt_crs_name.Text = txt_crs_duration.Text = "";

            btn_addnew.Visible = true;
            btn_update.Visible = false;
            MessageBox.Show($"Course successfully updated !", "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

        }


        private void data_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = data_courses.SelectedRows[0];
            selectedCourseId = (int)row.Cells[0].Value;
            txt_crs_name.Text = row.Cells[1].Value.ToString();
            txt_crs_duration.Text = row.Cells[2].Value.ToString();
            cb_topic_add.SelectedValue = row.Cells[3].Value;

            btn_addnew.Visible = false;
            btn_update.Visible = true;
        }

        private void btn_remove_crs_Click(object sender, EventArgs e)
        {
            DataRow[] rows = coursesTable.Select($"crs_id = {cb_courses.SelectedValue}");

            if (rows.Length == 0)
            {
                MessageBox.Show("No matching course found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Remove course '{rows[0]["crs_name"]}' ?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                
                rows[0].Delete();

                RefreshCoursesData(coursesTable);
                MessageBox.Show("Course marked for removal! Save changes to apply.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_remove_topic_Click(object sender, EventArgs e)
        {
            if (cb_topic_delete.SelectedValue == null)
            {
                MessageBox.Show("Please select a topic to remove", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow[] topicRows = topicsTable.Select($"top_id = {cb_topic_delete.SelectedValue}");

            if (topicRows.Length == 0)
            {
                MessageBox.Show("No matching topic found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Remove topic '{topicRows[0]["top_name"]}' and all its courses?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int topicId = (int)topicRows[0]["top_id"];

                    
                    DataRow[] relatedCourses = coursesTable.Select($"top_id = {topicId}");
                    foreach (DataRow courseRow in relatedCourses)
                    {
                        courseRow.Delete();
                    }

                    topicRows[0].Delete();

                    RefreshCoursesData(coursesTable);
                    RefreshTopicsData(topicsTable);

                    MessageBox.Show($"Topic and {relatedCourses.Length} related courses marked for removal. Save changes to apply.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error marking topic for removal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowNTierForm()
        {
            NTierForm nTierForm = new NTierForm();
            nTierForm.Show();
            Hide();
        }

        private void ShowConnectedForm()
        {
            CourseCRUDConnected courseCRUDConnected = new CourseCRUDConnected();
            courseCRUDConnected.Show();
            Hide();
        }

        private void lbl_goto_connected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowConnectedForm();
        }

        private void lbl_goto_nteir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowNTierForm();
        }

        private void save_changes_on_closing(object sender, FormClosingEventArgs e)
        {
            SaveAllChangesToDB(e);
        }

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            SaveAllChangesToDB(null);

        }

        private void SaveAllChangesToDB(FormClosingEventArgs e)
        {
            try
            {
                //  course adapter
                SqlDataAdapter courseAdapter = new SqlDataAdapter("SELECT * FROM course", connection);
                courseAdapter.InsertCommand = new SqlCommand(
                    "INSERT INTO course (crs_name, crs_duration, top_id) VALUES (@crs_name, @crs_duration, @top_id)",
                    connection);
                courseAdapter.InsertCommand.Parameters.Add("@crs_name", SqlDbType.NVarChar, 50, "crs_name");
                courseAdapter.InsertCommand.Parameters.Add("@crs_duration", SqlDbType.Int, 4, "crs_duration");
                courseAdapter.InsertCommand.Parameters.Add("@top_id", SqlDbType.Int, 4, "top_id");

                courseAdapter.UpdateCommand = new SqlCommand(
                    "UPDATE course SET crs_name=@crs_name, crs_duration=@crs_duration, top_id=@top_id WHERE crs_id=@crs_id",
                    connection);
                courseAdapter.UpdateCommand.Parameters.Add("@crs_name", SqlDbType.NVarChar, 50, "crs_name");
                courseAdapter.UpdateCommand.Parameters.Add("@crs_duration", SqlDbType.Int, 4, "crs_duration");
                courseAdapter.UpdateCommand.Parameters.Add("@top_id", SqlDbType.Int, 4, "top_id");
                courseAdapter.UpdateCommand.Parameters.Add("@crs_id", SqlDbType.Int, 4, "crs_id");

                courseAdapter.DeleteCommand = new SqlCommand(
                    "DELETE FROM course WHERE crs_id=@crs_id",
                    connection);
                courseAdapter.DeleteCommand.Parameters.Add("@crs_id", SqlDbType.Int, 4, "crs_id");

                //  topic adapter
                SqlDataAdapter topicAdapter = new SqlDataAdapter("SELECT * FROM topic", connection);
                topicAdapter.DeleteCommand = new SqlCommand(
                    "DELETE FROM topic WHERE top_id=@top_id",
                    connection);
                topicAdapter.DeleteCommand.Parameters.Add("@top_id", SqlDbType.Int, 4, "top_id");

                connection.Open();

                // Update courses first to respect foreign key constraints
                int courseChanges = courseAdapter.Update(coursesTable);
                int topicChanges = topicAdapter.Update(topicsTable);

                coursesTable.AcceptChanges();
                topicsTable.AcceptChanges();

                MessageBox.Show($"Saved {courseChanges} course changes and {topicChanges} topic changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (e != null)
                {
                    e.Cancel = true;
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
