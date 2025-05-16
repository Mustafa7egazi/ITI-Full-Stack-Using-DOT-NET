namespace Day02_ADO__simpleCRUD
{
    partial class NTierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_remove_topic = new Button();
            btn_remove_crs = new Button();
            cb_topic_delete = new ComboBox();
            cb_courses = new ComboBox();
            lbl_topics = new Label();
            lbl_courses = new Label();
            btn_update = new Button();
            btn_addnew = new Button();
            cb_topic_add = new ComboBox();
            txt_crs_duration = new TextBox();
            txt_crs_name = new TextBox();
            lbl_topic = new Label();
            lbl_crs_duration = new Label();
            lbl_crs_name = new Label();
            data_courses = new DataGridView();
            lbl_goto_normal_connected = new LinkLabel();
            lbl_goto_disconnected = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)data_courses).BeginInit();
            SuspendLayout();
            // 
            // btn_remove_topic
            // 
            btn_remove_topic.BackColor = Color.FromArgb(192, 0, 0);
            btn_remove_topic.ForeColor = Color.White;
            btn_remove_topic.Location = new Point(331, 117);
            btn_remove_topic.Name = "btn_remove_topic";
            btn_remove_topic.Size = new Size(94, 29);
            btn_remove_topic.TabIndex = 21;
            btn_remove_topic.Text = "Remove";
            btn_remove_topic.UseVisualStyleBackColor = false;
            btn_remove_topic.Click += btn_remove_topic_Click;
            // 
            // btn_remove_crs
            // 
            btn_remove_crs.BackColor = Color.FromArgb(192, 0, 0);
            btn_remove_crs.ForeColor = Color.White;
            btn_remove_crs.Location = new Point(331, 24);
            btn_remove_crs.Name = "btn_remove_crs";
            btn_remove_crs.Size = new Size(94, 29);
            btn_remove_crs.TabIndex = 22;
            btn_remove_crs.Text = "Remove";
            btn_remove_crs.UseVisualStyleBackColor = false;
            btn_remove_crs.Click += btn_remove_crs_Click;
            // 
            // cb_topic_delete
            // 
            cb_topic_delete.FormattingEnabled = true;
            cb_topic_delete.Location = new Point(154, 118);
            cb_topic_delete.Name = "cb_topic_delete";
            cb_topic_delete.Size = new Size(151, 28);
            cb_topic_delete.TabIndex = 19;
            // 
            // cb_courses
            // 
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(154, 24);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(151, 28);
            cb_courses.TabIndex = 20;
            // 
            // lbl_topics
            // 
            lbl_topics.AutoSize = true;
            lbl_topics.Location = new Point(52, 118);
            lbl_topics.Name = "lbl_topics";
            lbl_topics.Size = new Size(51, 20);
            lbl_topics.TabIndex = 17;
            lbl_topics.Text = "Topics";
            // 
            // lbl_courses
            // 
            lbl_courses.AutoSize = true;
            lbl_courses.Location = new Point(52, 24);
            lbl_courses.Name = "lbl_courses";
            lbl_courses.Size = new Size(60, 20);
            lbl_courses.TabIndex = 18;
            lbl_courses.Text = "Courses";
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(255, 128, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(845, 96);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(177, 29);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_addnew
            // 
            btn_addnew.BackColor = Color.FromArgb(0, 192, 0);
            btn_addnew.ForeColor = Color.White;
            btn_addnew.Location = new Point(845, 61);
            btn_addnew.Name = "btn_addnew";
            btn_addnew.Size = new Size(177, 29);
            btn_addnew.TabIndex = 16;
            btn_addnew.Text = "Add new";
            btn_addnew.UseVisualStyleBackColor = false;
            btn_addnew.Click += btn_addnew_Click;
            // 
            // cb_topic_add
            // 
            cb_topic_add.FormattingEnabled = true;
            cb_topic_add.Location = new Point(672, 118);
            cb_topic_add.Name = "cb_topic_add";
            cb_topic_add.Size = new Size(151, 28);
            cb_topic_add.TabIndex = 14;
            // 
            // txt_crs_duration
            // 
            txt_crs_duration.Location = new Point(672, 70);
            txt_crs_duration.Name = "txt_crs_duration";
            txt_crs_duration.Size = new Size(151, 27);
            txt_crs_duration.TabIndex = 12;
            // 
            // txt_crs_name
            // 
            txt_crs_name.Location = new Point(672, 26);
            txt_crs_name.Name = "txt_crs_name";
            txt_crs_name.Size = new Size(151, 27);
            txt_crs_name.TabIndex = 13;
            // 
            // lbl_topic
            // 
            lbl_topic.AutoSize = true;
            lbl_topic.Location = new Point(541, 118);
            lbl_topic.Name = "lbl_topic";
            lbl_topic.Size = new Size(45, 20);
            lbl_topic.TabIndex = 9;
            lbl_topic.Text = "Topic";
            // 
            // lbl_crs_duration
            // 
            lbl_crs_duration.AutoSize = true;
            lbl_crs_duration.Location = new Point(541, 70);
            lbl_crs_duration.Name = "lbl_crs_duration";
            lbl_crs_duration.Size = new Size(112, 20);
            lbl_crs_duration.TabIndex = 10;
            lbl_crs_duration.Text = "course duration";
            // 
            // lbl_crs_name
            // 
            lbl_crs_name.AutoSize = true;
            lbl_crs_name.Location = new Point(541, 24);
            lbl_crs_name.Name = "lbl_crs_name";
            lbl_crs_name.Size = new Size(93, 20);
            lbl_crs_name.TabIndex = 11;
            lbl_crs_name.Text = "course name";
            // 
            // data_courses
            // 
            data_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_courses.Location = new Point(6, 254);
            data_courses.Name = "data_courses";
            data_courses.RowHeadersWidth = 51;
            data_courses.Size = new Size(1034, 304);
            data_courses.TabIndex = 8;
            data_courses.RowHeaderMouseDoubleClick += data_courses_RowHeaderMouseDoubleClick;
            // 
            // lbl_goto_normal_connected
            // 
            lbl_goto_normal_connected.AutoSize = true;
            lbl_goto_normal_connected.Location = new Point(857, 576);
            lbl_goto_normal_connected.Name = "lbl_goto_normal_connected";
            lbl_goto_normal_connected.Size = new Size(177, 20);
            lbl_goto_normal_connected.TabIndex = 23;
            lbl_goto_normal_connected.TabStop = true;
            lbl_goto_normal_connected.Text = "Goto Connected Mode ▶️";
            lbl_goto_normal_connected.LinkClicked += lbl_goto_normal_connected_LinkClicked;
            // 
            // lbl_goto_disconnected
            // 
            lbl_goto_disconnected.AutoSize = true;
            lbl_goto_disconnected.Location = new Point(26, 576);
            lbl_goto_disconnected.Name = "lbl_goto_disconnected";
            lbl_goto_disconnected.Size = new Size(196, 20);
            lbl_goto_disconnected.TabIndex = 24;
            lbl_goto_disconnected.TabStop = true;
            lbl_goto_disconnected.Text = "◀️ Goto Disconnected Mode";
            lbl_goto_disconnected.LinkClicked += lbl_goto_disconnected_LinkClicked;
            // 
            // NTierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 618);
            Controls.Add(lbl_goto_disconnected);
            Controls.Add(lbl_goto_normal_connected);
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
            Name = "NTierForm";
            Text = "NTier - CourseCRUD";
            Load += NTierForm_Load;
            ((System.ComponentModel.ISupportInitialize)data_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_remove_topic;
        private Button btn_remove_crs;
        private ComboBox cb_topic_delete;
        private ComboBox cb_courses;
        private Label lbl_topics;
        private Label lbl_courses;
        private Button btn_update;
        private Button btn_addnew;
        private ComboBox cb_topic_add;
        private TextBox txt_crs_duration;
        private TextBox txt_crs_name;
        private Label lbl_topic;
        private Label lbl_crs_duration;
        private Label lbl_crs_name;
        private DataGridView data_courses;
        private LinkLabel lbl_goto_normal_connected;
        private LinkLabel lbl_goto_disconnected;
    }
}