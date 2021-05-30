using Course.Forms;
using Course.Util;
using System;
using System.Windows.Forms;

namespace Course
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new NinjectRegistrations());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(CompositionRoot.Resolve<AuthForm>());
        }

    }
}
