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
    public partial class TestsForm : Form
    {
        DatabaseContext dbContext;
        LoggerContext loggerContext;
        public TestsForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            loggerContext = LoggerContext.GetInstance();
            InitializeComponent();
        }

        private void TestsForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            var dataTable = new DataTable();
            var idCol = dataTable.Columns.Add("ID", typeof(long));
            var nameCol = dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("CountQuestions", typeof(Int32));

            idCol.Unique = true;
            nameCol.AllowDBNull = false;
            nameCol.Unique = true;

            var Tests = dbContext.Tests.Include("Questions");

            foreach (Test test in Tests)
            {
                var row = dataTable.NewRow();
                row["ID"] = test.ID;
                row["Name"] = test.Name;
                row["CountQuestions"] = test.Questions.Count();
                dataTable.Rows.Add(row);
            }
            var view = new DataView(dataTable);
            tests_list_view.DataSource = view;
        }

        private void tests_list_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var id = (long) tests_list_view.Rows[e.RowIndex].Cells[0].Value;
            var Test = dbContext.Tests.SingleOrDefault(t => t.ID == id);
            //var editForm = new CreateTestForm(Test);
            //editForm.Closed += (s, args) =>
            //{
            //    if (editForm.DialogResult == DialogResult.OK)
            //    {
            //        var newTest = editForm.newUser;
            //        User.Login = newUser.Login;
            //        User.Password = newUser.Password;
            //        User.UserRole = newUser.UserRole;
            //        dbContext.SaveChanges();
            //        loggerContext.Info($"Успішне редагування користувача: {newUser.Login}");
            //        MessageBox.Show($"Успішне редагування користувача: {newUser.Login}", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        if (authContext.AuthorizedUser.ID == User.ID)
            //        {
            //            authContext.Authorize(User);
            //        }

            //        Load_Table();
            //    }
            //};
            //editForm.ShowDialog();
        }
    }
}
