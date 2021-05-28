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
    public partial class CreateAnswerForm : Form
    {
        public string InputText { get; set; }
        public CreateAnswerForm()
        {
            InitializeComponent();
            
        }

        private void add_answer_Click(object sender, EventArgs e)
        {
            if (answer_field.Text.Length > 0)
            {
                DialogResult = DialogResult.OK;
                InputText = answer_field.Text;
                Close();
            }
        }
    }
}
