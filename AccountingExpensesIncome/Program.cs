using System;
using System.Linq;
using System.Windows.Forms;

namespace AccountingExpensesIncome
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // создание тестового пользователя "Admin"
            using (DataContext context = new DataContext()) 
            {
                if(!context.Users.Any(x => x.Login.Contains("Admin"))) 
                {
                    context.Users.Add(new Users()
                    {
                        Login = "Admin",
                        FullName = "Администратор системы",
                        Balance = 1000000000,
                        Administrator = true,
                    }) ;
                }
                context.SaveChanges();
            }
            // инициализация формы авторизации и передача авторизированного пользователя в главную форму приложения
            using (UserAuthorization authorization = new UserAuthorization())
            {
                if (authorization.ShowDialog() == DialogResult.OK && authorization.User != null)
                    Application.Run(new AccountingExpensesIncome(authorization.User));
            }
        }
    }
}
