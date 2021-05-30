using Course.Config;
using Course.Entity;
using Course.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Course.Forms
{
    public partial class CreateTestForm : Form
    {
        public ICollection<Question> Questions = new List<Question>();
        public string TestName { get; set; }

        private readonly DatabaseContext dbContext;
        private readonly LoggerContext logger;

        public CreateTestForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            logger = LoggerContext.GetInstance();
            InitializeComponent();
        }

        private void add_question_button_Click(object sender, EventArgs e)
        {
            Hide();
            CreateQuestionForm newForm = CompositionRoot.Resolve<CreateQuestionForm>();
            newForm.Closed += (s, args) => Show();
            DialogResult result = newForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Question question = new Question
                {
                    Answers = newForm.Answers,
                    Body = newForm.Question
                };
                Questions.Add(question);
                ListViewItem lvi = new ListViewItem
                {
                    Text = question.Body,
                    Tag = question
                };
                questions_list_view.Items.Add(lvi);
                newForm.Close();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (test_name_field.Text.Length > 0)
            {
                TestName = test_name_field.Text;
                Test test = new Test
                {
                    Name = TestName,
                    Questions = Questions
                };

                dbContext.Tests.Add(test);

                logger.Info($"Успішне створення тесту: {test.Name}");
                dbContext.SaveChanges();
                Close();
            }
        }
    }
}
