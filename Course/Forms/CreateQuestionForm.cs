using Course.Config;
using Course.Entity;
using Course.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Course.Forms
{
    public partial class CreateQuestionForm : Form
    {

        public ICollection<Answer> Answers = new List<Answer>();
        private readonly DatabaseContext dbContext;
        public string Question { get; set; }
        public CreateQuestionForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_field_TextChanged(object sender, EventArgs e)
        {

        }


        private void save_question_button_Click(object sender, EventArgs e)
        {
            if (question_field.Text.Length > 0 && Answers.Any(a => a.IsRightAnswer))
            {
                Question = question_field.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void add_answer_button_Click(object sender, EventArgs e)
        {
            Hide();
            CreateAnswerForm newForm = CompositionRoot.Resolve<CreateAnswerForm>();
            newForm.Closed += (s, args) => Show();

            DialogResult result = newForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Answer answer = new Answer
                {
                    Body = newForm.InputText
                };
                Answers.Add(answer);
                ListViewItem lvi = new ListViewItem
                {
                    Text = answer.Body,
                    Tag = answer
                };
                answers_list_view.Items.Add(lvi);
            }
        }

        private void answers_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateQuestionForm_Load(object sender, EventArgs e)
        {
            answers_list_view.CheckBoxes = true;
        }

        private void answers_list_view_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Answer item = (Answer)answers_list_view.Items[e.Index].Tag;
            item.IsRightAnswer = e.NewValue == CheckState.Checked;
        }
    }
}
