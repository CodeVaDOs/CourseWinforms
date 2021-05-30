using Course.Config;
using Course.Entity;
using Course.Entity.Enum;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Course.Forms
{
    public partial class StatysticForm : Form
    {
        private readonly DatabaseContext dbContext;
        public StatysticForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            InitializeComponent();
        }

        private void StatysticForm_Load(object sender, System.EventArgs e)
        {
            results_chart.Series.Clear();
            results_chart.Titles.Clear();
            System.Data.Entity.Infrastructure.DbQuery<TestResult> resultsWithTests = dbContext.TestResults.Include("Test");

            foreach (TestResult result in resultsWithTests)
            {
                Series label = results_chart.Series.FindByName(result.Test.Name);
                Series series = label == null ? results_chart.Series.Add(result.Test.Name) : label;
                series.Points.Add(result.PercentOfRightAnswers);
                DataPoint point = new DataPoint();
                series.Points.Add(point);
            }

            count_users.Text = dbContext.Users.Where(u => u.UserRole == ERole.User).Count().ToString();
            count_admins.Text = dbContext.Users.Where(u => u.UserRole == ERole.Admin).Count().ToString();
            count_tests.Text = dbContext.Tests.Count().ToString();
            count_passed_tests.Text = dbContext.TestResults.Count().ToString();
        }
    }
}
