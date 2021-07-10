using System;
using System.Windows.Forms;

namespace AccountingExpensesIncome
{
    public partial class UserAuthorization : Form
    {
        // экземпляр авторизируемого пользователя (для передачи на главную форму приложения)
        public Users User;
        public UserAuthorization()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Авторизация пользователя и проверка на null.
            // Если выбрана авторизация по учетной записи Windows, то передаем имя текущего пользователя. В противном случае текст из tbLogin. 
            if ((User = rWindows.Checked ? Authorization.IsAuthorization(Environment.UserName) : Authorization.IsAuthorization(tbLogin.Text)) != null) 
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Данная учетная запись не найдена или не прошла авторизацию. Обратитесь к системному администратору.", "Ошибка авторизации учетной записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
