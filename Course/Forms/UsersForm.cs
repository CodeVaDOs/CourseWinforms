using Course.Config;
using Course.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course.Forms
{
    public partial class UsersForm : Form
    {
        DatabaseContext dbContext;
        LoggerContext loggerContext;
        AuthContext authContext;
        public UsersForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            authContext = AuthContext.GetInstance();
            loggerContext = LoggerContext.GetInstance();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            Load_Table();   
        }

        private void Load_Table()
        {
            var dataTable = new DataTable();
            var idCol = dataTable.Columns.Add("ID", typeof(long));
            var loginCol = dataTable.Columns.Add("Login", typeof(string));
            var passCol = dataTable.Columns.Add("Password", typeof(string));
            var roleCol = dataTable.Columns.Add("Role", typeof(Int32));

            idCol.Unique = true;
            loginCol.AllowDBNull = false;
            passCol.AllowDBNull = false;
            roleCol.AllowDBNull = false;
            loginCol.Unique = true;

            var Users = dbContext.Users;

            foreach (User user in Users)
            {
                var row = dataTable.NewRow();
                row["ID"] = user.ID;
                row["Login"] = user.Login;
                row["Password"] = "****";
                row["Role"] = user.UserRole;
                dataTable.Rows.Add(row);
            }
            var view = new DataView(dataTable);
            users_list_view.DataSource = view;
        }

        private void users_list_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var id = (long) users_list_view.Rows[e.RowIndex].Cells[0].Value;
            var User = dbContext.Users.SingleOrDefault(u => u.ID == id);
            var editForm = new EditUserForm(User);
            editForm.Closed += (s, args) =>
            {
                if (editForm.DialogResult == DialogResult.OK)
                {
                    var newUser = editForm.newUser;
                    User.Login = newUser.Login;
                    User.Password = newUser.Password;
                    User.UserRole = newUser.UserRole;
                    dbContext.SaveChanges();
                    loggerContext.Info($"Успішне редагування користувача: {newUser.Login}");
                    MessageBox.Show($"Успішне редагування користувача: {newUser.Login}", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (authContext.AuthorizedUser.ID == User.ID)
                    {
                        authContext.Authorize(User);
                    }

                    Load_Table();
                }
            };
            editForm.ShowDialog();

        }
    }
}
