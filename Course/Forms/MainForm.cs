using Course.Config;
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
        public MainForm()
        {

            authContext = AuthContext.GetInstance();

            InitializeComponent();
        }

        private void WelcomeUser_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeUser.Text += authContext.AuthorizedUser.Login;
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
            newForm.Closed += (s, args) => Show();
            newForm.ShowDialog();
        }
    }
}
