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
    public partial class AuthForm : Form
    {
        AuthContext authContext;
        DatabaseContext dbContext;
        LoggerContext loggerContext;

        public AuthForm(DatabaseContext _dbContext)
        {
            dbContext = _dbContext;
            authContext = AuthContext.GetInstance();
            loggerContext = LoggerContext.GetInstance();
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {

            login_button.Enabled = false;


            var user = from u in dbContext.Users where u.Login == login_field.Text select u;


            if (!user.Any())
            {
                MessageBox.Show("Логін або пароль не вірний.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login_button.Enabled = true;
                return;
            };
            if (!HashPassword.Verify(user.First().Password, password_field.Text))
            {
                MessageBox.Show("Логін або пароль не вірний.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login_button.Enabled = true;
                return;
            };

            authContext.Authorize(user.First());
            loggerContext.Info($"Успішна авторизація користувача: {authContext.AuthorizedUser.Login}.");

            Hide();
            login_button.Enabled = true;
            MainForm newForm = CompositionRoot.Resolve<MainForm>();
            newForm.Closed += (s, args) => Close();
            newForm.ShowDialog();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            register_button.Enabled = false;
            if (login_field.Text.Count() < 4)
            {
                MessageBox.Show("Логін повинен містити 4 або більше символів.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_button.Enabled = true;
                return;
            };

            if (password_field.Text.Count() < 4)
            {
                MessageBox.Show("Пароль повинен містити 4 або більше символів.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_button.Enabled = true;
                return;
            };


            var user = from u in dbContext.Users where u.Login == login_field.Text select u;


            if (user.Any())
            {
                MessageBox.Show("Користувач з таким логіном вже існує.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_button.Enabled = true;
                return;
            };

            var newUser = new User();
            newUser.Login = login_field.Text;
            newUser.Password = HashPassword.Hash(password_field.Text);
            newUser.UserRole = ERole.User;

            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();

            var createdUser = dbContext.Users.SingleOrDefault(u => u.Login == newUser.Login);

            if (createdUser.ID == 1)
            {
                createdUser.UserRole = ERole.Admin;
                dbContext.SaveChanges();
            }

            authContext.AuthorizedUser = createdUser;

            loggerContext.Info($"Успішна реєстрація користувача: {newUser.Login}", createdUser);
            MessageBox.Show("Ви успішно зареєструвалися.", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            register_button.Enabled = true;

            login_button_Click(sender, e);
        }

    }
}
