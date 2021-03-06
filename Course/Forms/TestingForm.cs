using Course.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Course.Forms
{
    public partial class TestingForm : Form
    {
        public ICollection<Answer> UserAnswers = new List<Answer>();
        private readonly Question question;
        public TestingForm(Question _question)
        {
            question = _question;
            InitializeComponent();
        }

        private void answer_button_Click(object sender, EventArgs e)
        {
            if (test_answers_view.CheckedItems.Count > 0)
            {
                foreach (ListViewItem item in test_answers_view.CheckedItems)
                {
                    UserAnswers.Add((Answer)item.Tag);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Потрібно обрати хоч одну відповіть.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {
            question_title.Text = question.Body;
            foreach (Answer answer in question.Answers)
            {
                ListViewItem itemList = new ListViewItem
                {
                    Text = answer.Body,
                    Tag = answer
                };
                test_answers_view.Items.Add(itemList);
                test_answers_view.CheckBoxes = true;
            }
        }
    }
}
