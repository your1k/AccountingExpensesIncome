
namespace AccountingExpensesIncome
{
    partial class EditUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.lBalance = new System.Windows.Forms.Label();
            this.nBalance = new System.Windows.Forms.NumericUpDown();
            this.cbAdministrator = new System.Windows.Forms.CheckBox();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnActiveDirectory = new System.Windows.Forms.Button();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lFullName = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrator = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.lBalance);
            this.gbUsers.Controls.Add(this.nBalance);
            this.gbUsers.Controls.Add(this.cbAdministrator);
            this.gbUsers.Controls.Add(this.btnUserAdd);
            this.gbUsers.Controls.Add(this.btnActiveDirectory);
            this.gbUsers.Controls.Add(this.tbFullName);
            this.gbUsers.Controls.Add(this.lFullName);
            this.gbUsers.Controls.Add(this.tbLogin);
            this.gbUsers.Controls.Add(this.lLogin);
            this.gbUsers.Location = new System.Drawing.Point(12, 331);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(776, 85);
            this.gbUsers.TabIndex = 0;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Данные о пользователе";
            // 
            // lBalance
            // 
            this.lBalance.AutoSize = true;
            this.lBalance.Location = new System.Drawing.Point(395, 51);
            this.lBalance.Name = "lBalance";
            this.lBalance.Size = new System.Drawing.Size(47, 13);
            this.lBalance.TabIndex = 8;
            this.lBalance.Text = "Баланс:";
            // 
            // nBalance
            // 
            this.nBalance.Location = new System.Drawing.Point(448, 49);
            this.nBalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nBalance.Name = "nBalance";
            this.nBalance.Size = new System.Drawing.Size(106, 20);
            this.nBalance.TabIndex = 7;
            // 
            // cbAdministrator
            // 
            this.cbAdministrator.AutoSize = true;
            this.cbAdministrator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAdministrator.Location = new System.Drawing.Point(398, 19);
            this.cbAdministrator.Name = "cbAdministrator";
            this.cbAdministrator.Size = new System.Drawing.Size(156, 17);
            this.cbAdministrator.TabIndex = 6;
            this.cbAdministrator.Text = "Администратор системы:";
            this.cbAdministrator.UseVisualStyleBackColor = true;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(597, 15);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(173, 23);
            this.btnUserAdd.TabIndex = 5;
            this.btnUserAdd.Text = "Добавить пользователя";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnActiveDirectory
            // 
            this.btnActiveDirectory.Location = new System.Drawing.Point(597, 48);
            this.btnActiveDirectory.Name = "btnActiveDirectory";
            this.btnActiveDirectory.Size = new System.Drawing.Size(173, 23);
            this.btnActiveDirectory.TabIndex = 4;
            this.btnActiveDirectory.Text = "Выбрать пользователя из AD";
            this.btnActiveDirectory.UseVisualStyleBackColor = true;
            this.btnActiveDirectory.Click += new System.EventHandler(this.btnActiveDirectory_Click);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(118, 48);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(258, 20);
            this.tbFullName.TabIndex = 3;
            // 
            // lFullName
            // 
            this.lFullName.AutoSize = true;
            this.lFullName.Location = new System.Drawing.Point(6, 51);
            this.lFullName.Name = "lFullName";
            this.lFullName.Size = new System.Drawing.Size(106, 13);
            this.lFullName.TabIndex = 2;
            this.lFullName.Text = "Имя пользователя:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(118, 19);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(258, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(71, 22);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(41, 13);
            this.lLogin.TabIndex = 0;
            this.lLogin.Text = "Логин:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeight = 41;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Login,
            this.FullName,
            this.Administrator,
            this.Balance});
            this.dgvUsers.Location = new System.Drawing.Point(12, 12);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.Size = new System.Drawing.Size(776, 298);
            this.dgvUsers.TabIndex = 1;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "Id";
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = " Ф.И.О. пользователя";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Administrator
            // 
            this.Administrator.DataPropertyName = "Administrator";
            this.Administrator.HeaderText = "Администратор";
            this.Administrator.Name = "Administrator";
            this.Administrator.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Баланс";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.gbUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление пользователями";
            this.Load += new System.EventHandler(this.EditUsers_Load);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.CheckBox cbAdministrator;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnActiveDirectory;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lFullName;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lBalance;
        private System.Windows.Forms.NumericUpDown nBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Administrator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}