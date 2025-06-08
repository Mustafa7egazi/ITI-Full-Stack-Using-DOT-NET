namespace AppConsumer
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
            label2 = new Label();
            label3 = new Label();
            txt_crs_name = new TextBox();
            txt_crs_desc = new TextBox();
            txt_crs_duration = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(24, 251);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowHeadersWidth = 51;
            dgv_courses.Size = new Size(954, 230);
            dgv_courses.TabIndex = 0;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 34);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Course name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 75);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Course desc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 118);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 1;
            label3.Text = "duration";
            // 
            // txt_crs_name
            // 
            txt_crs_name.Location = new Point(186, 27);
            txt_crs_name.Name = "txt_crs_name";
            txt_crs_name.Size = new Size(125, 27);
            txt_crs_name.TabIndex = 2;
            // 
            // txt_crs_desc
            // 
            txt_crs_desc.Location = new Point(186, 72);
            txt_crs_desc.Name = "txt_crs_desc";
            txt_crs_desc.Size = new Size(125, 27);
            txt_crs_desc.TabIndex = 2;
            // 
            // txt_crs_duration
            // 
            txt_crs_duration.Location = new Point(186, 118);
            txt_crs_duration.Name = "txt_crs_duration";
            txt_crs_duration.Size = new Size(125, 27);
            txt_crs_duration.TabIndex = 2;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(439, 34);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 3;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(439, 92);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(439, 148);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 513);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(txt_crs_duration);
            Controls.Add(txt_crs_desc);
            Controls.Add(txt_crs_name);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private TextBox txt_crs_name;
        private TextBox txt_crs_desc;
        private TextBox txt_crs_duration;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
    }
}
