using Course.Config;
using Course.Entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Course.Forms
{
    public partial class TestsForm : Form
    {
        private readonly DatabaseContext dbContext;
        private readonly LoggerContext loggerContext;
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
            DataTable dataTable = new DataTable();
            DataColumn idCol = dataTable.Columns.Add("ID", typeof(long));
            DataColumn nameCol = dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("CountQuestions", typeof(int));

            idCol.Unique = true;
            nameCol.AllowDBNull = false;
            nameCol.Unique = true;

            System.Data.Entity.Infrastructure.DbQuery<Test> Tests = dbContext.Tests.Include("Questions");

            foreach (Test test in Tests)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = test.ID;
                row["Name"] = test.Name;
                row["CountQuestions"] = test.Questions.Count();
                dataTable.Rows.Add(row);
            }
            DataView view = new DataView(dataTable);
            tests_list_view.DataSource = view;
        }

        private void tests_list_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            long id = (long)tests_list_view.Rows[e.RowIndex].Cells[0].Value;
            Test Test = dbContext.Tests.SingleOrDefault(t => t.ID == id);
        }
    }
}
