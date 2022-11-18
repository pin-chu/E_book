using E_book.Infra;
using E_book.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_book
{
    public partial class BookForm : Form
    {
        private BookIndexVM[] books = null;
        public BookForm()
        {
            InitializeComponent();

            InitForm();


            DisplayBooks();

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
        private BookCategoryVM ToCategoryVM(DataRow row)
        {
            return new BookCategoryVM
            {
                Id = row.Field<int>("Id"),
                CategoryName = row.Field<string>("CategoryName"),
                DisplayOrder = row.Field<int>("DisplayOrder")
            };
        }
        private void DisplayBooks()
        {
            string sql = @"SELECT B.Id, B.BookName,B.Author, B.PublishYear, C.CategoryName
FROM Books B
INNER JOIN BookCategories C ON B.CategoryId = C.DisplayOrder";

            #region 加入 where 
            SqlParameter[] parameters = new SqlParameter[] { };

            //取得篩選值
            int categoryId = ((BookCategoryVM)categoryIdComboBox.SelectedItem).DisplayOrder;

            if (categoryId > 0)
            {
                sql += " WHERE CategoryId=@CategoryId";
                parameters = new SqlParameterBuilder()
                    .AddInt("CategoryId", categoryId)
                    .Build();
            }
            #endregion
            sql += " ORDER BY C.DisplayOrder, B.BookName";
            var dbHelper = new SqlDbHelper("default");
           
            books = dbHelper.Select(sql, parameters)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row))
                .ToArray();
            BindData(books);
          
        }
        //private string BookName;
        //private string Author;
        //private string PublishYear;
        //private string CategoryName;
        //private bool IsBookTextValid()
        //{
        //    if(BookNameTextBox.Text=="")
        //    { }
        //}

        private void BindData(BookIndexVM[] data)
        {
            dataGridView1.DataSource = data;
        }
        private BookIndexVM ParseToIndexVM(DataRow row)
        {
            return new BookIndexVM
            {
                Id = row.Field<int>("Id"),
                CategoryName = row.Field<string>("CategoryName"),
                BookName = row.Field<string>("BookName"),
                Author = row.Field<string>("Author"),
                PublishYear = row.Field<int>("PublishYear")
            };
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            DisplayBooks();
           
            //
            string BookName = BookNameTextBox.Text;
            string Author = AuthorTextBox.Text;
            string PublishYear = PublishYearTextBox.Text;

            BookVM model = new BookVM
            {
                BookName = BookName,
                Author = Author,
                PublishYear = PublishYear,
            };
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"BookName", BookNameTextBox},
                {"Author", AuthorTextBox},
                {"PublishYear", PublishYearTextBox},
            };
            
        }
        //private void searchButton2_Click(object sender, EventArgs e)
        //{

        //    string BookName = BookNameTextBox.Text;
        //    string Author = AuthorTextBox.Text;
        //    string PublishYear = PublishYearTextBox.Text;

        //    BookVM model = new BookVM
        //    {
        //        BookName = BookName,
        //        Author = Author,
        //        PublishYear = PublishYear,
        //    };
        //    Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
        //    {
        //        {"BookName", BookNameTextBox},
        //        {"Author", AuthorTextBox},
        //        {"PublishYear", PublishYearTextBox},
        //    };

        //}


        private void addnewButton_Click(object sender, EventArgs e)
        {
            var frm = new CreateBookForm();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                DisplayBooks();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndx = e.RowIndex;

            if (rowIndx < 0) return;

            BookIndexVM row = this.books[rowIndx]; 

            int id = row.Id; 

            var frm = new EditBookForm(id);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DisplayBooks();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
