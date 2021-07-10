using System;
using System.Linq;
using System.Windows.Forms;

namespace AccountingExpensesIncome
{
    public partial class AccountingExpensesIncome : Form
    {
        // экземпляр авторизированного пользователя
        private Users User;
        public AccountingExpensesIncome(Users user)
        {
            InitializeComponent();
            User = user;
        }

        private void AccountingExpensesIncome_Load(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                if (User != null)
                {
                    // получаем все категории из таблицы Categories
                    cbCategory.DataSource = context.Categories.ToList();
                    // получаем все операции из таблицы Operations
                    cbOperation.DataSource = context.Operations.ToList();
                    // отображаем все операции авторизированного пользователя из таблицы Data 
                    dgvInformation.DataSource = context.Data.Where(x => x.UserId == User.Id).Select(x => new
                    {
                        Id = x.Id,
                        Категория = x.Category.Category,
                        Операция = x.Operation.Operation,
                        Сумма_операции = x.TransactionAmount,
                        Пользователь = x.User.FullName,
                        Описание = x.Description,
                        Баланс = x.Balance
                    }).ToList();
                    // отображаем роль авторизированного пользователя
                    lWorkMode.Text = User.Administrator == true ? "Администратор" : "Пользователь";
                    // отображаем имя авторизированного пользователя
                    lFullName.Text = User.FullName;
                    // отображаем текущий баланс авторизированного пользователя
                    lBalance.Text = "Текущий баланс:" + User.Balance;
                }
                else
                {
                    MessageBox.Show("Данная учетная запись не прошла авторизацию. Приложение будет закрыто. Обратитесь к системному администратору.", "Ошибка авторизации учетной записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Выход из приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверка роли пользователя в системе на доступ к изменению справочника пользователей.
            if (User != null && User.Administrator)
                (new EditUsers()).ShowDialog();
            else
                MessageBox.Show("Недостаточно прав для редактирования данного раздела.", "Ошибка прав доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверка роли пользователя в системе на доступ к изменению справочника операций.
            if (User != null && User.Administrator)
            {
                (new EditOperations()).ShowDialog();
                using (DataContext context = new DataContext())
                    cbOperation.DataSource = context.Operations.ToList();
            }
            else
                MessageBox.Show("Недостаточно прав для редактирования данного раздела.", "Ошибка прав доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверка роли пользователя в системе на доступ к изменению справочника категорий.
            if (User != null && User.Administrator)
            {
                (new EditCategories()).ShowDialog();
                using (DataContext context = new DataContext())
                    cbCategory.DataSource = context.Categories.ToList();
            }
            else
                MessageBox.Show("Недостаточно прав для редактирования данного раздела.", "Ошибка прав доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // проверка на заполненность обязательных полей "Логин" и "Имя пользователя"
            if (User != null && cbCategory.SelectedItem != null && cbOperation.SelectedItem != null)
            {
                // проверка на ненулевое значение поля "Сумма операции"
                if ((double)nTransactionAmount.Value != 0)
                {
                    using (DataContext context = new DataContext())
                    {
                        // проверка на возможность изменения баланса текущего пользователя (на отрицательное значение баланса после выполнения операции)
                        if (context.Users.SingleOrDefault(u => u.Id == User.Id).UpdateBalance((double)nTransactionAmount.Value))
                        {
                            // обновление данных о текущем пользователе
                            User = context.Users.SingleOrDefault(u => u.Id == User.Id);
                            // обновление информации о текущем балансе после операции
                            lBalance.Text = "Текущий баланс:" + User.Balance;

                            // добавление данных об операции в таблицу Data
                            context.Data.Add(new Data()
                            {
                                Category = context.Categories.Where(x => x.Id == (int)cbCategory.SelectedValue).FirstOrDefault(),
                                Description = tbDescription.Text,
                                Operation = context.Operations.Where(x => x.Id == (int)cbOperation.SelectedValue).FirstOrDefault(),
                                UserId = User.Id,
                                TransactionAmount = Convert.ToDouble(nTransactionAmount.Value),
                                Balance = User.Balance
                            });
                            context.SaveChanges();

                            // обновление списка текущих операций пользователя
                            dgvInformation.DataSource = context.Data.Where(x => x.UserId == User.Id).Select(x => new
                            {
                                Id = x.Id,
                                Категория = x.Category.Category,
                                Операция = x.Operation.Operation,
                                Сумма_операции = x.TransactionAmount,
                                Пользователь = x.User.FullName,
                                Описание = x.Description,
                                Баланс = x.Balance
                            }).ToList();
                        }
                        else
                            MessageBox.Show("Сумма операции выше текущего баланса. Операция не может быть выполнена.", "Ошибка выполнения операции", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Сумма операции не должна быть нулевой. Операция не может быть выполнена.", "Ошибка выполнения операции", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export.ExportData(User);
        }
    }
}
