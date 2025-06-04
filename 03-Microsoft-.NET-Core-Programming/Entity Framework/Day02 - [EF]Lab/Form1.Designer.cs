namespace Day02____EF_Lab
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
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            label16 = new Label();
            label14 = new Label();
            btn_delete_news = new Button();
            btn_update_news = new Button();
            btn_add_news = new Button();
            cb_authors = new ComboBox();
            cb_categories = new ComboBox();
            txt_news_desc = new RichTextBox();
            label3 = new Label();
            txt_news_breif = new TextBox();
            label2 = new Label();
            txt_news_title = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dgv_news = new DataGridView();
            nonews = new Label();
            tabPage2 = new TabPage();
            label12 = new Label();
            label8 = new Label();
            btn_delete_author = new Button();
            btn_update_author = new Button();
            btn_add_author = new Button();
            txt_author_email = new TextBox();
            label7 = new Label();
            txt_author_pass = new TextBox();
            txt_author_age = new TextBox();
            label11 = new Label();
            txt_author_name = new TextBox();
            label6 = new Label();
            label9 = new Label();
            dgv_authors = new DataGridView();
            noauthors = new Label();
            tabPage3 = new TabPage();
            label17 = new Label();
            txt_category_desc = new RichTextBox();
            label10 = new Label();
            btn_delete_category = new Button();
            btn_update_category = new Button();
            btn_add_category = new Button();
            label13 = new Label();
            txt_category_name = new TextBox();
            label15 = new Label();
            dgv_categories = new DataGridView();
            nocategoris = new Label();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_authors).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(tabPage3);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1068, 654);
            TabControl.TabIndex = 0;
            TabControl.MouseClick += TabControl_MouseClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(btn_delete_news);
            tabPage1.Controls.Add(btn_update_news);
            tabPage1.Controls.Add(btn_add_news);
            tabPage1.Controls.Add(cb_authors);
            tabPage1.Controls.Add(cb_categories);
            tabPage1.Controls.Add(txt_news_desc);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txt_news_breif);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_news_title);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgv_news);
            tabPage1.Controls.Add(nonews);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1060, 621);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add News";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label16.ForeColor = Color.Crimson;
            label16.Location = new Point(364, 17);
            label16.Name = "label16";
            label16.Size = new Size(273, 32);
            label16.TabIndex = 21;
            label16.Text = "Manipulate News Data";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(0, 0, 64);
            label14.Location = new Point(18, 253);
            label14.Name = "label14";
            label14.Size = new Size(136, 32);
            label14.TabIndex = 21;
            label14.Text = "News Data";
            // 
            // btn_delete_news
            // 
            btn_delete_news.BackColor = Color.Red;
            btn_delete_news.ForeColor = Color.White;
            btn_delete_news.Location = new Point(890, 210);
            btn_delete_news.Name = "btn_delete_news";
            btn_delete_news.Size = new Size(147, 29);
            btn_delete_news.TabIndex = 5;
            btn_delete_news.Text = "Delete";
            btn_delete_news.UseVisualStyleBackColor = false;
            btn_delete_news.Click += btn_delete_news_Click;
            // 
            // btn_update_news
            // 
            btn_update_news.BackColor = Color.FromArgb(255, 128, 0);
            btn_update_news.ForeColor = Color.White;
            btn_update_news.Location = new Point(890, 163);
            btn_update_news.Name = "btn_update_news";
            btn_update_news.Size = new Size(147, 29);
            btn_update_news.TabIndex = 5;
            btn_update_news.Text = "Update";
            btn_update_news.UseVisualStyleBackColor = false;
            btn_update_news.Click += btn_update_news_Click;
            // 
            // btn_add_news
            // 
            btn_add_news.BackColor = Color.FromArgb(0, 192, 0);
            btn_add_news.ForeColor = Color.White;
            btn_add_news.Location = new Point(890, 116);
            btn_add_news.Name = "btn_add_news";
            btn_add_news.Size = new Size(147, 29);
            btn_add_news.TabIndex = 5;
            btn_add_news.Text = "Add New";
            btn_add_news.UseVisualStyleBackColor = false;
            btn_add_news.Click += btn_add_news_Click;
            // 
            // cb_authors
            // 
            cb_authors.FormattingEnabled = true;
            cb_authors.Location = new Point(656, 210);
            cb_authors.Name = "cb_authors";
            cb_authors.Size = new Size(151, 28);
            cb_authors.TabIndex = 4;
            // 
            // cb_categories
            // 
            cb_categories.FormattingEnabled = true;
            cb_categories.Location = new Point(656, 139);
            cb_categories.Name = "cb_categories";
            cb_categories.Size = new Size(151, 28);
            cb_categories.TabIndex = 4;
            // 
            // txt_news_desc
            // 
            txt_news_desc.Location = new Point(242, 139);
            txt_news_desc.Name = "txt_news_desc";
            txt_news_desc.Size = new Size(333, 99);
            txt_news_desc.TabIndex = 3;
            txt_news_desc.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 116);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Description";
            // 
            // txt_news_breif
            // 
            txt_news_breif.Location = new Point(19, 204);
            txt_news_breif.Name = "txt_news_breif";
            txt_news_breif.Size = new Size(174, 27);
            txt_news_breif.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 181);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Breif";
            // 
            // txt_news_title
            // 
            txt_news_title.Location = new Point(19, 139);
            txt_news_title.Name = "txt_news_title";
            txt_news_title.Size = new Size(174, 27);
            txt_news_title.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(656, 187);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 1;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 116);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 1;
            label4.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(656, 116);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // dgv_news
            // 
            dgv_news.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(18, 297);
            dgv_news.Name = "dgv_news";
            dgv_news.RowHeadersWidth = 51;
            dgv_news.Size = new Size(1018, 299);
            dgv_news.TabIndex = 0;
            dgv_news.RowHeaderMouseDoubleClick += dgv_news_RowHeaderMouseDoubleClick;
            // 
            // nonews
            // 
            nonews.AutoSize = true;
            nonews.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nonews.ForeColor = Color.Red;
            nonews.Location = new Point(364, 400);
            nonews.Name = "nonews";
            nonews.Size = new Size(332, 46);
            nonews.TabIndex = 22;
            nonews.Text = "There is no data yet";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(btn_delete_author);
            tabPage2.Controls.Add(btn_update_author);
            tabPage2.Controls.Add(btn_add_author);
            tabPage2.Controls.Add(txt_author_email);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txt_author_pass);
            tabPage2.Controls.Add(txt_author_age);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txt_author_name);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(dgv_authors);
            tabPage2.Controls.Add(noauthors);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1060, 621);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Author";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label12.ForeColor = Color.Crimson;
            label12.Location = new Point(419, 28);
            label12.Name = "label12";
            label12.Size = new Size(291, 32);
            label12.TabIndex = 24;
            label12.Text = "Manipulate Author Data";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(160, 270);
            label8.Name = "label8";
            label8.Size = new Size(165, 32);
            label8.TabIndex = 20;
            label8.Text = "Authors Data";
            // 
            // btn_delete_author
            // 
            btn_delete_author.BackColor = Color.Red;
            btn_delete_author.ForeColor = Color.White;
            btn_delete_author.Location = new Point(720, 201);
            btn_delete_author.Name = "btn_delete_author";
            btn_delete_author.Size = new Size(147, 29);
            btn_delete_author.TabIndex = 17;
            btn_delete_author.Text = "Delete";
            btn_delete_author.UseVisualStyleBackColor = false;
            btn_delete_author.Click += btn_delete_author_Click;
            // 
            // btn_update_author
            // 
            btn_update_author.BackColor = Color.FromArgb(255, 128, 0);
            btn_update_author.ForeColor = Color.White;
            btn_update_author.Location = new Point(720, 154);
            btn_update_author.Name = "btn_update_author";
            btn_update_author.Size = new Size(147, 29);
            btn_update_author.TabIndex = 18;
            btn_update_author.Text = "Update";
            btn_update_author.UseVisualStyleBackColor = false;
            btn_update_author.Click += btn_update_author_Click;
            // 
            // btn_add_author
            // 
            btn_add_author.BackColor = Color.FromArgb(0, 192, 0);
            btn_add_author.ForeColor = Color.White;
            btn_add_author.Location = new Point(720, 107);
            btn_add_author.Name = "btn_add_author";
            btn_add_author.Size = new Size(147, 29);
            btn_add_author.TabIndex = 19;
            btn_add_author.Text = "Add New";
            btn_add_author.UseVisualStyleBackColor = false;
            btn_add_author.Click += btn_add_author_Click;
            // 
            // txt_author_email
            // 
            txt_author_email.Location = new Point(160, 195);
            txt_author_email.Name = "txt_author_email";
            txt_author_email.Size = new Size(174, 27);
            txt_author_email.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 172);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 8;
            label7.Text = "Email";
            // 
            // txt_author_pass
            // 
            txt_author_pass.Location = new Point(402, 195);
            txt_author_pass.Name = "txt_author_pass";
            txt_author_pass.Size = new Size(174, 27);
            txt_author_pass.TabIndex = 13;
            // 
            // txt_author_age
            // 
            txt_author_age.Location = new Point(402, 130);
            txt_author_age.Name = "txt_author_age";
            txt_author_age.Size = new Size(174, 27);
            txt_author_age.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(402, 172);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 10;
            label11.Text = "Password";
            // 
            // txt_author_name
            // 
            txt_author_name.Location = new Point(160, 130);
            txt_author_name.Name = "txt_author_name";
            txt_author_name.Size = new Size(174, 27);
            txt_author_name.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 107);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 10;
            label6.Text = "Age";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(160, 107);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 10;
            label9.Text = "Name";
            // 
            // dgv_authors
            // 
            dgv_authors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_authors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_authors.Location = new Point(160, 314);
            dgv_authors.Name = "dgv_authors";
            dgv_authors.RowHeadersWidth = 51;
            dgv_authors.Size = new Size(707, 299);
            dgv_authors.TabIndex = 6;
            dgv_authors.RowHeaderMouseDoubleClick += dgv_authors_RowHeaderMouseDoubleClick;
            // 
            // noauthors
            // 
            noauthors.AutoSize = true;
            noauthors.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            noauthors.ForeColor = Color.Red;
            noauthors.Location = new Point(365, 396);
            noauthors.Name = "noauthors";
            noauthors.Size = new Size(332, 46);
            noauthors.TabIndex = 23;
            noauthors.Text = "There is no data yet";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(txt_category_desc);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(btn_delete_category);
            tabPage3.Controls.Add(btn_update_category);
            tabPage3.Controls.Add(btn_add_category);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(txt_category_name);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(dgv_categories);
            tabPage3.Controls.Add(nocategoris);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1060, 621);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add Category";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label17.ForeColor = Color.Crimson;
            label17.Location = new Point(413, 13);
            label17.Name = "label17";
            label17.Size = new Size(315, 32);
            label17.TabIndex = 36;
            label17.Text = "Manipulate Category Data";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_category_desc
            // 
            txt_category_desc.Location = new Point(401, 120);
            txt_category_desc.Name = "txt_category_desc";
            txt_category_desc.Size = new Size(287, 92);
            txt_category_desc.TabIndex = 34;
            txt_category_desc.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(0, 0, 64);
            label10.Location = new Point(160, 235);
            label10.Name = "label10";
            label10.Size = new Size(173, 32);
            label10.TabIndex = 33;
            label10.Text = "All Categories";
            // 
            // btn_delete_category
            // 
            btn_delete_category.BackColor = Color.Red;
            btn_delete_category.ForeColor = Color.White;
            btn_delete_category.Location = new Point(720, 191);
            btn_delete_category.Name = "btn_delete_category";
            btn_delete_category.Size = new Size(147, 29);
            btn_delete_category.TabIndex = 30;
            btn_delete_category.Text = "Delete";
            btn_delete_category.UseVisualStyleBackColor = false;
            btn_delete_category.Click += btn_delete_category_Click;
            // 
            // btn_update_category
            // 
            btn_update_category.BackColor = Color.FromArgb(255, 128, 0);
            btn_update_category.ForeColor = Color.White;
            btn_update_category.Location = new Point(720, 144);
            btn_update_category.Name = "btn_update_category";
            btn_update_category.Size = new Size(147, 29);
            btn_update_category.TabIndex = 31;
            btn_update_category.Text = "Update";
            btn_update_category.UseVisualStyleBackColor = false;
            btn_update_category.Click += btn_update_category_Click;
            // 
            // btn_add_category
            // 
            btn_add_category.BackColor = Color.FromArgb(0, 192, 0);
            btn_add_category.ForeColor = Color.White;
            btn_add_category.Location = new Point(720, 97);
            btn_add_category.Name = "btn_add_category";
            btn_add_category.Size = new Size(147, 29);
            btn_add_category.TabIndex = 32;
            btn_add_category.Text = "Add New";
            btn_add_category.UseVisualStyleBackColor = false;
            btn_add_category.Click += btn_add_category_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(401, 97);
            label13.Name = "label13";
            label13.Size = new Size(85, 20);
            label13.TabIndex = 23;
            label13.Text = "Description";
            // 
            // txt_category_name
            // 
            txt_category_name.Location = new Point(160, 120);
            txt_category_name.Name = "txt_category_name";
            txt_category_name.Size = new Size(174, 27);
            txt_category_name.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(160, 97);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 25;
            label15.Text = "Name";
            // 
            // dgv_categories
            // 
            dgv_categories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categories.Location = new Point(160, 290);
            dgv_categories.Name = "dgv_categories";
            dgv_categories.RowHeadersWidth = 51;
            dgv_categories.Size = new Size(707, 299);
            dgv_categories.TabIndex = 21;
            dgv_categories.RowHeaderMouseDoubleClick += dgv_categories_RowHeaderMouseDoubleClick;
            // 
            // nocategoris
            // 
            nocategoris.AutoSize = true;
            nocategoris.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nocategoris.ForeColor = Color.Red;
            nocategoris.Location = new Point(369, 366);
            nocategoris.Name = "nocategoris";
            nocategoris.Size = new Size(332, 46);
            nocategoris.TabIndex = 35;
            nocategoris.Text = "There is no data yet";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 654);
            Controls.Add(TabControl);
            MaximizeBox = false;
            MaximumSize = new Size(1086, 701);
            MinimizeBox = false;
            MinimumSize = new Size(1086, 701);
            Name = "Form1";
            Text = "Code First - CRUD";
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_authors).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgv_news;
        private Label label3;
        private TextBox txt_news_breif;
        private Label label2;
        private TextBox txt_news_title;
        private Label label1;
        private RichTextBox txt_news_desc;
        private ComboBox cb_authors;
        private ComboBox cb_categories;
        private Label label5;
        private Label label4;
        private Button btn_delete_news;
        private Button btn_update_news;
        private Button btn_add_news;
        private Button btn_delete_author;
        private Button btn_update_author;
        private Button btn_add_author;
        private TextBox txt_author_email;
        private Label label7;
        private TextBox txt_author_name;
        private Label label9;
        private DataGridView dgv_authors;
        private TextBox txt_author_pass;
        private TextBox txt_author_age;
        private Label label11;
        private Label label6;
        private Label label8;
        private Label label10;
        private Button btn_delete_category;
        private Button btn_update_category;
        private Button btn_add_category;
        private Label label13;
        private TextBox txt_category_name;
        private Label label15;
        private DataGridView dgv_categories;
        private RichTextBox txt_category_desc;
        private Label label14;
        private Label label16;
        private Label nonews;
        private Label noauthors;
        private Label nocategoris;
        private Label label12;
        private Label label17;
    }
}
