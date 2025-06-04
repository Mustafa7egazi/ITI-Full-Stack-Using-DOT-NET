namespace Day01____EF_Lab
{
    partial class StudentsForm
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
            label1 = new Label();
            dgv_sstudents = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_address = new TextBox();
            cb_depts = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_remove = new Button();
            label5 = new Label();
            cb_supervisor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_sstudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Student name";
            // 
            // dgv_sstudents
            // 
            dgv_sstudents.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_sstudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sstudents.Location = new Point(36, 356);
            dgv_sstudents.Name = "dgv_sstudents";
            dgv_sstudents.RowHeadersWidth = 51;
            dgv_sstudents.Size = new Size(1105, 287);
            dgv_sstudents.TabIndex = 1;
            dgv_sstudents.RowHeaderMouseDoubleClick += dgv_sstudents_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 81);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Student age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 141);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 0;
            label3.Text = "Student Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 201);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 0;
            label4.Text = "Department";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(181, 24);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(151, 27);
            txt_name.TabIndex = 2;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(181, 81);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(151, 27);
            txt_age.TabIndex = 2;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(181, 134);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(151, 27);
            txt_address.TabIndex = 2;
            // 
            // cb_depts
            // 
            cb_depts.FormattingEnabled = true;
            cb_depts.Location = new Point(181, 193);
            cb_depts.Name = "cb_depts";
            cb_depts.Size = new Size(151, 28);
            cb_depts.TabIndex = 3;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(36, 286);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add new";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(152, 286);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 4;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(275, 286);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(94, 29);
            btn_remove.TabIndex = 4;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 243);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 5;
            label5.Text = "Supervisor";
            // 
            // cb_supervisor
            // 
            cb_supervisor.FormattingEnabled = true;
            cb_supervisor.Location = new Point(181, 240);
            cb_supervisor.Name = "cb_supervisor";
            cb_supervisor.Size = new Size(151, 28);
            cb_supervisor.TabIndex = 6;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 684);
            Controls.Add(cb_supervisor);
            Controls.Add(label5);
            Controls.Add(btn_remove);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(cb_depts);
            Controls.Add(txt_address);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(dgv_sstudents);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentsForm";
            Text = "Student - CRUD";
            Load += StudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sstudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_sstudents;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_address;
        private ComboBox cb_depts;
        private Button btn_add;
        private Button btn_update;
        private Button btn_remove;
        private Label label5;
        private ComboBox cb_supervisor;
    }
}
