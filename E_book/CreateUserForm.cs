using E_book.Infra;
using E_book.Models.Service;
using E_book.Models.ViewModels;
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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string account = AccountTextBox.Text;
            string password = PasswordTextBox.Text;
            string name = NameTextBox.Text; 

            
            UserVM model = new UserVM
            {
                Account = account,
                Password = password,
                Name = name
            };

            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Account",AccountTextBox },
                {"Password",PasswordTextBox },
                {"Name",NameTextBox},
             };

            bool isVaid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isVaid) return;

            // 如果通過驗證,就新增記錄
            try
            {
                new UserService().Create(model);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗,因為:" + ex.Message);
            }
        }
    }
}
