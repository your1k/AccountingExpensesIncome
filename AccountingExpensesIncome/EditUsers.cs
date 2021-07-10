using System;
using System.Linq;
using System.Windows.Forms;

namespace AccountingExpensesIncome
{
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
        }

        private void EditUsers_Load(object sender, EventArgs e) { using (DataContext context = new DataContext()) { dgvUsers.DataSource = context.Users.ToList(); } }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbLogin.Text) && !string.IsNullOrEmpty(tbFullName.Text))
            {
                using (DataContext context = new DataContext())
                {
                    if(context.Users.Where(x => x.Login.Trim().ToLower().Contains(tbLogin.Text.Trim().ToLower())).Count() <= 0) 
                    {
                        context.Users.Add(new Users()
                        {
                            Login = tbLogin.Text,
                            FullName = tbFullName.Text,
                            Administrator = cbAdministrator.Checked,
                            Balance = (double)nBalance.Value
                        });
                        context.SaveChanges();
                        dgvUsers.DataSource = context.Users.ToList();
                    }
                    MessageBox.Show($"Пользователь {tbLogin.Text} уже существует.", "Ошибка добавления нового пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Поле \"Логин\" и \"Имя пользователя\" не должны быть пустыми.", "Ошибка добавления нового пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActiveDirectory_Click(object sender, EventArgs e)
        {
            var users = ActiveDirectory.GetUsersActiveDirectory();
        }
    }
}
