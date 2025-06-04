using Day01____EF_Lab.Models;
using System.Data;

namespace Day01____EF_Lab
{
    public partial class StudentsForm : Form
    {

        private ItiContext db;
        private int selectedId;
        private List<Student> Students;
        private List<Department> Departments;
        public StudentsForm()
        {
            InitializeComponent();
            db = new ItiContext();
            Students = new List<Student>();
            Departments = new List<Department>();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            Students = db.Students.ToList();
            Departments = db.Departments.ToList();

            dgv_sstudents.DataSource = Students.Select(s => new
            {
                Id = s.StId,
                Fullname = $"{s.StFname} {s.StLname}",
                Age = s.StAge,
                Address = s.StAddress,
                Depratment = s.Dept?.DeptName,
                supervisor = s.StSuper
            }).ToList();

            cb_depts.DataSource = Departments;
            cb_depts.DisplayMember = "DeptName";
            cb_depts.ValueMember = "DeptId";

            cb_supervisor.DataSource = Students;
            cb_supervisor.DisplayMember = "StFname";
            cb_supervisor.ValueMember = "StId";

            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_remove.Enabled = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            if (txt_name.Text.Trim().Split(" ").Length < 2)
            {
                MessageBox.Show("Full name must be at least 2 names", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newStudent.StFname = txt_name.Text.Split(" ")[0];
            newStudent.StLname = txt_name.Text.Split(" ").Length > 1 ? txt_name.Text.Split(" ")[1] : " ";
            newStudent.StAddress = txt_address.Text;
            newStudent.StAge = int.TryParse(txt_age.Text, out int age) ? age : 0;
            newStudent.DeptId = (int)cb_depts.SelectedValue;

            if (cb_supervisor.Text != "No Supervisor")
            {
                newStudent.StSuper = (int)cb_supervisor.SelectedValue;

            }
            else
            {
                MessageBox.Show("You must select supervisor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                db.Students.Add(newStudent);
            db.SaveChanges();

            dgv_sstudents.DataSource = db.Students.Select(s => new
            {
                Id = s.StId,
                Fullname = $"{s.StFname} {s.StLname}",
                Age = s.StAge,
                Address = s.StAddress,
                Depratment = s.Dept.DeptName,
                supervisor = s.StSuper
            }).ToList();

            MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dgv_sstudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_sstudents.SelectedRows[0];
            selectedId = (int)selectedRow.Cells["Id"].Value;
            Student s = db.Students.Where(s => s.StId == selectedId).SingleOrDefault();
            txt_name.Text = s.StFname + " " + s.StLname;
            txt_age.Text = s.StAge.ToString();
            txt_address.Text = s.StAddress.ToString();
            cb_depts.SelectedValue = s.Dept.DeptId;
            if (s.StSuper != null)
            {
                cb_supervisor.SelectedValue = s.StSuper;
            }
            else
            {
                cb_supervisor.Text = "No Supervisor";
            }

            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_remove.Enabled = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(s => s.StId == selectedId).SingleOrDefault();
            if (txt_name.Text.Trim().Split(" ").Length < 2)
            {
                MessageBox.Show("Full name must be at least 2 names", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            s.StFname = txt_name.Text.Split(" ")[0];
            s.StLname = txt_name.Text.Split(" ").Length > 1 ? txt_name.Text.Split(" ")[1] : " ";
            s.StAddress = txt_address.Text;
            s.StAge = int.TryParse(txt_age.Text, out int age) ? age : 0;
            s.DeptId = (int)cb_depts.SelectedValue;

            if (cb_supervisor.Text != "No Supervisor")
            {
                s.StSuper = (int)cb_supervisor.SelectedValue;
            }
            else
            {
                s.StSuper = null;
            }

            db.SaveChanges();
            txt_address.Text = txt_age.Text = txt_name.Text = "";

            dgv_sstudents.DataSource = db.Students.Select(s => new
            {
                Id = s.StId,
                Fullname = $"{s.StFname} {s.StLname}",
                Age = s.StAge,
                Address = s.StAddress,
                Depratment = s.Dept.DeptName,
                supervisor = s.StSuper
            }).ToList();

            MessageBox.Show("Student updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_remove.Enabled = false;

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Student s = db.Students.Where(s=> s.StId == selectedId).SingleOrDefault();
                db.Students.Remove(s);

                db.SaveChanges();
                txt_address.Text = txt_age.Text = txt_name.Text = "";
                dgv_sstudents.DataSource = db.Students.Select(s => new
                {
                    Id = s.StId,
                    Fullname = $"{s.StFname} {s.StLname}",
                    Age = s.StAge,
                    Address = s.StAddress,
                    Depratment = s.Dept.DeptName,
                    supervisor = s.StSuper
                }).ToList();
                MessageBox.Show("Student Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                btn_remove.Enabled = false;
            }
        }
    }
}
