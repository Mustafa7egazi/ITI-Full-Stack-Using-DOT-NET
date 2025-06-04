using Day02____EF_Lab.Models;
using Microsoft.IdentityModel.Tokens;

namespace Day02____EF_Lab
{
    public partial class Form1 : Form
    {
        private NewDBContext db;
        private int selectedNewsId;
        private int selectedAuthorId;
        private int selectedCategoryId;

        public Form1()
        {
            InitializeComponent();
            db = new NewDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<News> newsList = db.News.ToList();
            List<Category> categoriesList = db.Categories.ToList();
            List<Author> authorsList = db.Authors.ToList();
            if (newsList.IsNullOrEmpty())
            {
                dgv_news.Visible = false;
            }
            else
            {
                dgv_news.Visible = true;
                dgv_news.DataSource = newsList.Select(n => new
                {
                    n.NewsId,
                    n.Title,
                    n.Breif,
                    Category = n.Category.Name,
                    Author = n.Author.Name,
                    n.CreatedAt
                }).ToList();
            }



            if (!categoriesList.IsNullOrEmpty())
            {
                dgv_categories.Visible = true;
                dgv_categories.DataSource = categoriesList.Select(c => new
                {
                    c.CategoryId,
                    c.Name,
                    c.Desc,

                }).ToList();

                cb_categories.DataSource = categoriesList;
                cb_categories.DisplayMember = "Name";
                cb_categories.ValueMember = "CategoryId";
            }
            else
            {
                dgv_categories.Visible = false;
                cb_categories.Text = "Categories Unavailable";
            }

            if (!authorsList.IsNullOrEmpty())
            {
                dgv_authors.Visible = true;
                dgv_authors.DataSource = authorsList.Select(a => new
                {
                    a.AuthorId,
                    a.Name,
                    a.Age,
                    a.Email,
                    a.Password
                }).ToList();
                cb_authors.DataSource = authorsList;
                cb_authors.DisplayMember = "Name";
                cb_authors.ValueMember = "AuthorId";
            }
            else
            {
                dgv_authors.Visible = false;
                cb_authors.Text = "Authors Unavailable";
            }

            btn_add_news.Enabled = true;
            btn_update_news.Enabled = false;
            btn_delete_news.Enabled = false;

            btn_add_author.Enabled = true;
            btn_update_author.Enabled = false;
            btn_delete_author.Enabled = false;

            btn_add_category.Enabled = true;
            btn_update_category.Enabled = false;
            btn_delete_category.Enabled = false;

        }

        private void btn_add_news_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (txt_news_title.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Title is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }
            if (txt_news_desc.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Description is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }

            if (txt_news_breif.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Breif is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }

            if (cb_categories.SelectedValue == null)
            {
                isValid = false;
                MessageBox.Show("Category is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }
            if (cb_authors.SelectedValue == null)
            {
                isValid = false;
                MessageBox.Show("Author is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }


            if (isValid)
            {
                News newNews = new News()
                {
                    Title = txt_news_title.Text,
                    Desc = txt_news_desc.Text,
                    Breif = txt_news_breif.Text,
                    CategoryId = (int)cb_categories.SelectedValue,
                    AuthorId = (int)cb_authors.SelectedValue,
                };

                db.News.Add(newNews);
                db.SaveChanges();
                MessageBox.Show("News added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_news_title.Text = "";
                txt_news_desc.Text = "";
                txt_news_breif.Text = "";

                Form1_Load(null, null);

            }
        }

        private void btn_add_author_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (txt_author_name.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_author_name.Text.Trim().Split(" ").Length < 2)
            {
                isValid = false;
                MessageBox.Show("Name must be at least 2 names!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }

            if (txt_author_age.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Age is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }

            if (txt_author_email.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Email is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }

            if (txt_author_pass.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Password is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }

            if (isValid)
            {
                Author newAuthor = new Author()
                {
                    Name = txt_author_name.Text,
                    Age = int.Parse(txt_author_age.Text),
                    Email = txt_author_email.Text,
                    Password = txt_author_pass.Text
                };
                db.Authors.Add(newAuthor);
                db.SaveChanges();
                MessageBox.Show("Author added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_author_name.Text = "";
                txt_author_email.Text = "";
                txt_author_age.Text = "";
                txt_author_pass.Text = "";
                Form1_Load(null, null);

            }
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (txt_category_name.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Category name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }

            if (txt_category_desc.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Description is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                isValid = true;
            }


            if (isValid)
            {
                Category newCategory = new Category()
                {
                    Name = txt_category_name.Text,
                    Desc = txt_category_desc.Text
                };
                db.Categories.Add(newCategory);
                db.SaveChanges();
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_category_name.Text = "";
                txt_category_desc.Text = "";
                Form1_Load(null, null);

            }

        }

        private void dgv_news_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedNewsId = (int)dgv_news.SelectedRows[0].Cells[0].Value;
            News selectedNews = db.News.SingleOrDefault(n => n.NewsId == selectedNewsId);

            txt_news_title.Text = selectedNews.Title;
            txt_news_desc.Text = selectedNews.Desc;
            txt_news_breif.Text = selectedNews.Breif;
            cb_categories.SelectedValue = selectedNews.CategoryId;
            cb_authors.SelectedValue = selectedNews.AuthorId;
            btn_update_news.Enabled = true;
            btn_delete_news.Enabled = true;
            btn_add_author.Enabled = false;
        }

        private void dgv_authors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedAuthorId = (int)dgv_authors.SelectedRows[0].Cells[0].Value;
            Author selectedAuthor = db.Authors.SingleOrDefault(a => a.AuthorId == selectedAuthorId);
            txt_author_name.Text = selectedAuthor.Name;
            txt_author_age.Text = selectedAuthor.Age.ToString();
            txt_author_email.Text = selectedAuthor.Email;
            txt_author_pass.Text = selectedAuthor.Password;
            btn_update_author.Enabled = true;
            btn_delete_author.Enabled = true;
            btn_add_news.Enabled = false;
        }

        private void dgv_categories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedCategoryId = (int)dgv_categories.SelectedRows[0].Cells[0].Value;
            Category selectedCategory = db.Categories.SingleOrDefault(c => c.CategoryId == selectedCategoryId);
            txt_category_name.Text = selectedCategory.Name;
            txt_category_desc.Text = selectedCategory.Desc;
            btn_update_category.Enabled = true;
            btn_delete_category.Enabled = true;
            btn_add_category.Enabled = false;
        }

        private void btn_update_category_Click(object sender, EventArgs e)
        {
            selectedCategoryId = (int)dgv_categories.SelectedRows[0].Cells[0].Value;
            Category selectedCategory = db.Categories.SingleOrDefault(c => c.CategoryId == selectedCategoryId);
            if (txt_category_name.Text.Trim() == "" || txt_category_desc.Text.Trim() == "")
            {
                MessageBox.Show("Can't set empty values on update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectedCategory.Name = txt_category_name.Text;
                selectedCategory.Desc = txt_category_desc.Text;
                db.SaveChanges();
                MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_category_name.Text = "";
                txt_category_desc.Text = "";
                Form1_Load(null, null);
            }

        }

        private void btn_update_author_Click(object sender, EventArgs e)
        {
            selectedAuthorId = (int)dgv_authors.SelectedRows[0].Cells[0].Value;
            Author selectedAuthor = db.Authors.SingleOrDefault(c => c.AuthorId == selectedAuthorId);
            if (txt_author_name.Text.Trim() == "" || txt_author_age.Text.Trim() == "" || txt_author_email.Text.Trim() == "" || txt_author_pass.Text.Trim() == "")
            {
                MessageBox.Show("Can't set empty values on update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectedAuthor.Name = txt_author_name.Text;
                selectedAuthor.Email = txt_author_email.Text;
                selectedAuthor.Age = int.Parse(txt_author_age.Text);
                selectedAuthor.Password = txt_author_pass.Text;
                db.SaveChanges();
                MessageBox.Show("Author updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_author_name.Text = txt_author_email.Text = txt_author_pass.Text = txt_author_age.Text = "";
                Form1_Load(null, null);
            }

        }

        private void btn_update_news_Click(object sender, EventArgs e)
        {
            selectedNewsId = (int)dgv_news.SelectedRows[0].Cells[0].Value;
            News selectedNews = db.News.SingleOrDefault(c => c.NewsId == selectedNewsId);
            if (txt_news_title.Text.Trim() == "" || txt_news_desc.Text.Trim() == "" || txt_news_breif.Text.Trim() == "")
            {
                MessageBox.Show("Can't set empty values on update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectedNews.Title = txt_news_title.Text;
                selectedNews.Desc = txt_news_desc.Text;
                selectedNews.Breif = txt_news_breif.Text;
                selectedNews.AuthorId = (int)cb_authors.SelectedValue;
                selectedNews.CategoryId = (int)cb_categories.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("News updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_news_title.Text = txt_news_desc.Text = txt_news_breif.Text = "";
                Form1_Load(null, null);
            }
        }

        private void btn_delete_news_Click(object sender, EventArgs e)
        {
            selectedNewsId = (int)dgv_news.SelectedRows[0].Cells[0].Value;
            News selectedNews = db.News.SingleOrDefault(c => c.NewsId == selectedNewsId);
            if (MessageBox.Show("Are You Sure You want to delete this news?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.News.Remove(selectedNews);
                db.SaveChanges();
                MessageBox.Show("News deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(null, null);
            }
        }

        private void btn_delete_author_Click(object sender, EventArgs e)
        {
            selectedAuthorId = (int)dgv_authors.SelectedRows[0].Cells[0].Value;
            Author selectedAuthor = db.Authors.SingleOrDefault(c => c.AuthorId == selectedAuthorId);
            if (MessageBox.Show("Are You Sure You want to delete this Author?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Authors.Remove(selectedAuthor);
                db.SaveChanges();
                MessageBox.Show("Author deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(null, null);
            }
        }

        private void btn_delete_category_Click(object sender, EventArgs e)
        {
            selectedCategoryId = (int)dgv_categories.SelectedRows[0].Cells[0].Value;
            Category selectedCategory = db.Categories.SingleOrDefault(c => c.CategoryId == selectedCategoryId);
            if (MessageBox.Show("Are You Sure You want to delete this Category?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Categories.Remove(selectedCategory);
                db.SaveChanges();
                MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(null, null);
            }
        }

        private void TabControl_MouseClick(object sender, MouseEventArgs e)
        {
            Form1_Load(null, null);
        }
    }
}
