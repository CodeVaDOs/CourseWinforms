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
    public partial class CreateQuestionForm : Form
    {

        public ICollection<Answer> Answers = new List<Answer>();
        DatabaseContext dbContext;
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

        private void CreateTestForm_Load(object sender, EventArgs e)
        {

        }

        private void add_question_Click(object sender, EventArgs e)
        {
            if (question_field.Text.Length > 0)
            {
                Question = question_field.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var newForm = CompositionRoot.Resolve<CreateAnswerForm>();
            newForm.Closed += (s, args) => Show();

            var result = newForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var answer = new Answer();
                answer.Body = newForm.InputText;
                Answers.Add(answer);
            }
        }
    }
}
