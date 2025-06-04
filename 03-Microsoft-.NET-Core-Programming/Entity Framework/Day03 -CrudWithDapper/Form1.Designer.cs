namespace Day03__CrudWithDapper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_courses = new DataGridView();
            label1 = new Label();
            txt_crs_name = new TextBox();
            label2 = new Label();
            txt_crs_duration = new TextBox();
            lbl = new Label();
            cb_ctopics = new ComboBox();
            label3 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            label4 = new Label();
            txt_crs_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(24, 294);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowHeadersWidth = 51;
            dgv_courses.Size = new Size(898, 339);
            dgv_courses.TabIndex = 0;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 130);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txt_crs_name
            // 
            txt_crs_name.Location = new Point(114, 130);
            txt_crs_name.Name = "txt_crs_name";
            txt_crs_name.Size = new Size(151, 27);
            txt_crs_name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 177);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Duration";
            // 
            // txt_crs_duration
            // 
            txt_crs_duration.Location = new Point(114, 174);
            txt_crs_duration.Name = "txt_crs_duration";
            txt_crs_duration.Size = new Size(151, 27);
            txt_crs_duration.TabIndex = 2;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(32, 229);
            lbl.Name = "lbl";
            lbl.Size = new Size(45, 20);
            lbl.TabIndex = 1;
            lbl.Text = "Topic";
            // 
            // cb_ctopics
            // 
            cb_ctopics.FormattingEnabled = true;
            cb_ctopics.Location = new Point(114, 221);
            cb_ctopics.Name = "cb_ctopics";
            cb_ctopics.Size = new Size(151, 28);
            cb_ctopics.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 0, 64);
            label3.Location = new Point(345, 18);
            label3.Name = "label3";
            label3.Size = new Size(232, 46);
            label3.TabIndex = 4;
            label3.Text = "Course CRUD";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(406, 100);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(123, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(406, 148);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(123, 29);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(406, 196);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(123, 29);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 91);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 6;
            label4.Text = "Id";
            // 
            // txt_crs_id
            // 
            txt_crs_id.Location = new Point(118, 87);
            txt_crs_id.Name = "txt_crs_id";
            txt_crs_id.Size = new Size(147, 27);
            txt_crs_id.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 663);
            Controls.Add(txt_crs_id);
            Controls.Add(label4);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(cb_ctopics);
            Controls.Add(lbl);
            Controls.Add(txt_crs_duration);
            Controls.Add(label2);
            Controls.Add(txt_crs_name);
            Controls.Add(label1);
            Controls.Add(dgv_courses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_courses;
        private Label label1;
        private TextBox txt_crs_name;
        private Label label2;
        private TextBox txt_crs_duration;
        private Label lbl;
        private ComboBox cb_ctopics;
        private Label label3;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Label label4;
        private TextBox txt_crs_id;
    }
}
