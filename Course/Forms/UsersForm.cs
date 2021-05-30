using Course.Config;
using Course.Entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Course.Forms
{
    public partial class UsersForm : Form
    {
        private readonly DatabaseContext dbContext;
        private readonly LoggerContext loggerContext;
        private readonly AuthContext authContext;
        public UsersForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            authContext = AuthContext.GetInstance();
            loggerContext = LoggerContext.GetInstance();
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            Load_Table();
        }

        private void Load_Table()
        {
            DataTable dataTable = new DataTable();
            DataColumn idCol = dataTable.Columns.Add("ID", typeof(long));
            DataColumn loginCol = dataTable.Columns.Add("Login", typeof(string));
            DataColumn passCol = dataTable.Columns.Add("Password", typeof(string));
            DataColumn roleCol = dataTable.Columns.Add("Role", typeof(int));

            idCol.Unique = true;
            loginCol.AllowDBNull = false;
            passCol.AllowDBNull = false;
            roleCol.AllowDBNull = false;
            loginCol.Unique = true;

            System.Data.Entity.DbSet<User> Users = dbContext.Users;

            foreach (User user in Users)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = user.ID;
                row["Login"] = user.Login;
                row["Password"] = "****";
                row["Role"] = user.UserRole;
                dataTable.Rows.Add(row);
            }
            DataView view = new DataView(dataTable);
            users_list_view.DataSource = view;
        }

        private void users_list_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            long id = (long)users_list_view.Rows[e.RowIndex].Cells[0].Value;
            User User = dbContext.Users.SingleOrDefault(u => u.ID == id);
            EditUserForm editForm = new EditUserForm(User);
            editForm.Closed += (s, args) =>
            {
                if (editForm.DialogResult == DialogResult.OK)
                {
                    User newUser = editForm.newUser;
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
