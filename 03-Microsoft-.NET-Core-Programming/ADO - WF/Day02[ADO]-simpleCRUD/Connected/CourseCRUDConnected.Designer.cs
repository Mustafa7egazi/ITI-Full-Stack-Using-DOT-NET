namespace Day02_ADO__simpleCRUD
{
    partial class CourseCRUDConnected
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
            data_courses = new DataGridView();
            lbl_crs_name = new Label();
            lbl_crs_duration = new Label();
            lbl_topic = new Label();
            txt_crs_name = new TextBox();
            txt_crs_duration = new TextBox();
            cb_topic_add = new ComboBox();
            btn_addnew = new Button();
            lbl_courses = new Label();
            lbl_topics = new Label();
            cb_courses = new ComboBox();
            cb_topic_delete = new ComboBox();
            btn_remove_crs = new Button();
            btn_remove_topic = new Button();
            btn_update = new Button();
            lbl_goto_disconnected = new LinkLabel();
            lbl_goto_ntier = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)data_courses).BeginInit();
            SuspendLayout();
            // 
            // data_courses
            // 
            data_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_courses.Location = new Point(3, 296);
            data_courses.Name = "data_courses";
            data_courses.RowHeadersWidth = 51;
            data_courses.Size = new Size(1034, 302);
            data_courses.TabIndex = 0;
            data_courses.RowHeaderMouseDoubleClick += data_courses_RowHeaderMouseDoubleClick;
            // 
            // lbl_crs_name
            // 
            lbl_crs_name.AutoSize = true;
            lbl_crs_name.Location = new Point(545, 66);
            lbl_crs_name.Name = "lbl_crs_name";
            lbl_crs_name.Size = new Size(93, 20);
            lbl_crs_name.TabIndex = 1;
            lbl_crs_name.Text = "course name";
            // 
            // lbl_crs_duration
            // 
            lbl_crs_duration.AutoSize = true;
            lbl_crs_duration.Location = new Point(545, 112);
            lbl_crs_duration.Name = "lbl_crs_duration";
            lbl_crs_duration.Size = new Size(112, 20);
            lbl_crs_duration.TabIndex = 1;
            lbl_crs_duration.Text = "course duration";
            // 
            // lbl_topic
            // 
            lbl_topic.AutoSize = true;
            lbl_topic.Location = new Point(545, 160);
            lbl_topic.Name = "lbl_topic";
            lbl_topic.Size = new Size(45, 20);
            lbl_topic.TabIndex = 1;
            lbl_topic.Text = "Topic";
            // 
            // txt_crs_name
            // 
            txt_crs_name.Location = new Point(676, 68);
            txt_crs_name.Name = "txt_crs_name";
            txt_crs_name.Size = new Size(151, 27);
            txt_crs_name.TabIndex = 2;
            // 
            // txt_crs_duration
            // 
            txt_crs_duration.Location = new Point(676, 112);
            txt_crs_duration.Name = "txt_crs_duration";
            txt_crs_duration.Size = new Size(151, 27);
            txt_crs_duration.TabIndex = 2;
            // 
            // cb_topic_add
            // 
            cb_topic_add.FormattingEnabled = true;
            cb_topic_add.Location = new Point(676, 160);
            cb_topic_add.Name = "cb_topic_add";
            cb_topic_add.Size = new Size(151, 28);
            cb_topic_add.TabIndex = 3;
            // 
            // btn_addnew
            // 
            btn_addnew.BackColor = Color.FromArgb(0, 192, 0);
            btn_addnew.ForeColor = Color.White;
            btn_addnew.Location = new Point(846, 103);
            btn_addnew.Name = "btn_addnew";
            btn_addnew.Size = new Size(171, 29);
            btn_addnew.TabIndex = 4;
            btn_addnew.Text = "Add new";
            btn_addnew.UseVisualStyleBackColor = false;
            btn_addnew.Click += btn_addnew_Click;
            // 
            // lbl_courses
            // 
            lbl_courses.AutoSize = true;
            lbl_courses.Location = new Point(49, 66);
            lbl_courses.Name = "lbl_courses";
            lbl_courses.Size = new Size(60, 20);
            lbl_courses.TabIndex = 5;
            lbl_courses.Text = "Courses";
            // 
            // lbl_topics
            // 
            lbl_topics.AutoSize = true;
            lbl_topics.Location = new Point(49, 160);
            lbl_topics.Name = "lbl_topics";
            lbl_topics.Size = new Size(51, 20);
            lbl_topics.TabIndex = 5;
            lbl_topics.Text = "Topics";
            // 
            // cb_courses
            // 
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(151, 66);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(151, 28);
            cb_courses.TabIndex = 6;
            // 
            // cb_topic_delete
            // 
            cb_topic_delete.FormattingEnabled = true;
            cb_topic_delete.Location = new Point(151, 160);
            cb_topic_delete.Name = "cb_topic_delete";
            cb_topic_delete.Size = new Size(151, 28);
            cb_topic_delete.TabIndex = 6;
            // 
            // btn_remove_crs
            // 
            btn_remove_crs.BackColor = Color.FromArgb(192, 0, 0);
            btn_remove_crs.ForeColor = Color.White;
            btn_remove_crs.Location = new Point(328, 66);
            btn_remove_crs.Name = "btn_remove_crs";
            btn_remove_crs.Size = new Size(94, 29);
            btn_remove_crs.TabIndex = 7;
            btn_remove_crs.Text = "Remove";
            btn_remove_crs.UseVisualStyleBackColor = false;
            btn_remove_crs.Click += btn_remove_crs_Click;
            // 
            // btn_remove_topic
            // 
            btn_remove_topic.BackColor = Color.FromArgb(192, 0, 0);
            btn_remove_topic.ForeColor = Color.White;
            btn_remove_topic.Location = new Point(328, 159);
            btn_remove_topic.Name = "btn_remove_topic";
            btn_remove_topic.Size = new Size(94, 29);
            btn_remove_topic.TabIndex = 7;
            btn_remove_topic.Text = "Remove";
            btn_remove_topic.UseVisualStyleBackColor = false;
            btn_remove_topic.Click += btn_remove_topic_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(255, 128, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(846, 138);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(171, 29);
            btn_update.TabIndex = 4;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // lbl_goto_disconnected
            // 
            lbl_goto_disconnected.AutoSize = true;
            lbl_goto_disconnected.Location = new Point(874, 620);
            lbl_goto_disconnected.Name = "lbl_goto_disconnected";
            lbl_goto_disconnected.Size = new Size(153, 20);
            lbl_goto_disconnected.TabIndex = 8;
            lbl_goto_disconnected.TabStop = true;
            lbl_goto_disconnected.Text = "Goto Disconnected ▶️";
            lbl_goto_disconnected.LinkClicked += lbl_goto_disconnected_LinkClicked;
            // 
            // lbl_goto_ntier
            // 
            lbl_goto_ntier.AutoSize = true;
            lbl_goto_ntier.Location = new Point(12, 620);
            lbl_goto_ntier.Name = "lbl_goto_ntier";
            lbl_goto_ntier.Size = new Size(148, 20);
            lbl_goto_ntier.TabIndex = 9;
            lbl_goto_ntier.TabStop = true;
            lbl_goto_ntier.Text = "◀️ Goto N-Tier Mode";
            lbl_goto_ntier.LinkClicked += lbl_goto_ntier_LinkClicked;
            // 
            // CourseCRUDConnected
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 649);
            Controls.Add(lbl_goto_ntier);
            Controls.Add(lbl_goto_disconnected);
            Controls.Add(btn_remove_topic);
            Controls.Add(btn_remove_crs);
            Controls.Add(cb_topic_delete);
            Controls.Add(cb_courses);
            Controls.Add(lbl_topics);
            Controls.Add(lbl_courses);
            Controls.Add(btn_update);
            Controls.Add(btn_addnew);
            Controls.Add(cb_topic_add);
            Controls.Add(txt_crs_duration);
            Controls.Add(txt_crs_name);
            Controls.Add(lbl_topic);
            Controls.Add(lbl_crs_duration);
            Controls.Add(lbl_crs_name);
            Controls.Add(data_courses);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CourseCRUDConnected";
            Text = "Connected  - CourseCRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)data_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_courses;
        private Label lbl_crs_name;
        private Label lbl_crs_duration;
        private Label lbl_topic;
        private TextBox txt_crs_name;
        private TextBox txt_crs_duration;
        private ComboBox cb_topic_add;
        private Button btn_addnew;
        private Label lbl_courses;
        private Label lbl_topics;
        private ComboBox cb_courses;
        private ComboBox cb_topic_delete;
        private Button btn_remove_crs;
        private Button btn_remove_topic;
        private Button btn_update;
        private LinkLabel lbl_goto_disconnected;
        private LinkLabel lbl_goto_ntier;
    }
}
