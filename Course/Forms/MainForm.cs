using Course.Config;
using Course.Entity;
using Course.Entity.Enum;
using Course.Util;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Course.Forms
{
    public partial class MainForm : Form
    {
        private readonly AuthContext authContext;
        private readonly LoggerContext loggerContext;
        private readonly DatabaseContext dbContext;
        public MainForm(DatabaseContext _dbContext)
        {

            authContext = AuthContext.GetInstance();
            loggerContext = LoggerContext.GetInstance();
            dbContext = _dbContext;

            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeUser.Text = $"Привіт, {authContext.AuthorizedUser.Login}!";
            Show_Analytics();
            Show_Tests();
            adminToolStripMenuItem.Visible = authContext.AuthorizedUser.UserRole == ERole.Admin;


        }


        private void createTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CreateTestForm newForm = CompositionRoot.Resolve<CreateTestForm>();
            newForm.Closed += (s, args) =>
            {
                Show_Analytics();
                Show_Tests();
                Show();
            };
            newForm.ShowDialog();
        }

        private void Show_Analytics()
        {
            results_chart.Series.Clear();
            results_chart.Titles.Clear();

            IQueryable<TestResult> resultsWithTests = dbContext.TestResults.Include("Test").Where(tr => tr.UserID == authContext.AuthorizedUser.ID);

            foreach (TestResult result in resultsWithTests)
            {
                System.Windows.Forms.DataVisualization.Charting.Series label = results_chart.Series.FindByName(result.Test.Name);
                System.Windows.Forms.DataVisualization.Charting.Series series = label == null ? results_chart.Series.Add(result.Test.Name) : label;
                series.Points.Add(result.PercentOfRightAnswers);
            }

        }

        private void Show_Tests()
        {
            System.Data.Entity.Infrastructure.DbQuery<Test> tests = dbContext.Tests.Include("Questions.Answers");
            test_select_view.Items.Clear();
            foreach (Test test in tests)
            {
                ListViewItem listItem = new ListViewItem
                {
                    Tag = test,
                    Text = test.Name
                };
                test_select_view.Items.Add(listItem);
            }

        }

        private void analyticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            StatysticForm analyticForm = CompositionRoot.Resolve<StatysticForm>();
            analyticForm.Closed += (s, args) =>
            {
                Show();
            };
            analyticForm.ShowDialog();
        }

        private void test_select_button_Click(object sender, EventArgs e)
        {
            if (test_select_view.SelectedItems.Count > 0)
            {
                Hide();
                Test test = (Test)test_select_view.SelectedItems[0].Tag;

                loggerContext.Info($"Початок проходження тестування: {test.Name}, користувачем: {authContext.AuthorizedUser.Login}. {test.Questions}");

                int CountRightAnswers = 0;
                bool isError = false;

                foreach (Question q in test.Questions)
                {
                    TestingForm testingForm = new TestingForm(q);
                    testingForm.Closed += (s, args) =>
                    {
                        if (testingForm.DialogResult == DialogResult.OK)
                        {
                            System.Collections.Generic.IEnumerable<Answer> rightAnswers = from a in q.Answers where a.IsRightAnswer == true select a;
                            System.Collections.Generic.IEnumerable<Answer> userRightAnswers = from a in testingForm.UserAnswers where a.IsRightAnswer == true select a;

                            if (rightAnswers.Count() == userRightAnswers.Count() && userRightAnswers.Count() == testingForm.UserAnswers.Count())
                            {
                                CountRightAnswers++;
                            }
                        }
                        else
                        {
                            isError = true;
                        }
                    };
                    testingForm.ShowDialog();
                    if (isError)
                    {
                        break;
                    }
                }

                if (!isError)
                {
                    TestResult result = new TestResult
                    {
                        UserID = authContext.AuthorizedUser.ID,
                        TestID = test.ID,
                        PercentOfRightAnswers = (int)((CountRightAnswers / (double)test.Questions.Count()) * 100),
                        Date = DateTime.Now
                    };
                    dbContext.TestResults.Add(result);
                    dbContext.SaveChanges();

                    loggerContext.Info($"Закінчення проходження тестування: {test.Name}, користувачем: {authContext.AuthorizedUser.Login}. Правильних відповідей: {result.PercentOfRightAnswers}%");
                    MessageBox.Show($"Результат проходження тестування: {result.PercentOfRightAnswers}%", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MainForm_Load(sender, e);
                Show();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            UsersForm usersForm = CompositionRoot.Resolve<UsersForm>();
            usersForm.Closed += (s, args) =>
            {
                MainForm_Load(sender, e);
                Show();
            };
            usersForm.ShowDialog();
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            TestsForm testsForm = CompositionRoot.Resolve<TestsForm>();
            testsForm.Closed += (s, args) =>
            {
                MainForm_Load(sender, e);
                Show();
            };
            testsForm.ShowDialog();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            User User = dbContext.Users.SingleOrDefault(u => u.ID == authContext.AuthorizedUser.ID);
            EditUserForm editUserForm = new EditUserForm(User, false, false);
            editUserForm.Closed += (s, args) =>
            {
                if (editUserForm.DialogResult == DialogResult.OK)
                {
                    User newUser = editUserForm.newUser;
                    User.Password = newUser.Password;
                    dbContext.SaveChanges();
                    loggerContext.Info($"Успішне редагування користувача: {newUser.Login}");
                    MessageBox.Show($"Успішне редагування!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Show();
            };
            editUserForm.ShowDialog();
        }
    }
}
