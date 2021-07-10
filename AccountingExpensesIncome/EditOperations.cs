using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AccountingExpensesIncome
{
    public partial class EditOperations : Form
    {
        public EditOperations()
        {
            InitializeComponent();
        }

        private void EditOperations_Load(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext()) 
            {
                dgvOperations.DataSource = context.Operations.Select(x => new {x.Id, Тип_операции = x.Operation }).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbOperation.Text != string.Empty)
            {
                using (DataContext context = new DataContext())
                {
                    if (context.Operations.Where(x => x.Operation.Trim().ToLower().Contains(tbOperation.Text.Trim().ToLower())).Count() == 0)
                    {
                        context.Operations.Add(new Operations { Operation = tbOperation.Text });
                        context.SaveChanges();
                        dgvOperations.DataSource = context.Operations.ToList();
                    }
                    else
                        MessageBox.Show("Данный тип операции уже содержится в базе данных", "Ошибка добавления типа операции", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
