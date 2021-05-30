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
    public partial class EditUserForm : Form
    {
        public User user { get; set; }
        public User newUser { get; set; }
        public EditUserForm(User _user)
        {
            user = _user;
            InitializeComponent();
        }

        private void Init()
        {
            loginField.Text = user.Login;
            passwordField.Text = "";

            roleField.Items.Add(new ComboboxItem(Enum.GetName(typeof(ERole), ERole.Admin), ERole.Admin));
            roleField.Items.Add(new ComboboxItem(Enum.GetName(typeof(ERole), ERole.User), ERole.User));
            roleField.SelectedIndex = user.UserRole == ERole.Admin ? 0 : 1;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (loginField.Text.Length == 0) return;

            var editedUser = new User();

            if (passwordField.Text.Length > 0)
            {
                editedUser.Password = HashPassword.Hash(passwordField.Text);
            } else
            {
                editedUser.Password = user.Password;
            }

            editedUser.Login = loginField.Text;
            editedUser.UserRole = (ERole) ((ComboboxItem)roleField.SelectedItem).Value;
            editedUser.ID = user.ID;
            newUser = editedUser;

            DialogResult = DialogResult.OK;
            Close();
            
        }
    }
}
