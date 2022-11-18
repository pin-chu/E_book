using E_book.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace E_book
{
    //private FictionCategoryVM[] categories = null;
    public partial class BookCategoryForm : Form
    {
        DataTable categories;
        public BookCategoryForm()
        {
            InitializeComponent();
            InitForm();

            DisplayBookCatetories();
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

        private void DisplayBookCatetories()
        {
            string sql = @"SELECT [Id],[CategoryName],[DisplayOrder] 
            FROM BookCategories ORDER BY DisplayOrder";

            categories = new SqlDbHelper("default").Select(sql, null);


            SqlParameter[] parameters = new SqlParameter[] { };
            int categoryId = ((BookCategoryVM)categoryIdComboBox.SelectedItem).DisplayOrder;

            if (categoryId > 0)
            {
                sql += " WHERE CategoryId=@CategoryId";
                parameters = new SqlParameterBuilder()
                    .AddInt("CategoryId", categoryId)
                    .Build();
            }

            sql += " ORDER BY C.DisplayOrder, B.BookName";
            var dbHelper = new SqlDbHelper("default");

            //categories = dbHelper.Select(sql, parameters)
             //   .AsEnumerable()
             //   .Select(row => ParseToIndexVM(row))
              //  .ToArray();

            BindData(categories);
        }
        //****
        private void DisplayFictionCatetories()
        {
            string sql = @"SELECT C.[Id],C.[CategoryName],F.[FictionName],F.[FictionId]
FROM BookCategories C
INNER JOIN FictionCategories f ON C.DisplayOrder = F.DisplayOrder";

            SqlParameter[] parameters = new SqlParameter[] { };

            categories = new SqlDbHelper("default").Select(sql, null);

            int categoryId = ((FictionCategoryVM)categoryIdComboBox.SelectedItem).DisplayOrder;

            if (categoryId > 0)
            {
                sql += " WHERE CategoryId=@CategoryId";
                parameters = new SqlParameterBuilder()
                    .AddInt("CategoryId", categoryId)
                    .Build();
            }

            sql += " ORDER BY C.DisplayOrder, B.BookName";
            var dbHelper = new SqlDbHelper("default");

            //categories = dbHelper.Select(sql, parameters)
            //    .AsEnumerable()
            //    .Select(row => ParseToIndexVM(row))
            //    .ToArray();

            BindData(categories);
        }

        private void BindData(DataTable model)
        {
            dataGridView1.DataSource = model;
        }
        private BookCategoryIndexVM ParseToIndexVM(DataRow row)
        {
            return new BookCategoryIndexVM
            {
                Id = row.Field<int>("Id"),
                CategoryName = row.Field<string>("CategoryName"),
                FictionName = row.Field<string>("FictionName"),
                DisplayOrder = row.Field<int>("DisplayOrder"),
                FictionId = row.Field<int>("FictionId")
            };
        }
       
        private void searchButton_Click(object sender, EventArgs e)
        {
            DisplayBookCatetories();
        }
        private void searchButton2_Click(object sender, EventArgs e)
        {
            DisplayFictionCatetories();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            var frm = new CreateBookCategoryForm();

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DisplayBookCatetories();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0) return;

           // BookCategoryIndexVM row = this.categories[rowIndex];

            DataRow row = this.categories.Rows[rowIndex];
            int id = row.Field<int>("Id");

            var frm = new EditBookCategoryForm(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DisplayBookCatetories();
            }
        }
    }
}
