using E_book.Infra.Extenstions;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_book
{
    public partial class CreateBookCategoryForm : Form
    {
        public CreateBookCategoryForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string categoryName = CNTextBox.Text;

            
            int displayOrder = CITextBox.Text.ToInt(-1);

            string sql = @"INSERT INTO BookCategories
(CategoryName, DisplayOrder)
VALUES
(@CategoryName, @DisplayOrder)";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("CategoryName", 50, categoryName)
                .AddInt("DisplayOrder", displayOrder)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            // MessageBox.Show("記錄已新增");
            this.DialogResult = DialogResult.OK;
        }
    }
}
