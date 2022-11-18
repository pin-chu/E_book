using E_book.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_book.Models.Service
{
    internal class UserService
    {
        public IEnumerable<UserIndexVM> GetAll()
        {
            string sql = @"SELECT * FROM Users ORDER BY ID DESC";

            var dbHelper = new SqlDbHelper("default");

            return dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row))
                .ToList();
        }
        public void Create(UserVM model)
        {
            bool isExists = AccountExists(model.Account);
            if (isExists) throw new Exception("帳號已存在");

            string sql = @"INSERT INTO Users
(Account,Password, Name)
VALUES
(@Account,@Password, @Name)";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Account", 50, model.Account)
                .AddNVarchar("Password", 50, model.Password)
                .AddNVarchar("Name", 50, model.Name)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
        }
        private bool AccountExists(string account)
        {
            string sql = @" SELECT Count(*) as count FROM Users Where Account = @Account";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Account", 50, account)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);
            return data.Rows[0].Field<int>("count") > 0;
        }

        private UserIndexVM ParseToIndexVM(DataRow row)
        {
            return new UserIndexVM
            {
                Id = row.Field<int>("id"),
                Account = row.Field<string>("Account"),
                Password = row.Field<string>("Password"),//通常不用看到密碼
                Name = row.Field<string>("Name")
            };
        }

        internal bool Authenticate(LoginVM model)
        {
            var user = Get(model.Account);
            if (user == null) return false;

            return (user.Password == model.Password);
        }
        public UserVM Get(string account)
        {
            string sql = "SELECT * FROM Users WHERE Account=@Account";
            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Account", 50, account)
                .Build();
            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                return null;
            }

            return ToUserVM(data.Rows[0]);

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
    }
}
