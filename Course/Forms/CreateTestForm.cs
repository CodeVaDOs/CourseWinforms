using Course.Config;
using Course.Entity;
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
    public partial class CreateTestForm : Form
    {
        public ICollection<Question> Questions = new List<Question>();
        public string TestName { get; set; }

        DatabaseContext dbContext;
        LoggerContext logger;

        public CreateTestForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            logger = LoggerContext.GetInstance();
            InitializeComponent();
        } 

        private void add_question_button_Click(object sender, EventArgs e)
        {
            Hide();
            var newForm = CompositionRoot.Resolve<CreateQuestionForm>();
            newForm.Closed += (s, args) => Show();
            var result = newForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var question = new Question();
                question.Answers = newForm.Answers;
                question.Body = newForm.Question;
                Questions.Add(question);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = question.Body;
                lvi.Tag = question;
                questions_list_view.Items.Add(lvi);
                newForm.Close();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (test_name_field.Text.Length > 0)
            {
                TestName = test_name_field.Text;
                var test = new Test();
                test.Name = TestName;
                test.Questions = Questions;

                dbContext.Tests.Add(test);

                logger.Info($"Успішне створення тесту: {test.Name}");
                dbContext.SaveChanges();
                Close();
            }
        }

        private void questions_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
