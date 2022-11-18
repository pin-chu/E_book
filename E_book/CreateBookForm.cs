using E_book.Infra.Extenstions;
using E_book.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_book
{
    public partial class CreateBookForm : Form
    {
        public CreateBookForm()
        {
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
            // 設定 categoryIdComboBox property
            categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM BookCategories ORDER BY DisplayOrder";
            var dbHelper = new SqlDbHelper("default");

            List<BookCategoryVM> categories = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToCategoryVM(row))
                .Prepend(new BookCategoryVM { Id = 0, CategoryName = String.Empty })
                .ToList();

            this.categoryIdComboBox.DataSource = categories;

        }

        private BookVM ToCategoryVM(DataRow row)
        {
            return new BookVM
            {
                Id = row.Field<int>("Id"),
                CategoryId= row.Field<int>("CategoryId"),
                BookName = row.Field<string>("BookName"),
                Author = row.Field<string>("Author"),
                PublishYear = row.Field<string>("PublishYear"),
            };
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // 取得表單的各欄位值
            //int categoryId = ((BookCategoryVM)this.categoryIdComboBox.SelectedItem).Id;
            string BookName = BookNameTextBox.Text;
            string Author = AuthorTextBox.Text;
            string PublishYear = PublishYearTextBox.Text;

            // 將它們繫結到ViewModel
            BookVM model = new BookVM
            {
                //CategoryId = categoryId,
                BookName = BookName,
                Author = Author,
                PublishYear= PublishYear
            };

           

            // 如果通過驗證,就新增記錄
            string sql = @"INSERT INTO Books
(CategoryId,BookName, Author,PublishYear)
VALUES
(@CategoryId,@BookName, @Author,@PublishYear)";

            var parameters = new SqlParameterBuilder()
                .AddInt("CategoryId", model.CategoryId)
                .AddNVarchar("BookName", 50, model.BookName)
                .AddNVarchar("Author", 50, model.Author)
                .AddNVarchar("PublishYear", 50, model.PublishYear)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            this.DialogResult = DialogResult.OK;
        }
    }
}
