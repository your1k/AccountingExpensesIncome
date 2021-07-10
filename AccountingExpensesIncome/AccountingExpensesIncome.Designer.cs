
namespace AccountingExpensesIncome
{
    partial class AccountingExpensesIncome
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.status = new System.Windows.Forms.StatusStrip();
            this.lWorkMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.lFullName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lBalance = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nTransactionAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lTransactionAmount = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTransactionAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lWorkMode,
            this.lFullName,
            this.lBalance});
            this.status.Location = new System.Drawing.Point(0, 428);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(800, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // lWorkMode
            // 
            this.lWorkMode.Name = "lWorkMode";
            this.lWorkMode.Size = new System.Drawing.Size(89, 17);
            this.lWorkMode.Text = "Режим работы";
            // 
            // lFullName
            // 
            this.lFullName.Name = "lFullName";
            this.lFullName.Size = new System.Drawing.Size(121, 17);
            this.lFullName.Text = "Ф.И.О. пользователя";
            // 
            // lBalance
            // 
            this.lBalance.Name = "lBalance";
            this.lBalance.Size = new System.Drawing.Size(101, 17);
            this.lBalance.Text = "Текущий баланс:";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersToolStripMenuItem,
            this.OperationToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.ExportToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.UsersToolStripMenuItem.Text = "Управление пользователями";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // OperationToolStripMenuItem
            // 
            this.OperationToolStripMenuItem.Name = "OperationToolStripMenuItem";
            this.OperationToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.OperationToolStripMenuItem.Text = "Управление типами операций";
            this.OperationToolStripMenuItem.Click += new System.EventHandler(this.OperationToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.CategoryToolStripMenuItem.Text = "Управление категориями";
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.ExportToolStripMenuItem.Text = "Выгрузить данные в отчет";
            this.ExportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nTransactionAmount);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lTransactionAmount);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.lDescription);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.cbOperation);
            this.groupBox1.Location = new System.Drawing.Point(12, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // nTransactionAmount
            // 
            this.nTransactionAmount.DecimalPlaces = 1;
            this.nTransactionAmount.Location = new System.Drawing.Point(403, 52);
            this.nTransactionAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nTransactionAmount.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nTransactionAmount.Name = "nTransactionAmount";
            this.nTransactionAmount.Size = new System.Drawing.Size(228, 20);
            this.nTransactionAmount.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(669, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавление";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lTransactionAmount
            // 
            this.lTransactionAmount.AutoSize = true;
            this.lTransactionAmount.Location = new System.Drawing.Point(302, 54);
            this.lTransactionAmount.Name = "lTransactionAmount";
            this.lTransactionAmount.Size = new System.Drawing.Size(95, 13);
            this.lTransactionAmount.TabIndex = 4;
            this.lTransactionAmount.Text = "Сумма операции:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(403, 20);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(228, 20);
            this.tbDescription.TabIndex = 3;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(337, 22);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(60, 13);
            this.lDescription.TabIndex = 2;
            this.lDescription.Text = "Описание:";
            // 
            // cbCategory
            // 
            this.cbCategory.DisplayMember = "Category";
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(133, 19);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.Text = "Категория";
            this.cbCategory.ValueMember = "Id";
            // 
            // cbOperation
            // 
            this.cbOperation.DisplayMember = "Operation";
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(6, 19);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(121, 21);
            this.cbOperation.TabIndex = 0;
            this.cbOperation.Text = "Тип операции";
            this.cbOperation.ValueMember = "Id";
            // 
            // dgvInformation
            // 
            this.dgvInformation.AllowUserToAddRows = false;
            this.dgvInformation.AllowUserToDeleteRows = false;
            this.dgvInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInformation.ColumnHeadersHeight = 41;
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInformation.Location = new System.Drawing.Point(12, 27);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.RowHeadersVisible = false;
            this.dgvInformation.Size = new System.Drawing.Size(776, 305);
            this.dgvInformation.TabIndex = 3;
            // 
            // AccountingExpensesIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInformation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "AccountingExpensesIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт расходов и доходов";
            this.Load += new System.EventHandler(this.AccountingExpensesIncome_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTransactionAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lWorkMode;
        private System.Windows.Forms.ToolStripStatusLabel lFullName;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lTransactionAmount;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.NumericUpDown nTransactionAmount;
        private System.Windows.Forms.ToolStripMenuItem OperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lBalance;
    }
}

