namespace Day02_ADO__simpleCRUD
{
    partial class CourseCRUDDisconnected
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
            btn_addnew = new Button();
            cb_topic_add = new ComboBox();
            txt_crs_duration = new TextBox();
            txt_crs_name = new TextBox();
            lbl_topic = new Label();
            lbl_crs_duration = new Label();
            lbl_crs_name = new Label();
            data_courses = new DataGridView();
            btn_update = new Button();
            lbl_goto_ntier = new LinkLabel();
            lbl_goto_connected = new LinkLabel();
            btn_save_changes = new Button();
            ((System.ComponentModel.ISupportInitialize)data_courses).BeginInit();
            SuspendLayout();
            // 
            // btn_remove_topic
            // 
            btn_remove_topic.BackColor = Color.FromArgb(192, 0, 0);
            btn_remove_topic.ForeColor = Color.White;
            btn_remove_topic.Location = new Point(345, 109);
            btn_remove_topic.Name = "btn_remove_topic";
            btn_remove_topic.Size = new Size(94, 29);
            btn_remove_topic.TabIndex = 20;
            btn_remove_topic.Text = "Remove";
            btn_remove_topic.UseVisualStyleBackColor = false;
            btn_remove_topic.Click += btn_remove_topic_Click;
            // 
            // btn_remove_crs
            // 
            btn_remove_crs.BackColor = Color.FromArgb(192, 0, 0);
            btn_remove_crs.ForeColor = Color.White;
            btn_remove_crs.Location = new Point(345, 16);
            btn_remove_crs.Name = "btn_remove_crs";
            btn_remove_crs.Size = new Size(94, 29);
            btn_remove_crs.TabIndex = 21;
            btn_remove_crs.Text = "Remove";
            btn_remove_crs.UseVisualStyleBackColor = false;
            btn_remove_crs.Click += btn_remove_crs_Click;
            // 
            // cb_topic_delete
            // 
            cb_topic_delete.FormattingEnabled = true;
            cb_topic_delete.Location = new Point(168, 110);
            cb_topic_delete.Name = "cb_topic_delete";
            cb_topic_delete.Size = new Size(151, 28);
            cb_topic_delete.TabIndex = 18;
            // 
            // cb_courses
            // 
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(168, 16);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(151, 28);
            cb_courses.TabIndex = 19;
            // 
            // lbl_topics
            // 
            lbl_topics.AutoSize = true;
            lbl_topics.Location = new Point(66, 110);
            lbl_topics.Name = "lbl_topics";
            lbl_topics.Size = new Size(51, 20);
            lbl_topics.TabIndex = 16;
            lbl_topics.Text = "Topics";
            // 
            // lbl_courses
            // 
            lbl_courses.AutoSize = true;
            lbl_courses.Location = new Point(66, 16);
            lbl_courses.Name = "lbl_courses";
            lbl_courses.Size = new Size(60, 20);
            lbl_courses.TabIndex = 17;
            lbl_courses.Text = "Courses";
            // 
            // btn_addnew
            // 
            btn_addnew.BackColor = Color.DarkTurquoise;
            btn_addnew.ForeColor = Color.Transparent;
            btn_addnew.Location = new Point(894, 56);
            btn_addnew.Name = "btn_addnew";
            btn_addnew.Size = new Size(151, 29);
            btn_addnew.TabIndex = 15;
            btn_addnew.Text = "Add new";
            btn_addnew.UseVisualStyleBackColor = false;
            btn_addnew.Click += btn_addnew_Click;
            // 
            // cb_topic_add
            // 
            cb_topic_add.FormattingEnabled = true;
            cb_topic_add.Location = new Point(715, 113);
            cb_topic_add.Name = "cb_topic_add";
            cb_topic_add.Size = new Size(151, 28);
            cb_topic_add.TabIndex = 14;
            // 
            // txt_crs_duration
            // 
            txt_crs_duration.Location = new Point(715, 65);
            txt_crs_duration.Name = "txt_crs_duration";
            txt_crs_duration.Size = new Size(151, 27);
            txt_crs_duration.TabIndex = 12;
            // 
            // txt_crs_name
            // 
            txt_crs_name.Location = new Point(715, 21);
            txt_crs_name.Name = "txt_crs_name";
            txt_crs_name.Size = new Size(151, 27);
            txt_crs_name.TabIndex = 13;
            // 
            // lbl_topic
            // 
            lbl_topic.AutoSize = true;
            lbl_topic.Location = new Point(584, 113);
            lbl_topic.Name = "lbl_topic";
            lbl_topic.Size = new Size(45, 20);
            lbl_topic.TabIndex = 9;
            lbl_topic.Text = "Topic";
            // 
            // lbl_crs_duration
            // 
            lbl_crs_duration.AutoSize = true;
            lbl_crs_duration.Location = new Point(584, 65);
            lbl_crs_duration.Name = "lbl_crs_duration";
            lbl_crs_duration.Size = new Size(112, 20);
            lbl_crs_duration.TabIndex = 10;
            lbl_crs_duration.Text = "course duration";
            // 
            // lbl_crs_name
            // 
            lbl_crs_name.AutoSize = true;
            lbl_crs_name.Location = new Point(584, 19);
            lbl_crs_name.Name = "lbl_crs_name";
            lbl_crs_name.Size = new Size(93, 20);
            lbl_crs_name.TabIndex = 11;
            lbl_crs_name.Text = "course name";
            // 
            // data_courses
            // 
            data_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_courses.Location = new Point(28, 216);
            data_courses.Name = "data_courses";
            data_courses.RowHeadersWidth = 51;
            data_courses.Size = new Size(1034, 304);
            data_courses.TabIndex = 8;
            data_courses.RowHeaderMouseDoubleClick += data_courses_RowHeaderMouseDoubleClick;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.DarkOrange;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(894, 91);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(151, 29);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // lbl_goto_ntier
            // 
            lbl_goto_ntier.AutoSize = true;
            lbl_goto_ntier.Location = new Point(914, 540);
            lbl_goto_ntier.Name = "lbl_goto_ntier";
            lbl_goto_ntier.Size = new Size(148, 20);
            lbl_goto_ntier.TabIndex = 22;
            lbl_goto_ntier.TabStop = true;
            lbl_goto_ntier.Text = "Goto N-Tier Mode ▶️";
            lbl_goto_ntier.LinkClicked += lbl_goto_nteir_LinkClicked;
            // 
            // lbl_goto_connected
            // 
            lbl_goto_connected.AutoSize = true;
            lbl_goto_connected.Location = new Point(28, 540);
            lbl_goto_connected.Name = "lbl_goto_connected";
            lbl_goto_connected.Size = new Size(177, 20);
            lbl_goto_connected.TabIndex = 23;
            lbl_goto_connected.TabStop = true;
            lbl_goto_connected.Text = "◀️ Goto Connected Mode";
            lbl_goto_connected.LinkClicked += lbl_goto_connected_LinkClicked;
            // 
            // btn_save_changes
            // 
            btn_save_changes.BackColor = Color.Green;
            btn_save_changes.ForeColor = Color.White;
            btn_save_changes.Location = new Point(376, 531);
            btn_save_changes.Name = "btn_save_changes";
            btn_save_changes.Size = new Size(321, 29);
            btn_save_changes.TabIndex = 24;
            btn_save_changes.Text = "Save All Changes";
            btn_save_changes.UseVisualStyleBackColor = false;
            btn_save_changes.Click += btn_save_changes_Click;
            // 
            // CourseCRUDDisconnected
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 569);
            Controls.Add(btn_save_changes);
            Controls.Add(lbl_goto_connected);
            Controls.Add(lbl_goto_ntier);
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
            Name = "CourseCRUDDisconnected";
            Text = "Disconnected - CourseCRUD";
            FormClosing += save_changes_on_closing;
            Load += CourseCRUDDisconnected_Load;
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
        private Button btn_addnew;
        private ComboBox cb_topic_add;
        private TextBox txt_crs_duration;
        private TextBox txt_crs_name;
        private Label lbl_topic;
        private Label lbl_crs_duration;
        private Label lbl_crs_name;
        private DataGridView data_courses;
        private Button btn_update;
        private LinkLabel lbl_goto_ntier;
        private LinkLabel lbl_goto_connected;
        private Button btn_save_changes;
    }
}