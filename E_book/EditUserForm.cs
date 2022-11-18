using E_book.Models.ViewModels;
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
    public partial class EditUserForm : Form
    {
        private int id;
        public EditUserForm(int id)
        {
            InitializeComponent();
            BindData(id);
            this.id = id;
        }
        private void EditUserForm_Load(object sender, EventArgs e)
        {
            BindData(id);
        }
        private void BindData(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id=@Id";
            var parameters = new SqlParameterBuilder()
                .AddInt("Id", id)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("抱歉, 找不到要編輯的記錄");
                this.DialogResult = DialogResult.Abort;

                
                return;
            }

            
            UserVM model = ToUserVM(data.Rows[0]);

            accountTextBox.Text = model.Account;
            passwordTextBox.Text = model.Password;
            NameTextBox.Text = model.Name;

        }
        private UserVM ToUserVM(DataRow row)
        {
            return new UserVM
            {
                Id = row.Field<int>("Id"),
                Account = row.Field<string>("Account"),
                Password = row.Field<string>("Password"),
                Name = row.Field<string>("Name")
            };
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string Account = accountTextBox.Text;
            string Name = NameTextBox.Text;
            string Password = passwordTextBox.Text;

            
            UserVM model = new UserVM
            {
                Account = Account,
                Password = Password,
                Name = Name
            };
            string sql = @"UPDATE Users
			SET Account=@Account, Password=@Password, Name = @Name
			WHERE Id=@Id";


            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Account", 50, model.Account)
                .AddNVarchar("Password", 50, model.Password)
                .AddNVarchar("Name", 50, model.Name)
                .AddInt("Id", this.id)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            this.DialogResult = DialogResult.OK;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox
               .Show("您真的要刪除嗎?",
                       "刪除記錄",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            string sql = @"DELETE FROM Users WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddInt("Id", this.id)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            this.DialogResult = DialogResult.OK;
        }
    }
}
