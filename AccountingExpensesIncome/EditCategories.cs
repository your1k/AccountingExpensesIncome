using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingExpensesIncome
{
    public partial class EditCategories : Form
    {
        public EditCategories()
        {
            InitializeComponent();
        }

        private void EditCategories_Load(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                dgvCategories.DataSource = context.Categories.Select(x => new { x.Id, Категория = x.Category }).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbCategory.Text != string.Empty)
            {
                using (DataContext context = new DataContext())
                {
                    if (context.Categories.Where(x => x.Category.Trim().ToLower().Contains(tbCategory.Text.Trim().ToLower())).Count() == 0)
                    {
                        context.Categories.Add(new Categories { Category = tbCategory.Text });
                        context.SaveChanges();
                        dgvCategories.DataSource = context.Categories.ToList();
                    }
                    else
                        MessageBox.Show("Данная категория уже содержится в базе данных", "Ошибка добавления категории", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
