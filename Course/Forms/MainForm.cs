using Course.Config;
using Course.Entity;
using Course.Entity.Enum;
using Course.Util;
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
    public partial class MainForm : Form
    {

        AuthContext authContext;
        LoggerContext loggerContext;
        DatabaseContext dbContext;
        public MainForm(DatabaseContext _dbContext)
        {

            authContext = AuthContext.GetInstance();
            loggerContext = LoggerContext.GetInstance();
            dbContext = _dbContext;

            InitializeComponent();
        }

        private void WelcomeUser_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeUser.Text += $", {authContext.AuthorizedUser.Login}!";
            Show_Analytics();
            Show_Tests();
            adminToolStripMenuItem.Visible = authContext.AuthorizedUser.UserRole == ERole.Admin;
        }

        private void create_test_Click(object sender, EventArgs e)
        {
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var newForm = CompositionRoot.Resolve<CreateTestForm>();
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
            count_tests.Text = dbContext.Tests.Count().ToString();
            count_users.Text = (from u in dbContext.Users where u.UserRole == ERole.User select u.ID).Count().ToString();
            count_admins.Text = (from u in dbContext.Users where u.UserRole == ERole.Admin select u.ID).Count().ToString();
        }

        private void Show_Tests()
        {
            var tests = dbContext.Tests.Include("Questions.Answers");
            test_select_view.Items.Clear();
            foreach (Test test in tests)
            {
                var listItem = new ListViewItem();
                listItem.Tag = test;
                listItem.Text = test.Name;
                test_select_view.Items.Add(listItem);
            }
            
        }

        private void analyticToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void test_select_button_Click(object sender, EventArgs e)
        {
            if (test_select_view.SelectedItems.Count > 0)
            {
                Hide();
                var test = (Test) test_select_view.SelectedItems[0].Tag;

                loggerContext.Info($"Початок проходження тестування: {test.Name}, користувачем: {authContext.AuthorizedUser.Login}. {test.Questions}");

                int CountRightAnswers = 0;
                bool isError = false;

                foreach (Question q in test.Questions)
                {
                    var testingForm = new TestingForm(q);
                    testingForm.Closed += (s, args) =>
                    {
                        if (testingForm.DialogResult == DialogResult.OK)
                        {
                            var rightAnswers = from a in q.Answers where a.IsRightAnswer == true select a;
                            var userRightAnswers = from a in testingForm.UserAnswers where a.IsRightAnswer == true select a;

                            if (rightAnswers.Count() == userRightAnswers.Count() && userRightAnswers.Count() == testingForm.UserAnswers.Count())
                            {
                                CountRightAnswers++;
                            }
                        } else
                        {
                            isError = true;
                        }
                    };
                    testingForm.ShowDialog();
                    if (isError) break;
                }

                if (!isError)
                {
                    var result = new TestResult();
                    result.UserID = authContext.AuthorizedUser.ID;
                    result.TestID = test.ID;
                    result.PercentOfRightAnswers = (int)(((double)CountRightAnswers / (double)test.Questions.Count()) * 100);

                    dbContext.TestResults.Add(result);
                    dbContext.SaveChanges();

                    loggerContext.Info($"Закінчення проходження тестування: {test.Name}, користувачем: {authContext.AuthorizedUser.Login}. Правильних відповідей: {result.PercentOfRightAnswers}%");
                    MessageBox.Show($"Результат проходження тестування: {result.PercentOfRightAnswers}%", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Show();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var usersForm = CompositionRoot.Resolve<UsersForm>();
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
            var testsForm = CompositionRoot.Resolve<TestsForm>();
            testsForm.Closed += (s, args) =>
            {
                MainForm_Load(sender, e);
                Show();
            };
            testsForm.ShowDialog();
        }
    }
}
