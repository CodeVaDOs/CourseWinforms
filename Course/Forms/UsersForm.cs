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
        public UsersForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            // var idCol = dataTable.Columns.Add("ID", typeof(long));
            var loginCol = dataTable.Columns.Add("Login", typeof(string));
            var passCol = dataTable.Columns.Add("Password", typeof(string));
            var roleCol = dataTable.Columns.Add("Role", typeof(Int32));

            // idCol.Unique = true;
            loginCol.AllowDBNull = false;
            passCol.AllowDBNull = false;
            roleCol.AllowDBNull = false;
            loginCol.Unique = true;

            var Users = dbContext.Users;
           
            foreach (User user in Users)
            {
                var row = dataTable.NewRow();
                // row["ID"] = user.ID;
                row["Login"] = user.Login;
                row["Password"] = "****";
                row["Role"] = user.UserRole;
                dataTable.Rows.Add(row);
            }
            var view = new DataView(dataTable);
            users_list_view.DataSource = view;
        }

        private void users_list_view_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Console.WriteLine(e.Row.Cells["Login"].Value);
            Console.WriteLine(e.Row.Cells["Password"].Value);
            Console.WriteLine(e.Row.Cells["Role"].Value);
        }
    }
}
