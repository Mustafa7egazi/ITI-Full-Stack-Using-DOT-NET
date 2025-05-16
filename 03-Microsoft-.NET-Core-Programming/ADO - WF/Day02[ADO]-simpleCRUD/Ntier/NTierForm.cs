using Day02_ADO__simpleCRUD.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02_ADO__simpleCRUD
{
    public partial class NTierForm : Form
    {

        public NTierForm()
        {
            InitializeComponent();
        }

        private void NTierForm_Load(object sender, EventArgs e)
        {

            RefreshCoursesData(CourseBussines.RetrieveAllCourses());
            RefreshTopicsData(CourseBussines.RetrieveAllTopics());

            btn_update.Visible = false;

        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            if (txt_crs_name.Text.Trim() == "" || txt_crs_duration.Text.Trim() == "")
            {
                MessageBox.Show($"All fields are required !", "Warning",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return;
            }
            int roweeffect = CourseBussines.InsertCourse(txt_crs_name.Text, int.Parse(txt_crs_duration.Text), (int)cb_topic_add.SelectedValue);
            if (roweeffect > 0)
            {
                RefreshCoursesData(CourseBussines.RetrieveAllCourses());
                RefreshTopicsData(CourseBussines.RetrieveAllTopics());
                txt_crs_name.Text = txt_crs_duration.Text = "";

                MessageBox.Show($"Course successfully Added !", "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }



        int selectedCourseId;
        private void data_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = data_courses.SelectedRows[0];
            selectedCourseId = (int)row.Cells[0].Value;
            txt_crs_name.Text = row.Cells[1].Value.ToString();
            txt_crs_duration.Text = row.Cells[2].Value.ToString();
            bool isTopicEmpty = row.Cells[3].Value == " ";
            cb_topic_add.SelectedValue = isTopicEmpty ? 1 : row.Cells[3].Value;


            btn_addnew.Visible = false;
            btn_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int roweeffect = CourseBussines.UpdateCourse(selectedCourseId, txt_crs_name.Text, int.Parse(txt_crs_duration.Text), (int)cb_topic_add.SelectedValue);
            if (roweeffect > 0)
            {
                RefreshCoursesData(CourseBussines.RetrieveAllCourses());
                RefreshTopicsData(CourseBussines.RetrieveAllTopics());

                txt_crs_name.Text = txt_crs_duration.Text = "";
                MessageBox.Show($"Course successfully updated !", "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btn_addnew.Visible = true;
                btn_update.Visible = false;
            }

        }

        private void btn_remove_crs_Click(object sender, EventArgs e)
        {
            int crs_id = (int)(cb_courses.SelectedValue);
            string crs_name = cb_courses.Text;

            int rowAffected = CourseBussines.DeleteCourseById(crs_id);
            if (rowAffected > 0)
            {
                MessageBox.Show($"Course {crs_name} has been deleted successfully!", "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            RefreshCoursesData(CourseBussines.RetrieveAllCourses());
            RefreshTopicsData(CourseBussines.RetrieveAllTopics());

        }

        private void btn_remove_topic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting topic will delete courses under this topic.\n Are you sure?",
                        "Warning",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information) == DialogResult.OK)
            {
                int top_id = (int)(cb_topic_delete.SelectedValue);
                string top_name = cb_topic_delete.Text;

                int rowAffected = CourseBussines.DeleteTopicById(top_id);
                if (rowAffected > 0)
                {
                    MessageBox.Show($"Topic {top_name} has been deleted successfully!", "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    RefreshCoursesData(CourseBussines.RetrieveAllCourses());
                    RefreshTopicsData(CourseBussines.RetrieveAllTopics());

                }
                else
                {
                    MessageBox.Show($"Failed to delete topic [{top_name}] !", "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show($"Deletion Canceled !", "Info",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
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

        private void ShowConnectedForm()
        {
            CourseCRUDConnected courseCRUDConnected = new CourseCRUDConnected();
            courseCRUDConnected.Show();
            Hide();
        }

        private void ShowDisConnectedForm()
        {
            CourseCRUDDisconnected courseCRUDDisconnected = new CourseCRUDDisconnected();
            courseCRUDDisconnected.Show();
            Hide();
        }
        private void lbl_goto_normal_connected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowConnectedForm();
        }

        private void lbl_goto_disconnected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           ShowDisConnectedForm();
        }
    }
}
