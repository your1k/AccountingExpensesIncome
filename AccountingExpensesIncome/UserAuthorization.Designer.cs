
namespace AccountingExpensesIncome
{
    partial class UserAuthorization
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rWindows = new System.Windows.Forms.RadioButton();
            this.rSql = new System.Windows.Forms.RadioButton();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.gAuthorization = new System.Windows.Forms.GroupBox();
            this.gAuthorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(109, 91);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(65, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(180, 91);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rWindows
            // 
            this.rWindows.AutoSize = true;
            this.rWindows.Checked = true;
            this.rWindows.Location = new System.Drawing.Point(32, 19);
            this.rWindows.Name = "rWindows";
            this.rWindows.Size = new System.Drawing.Size(213, 17);
            this.rWindows.TabIndex = 2;
            this.rWindows.TabStop = true;
            this.rWindows.Text = "По текущей учетной записи Windows";
            this.rWindows.UseVisualStyleBackColor = true;
            // 
            // rSql
            // 
            this.rSql.AutoSize = true;
            this.rSql.Location = new System.Drawing.Point(32, 42);
            this.rSql.Name = "rSql";
            this.rSql.Size = new System.Drawing.Size(161, 17);
            this.rSql.TabIndex = 3;
            this.rSql.TabStop = true;
            this.rSql.Text = "По учетным данным в SQL";
            this.rSql.UseVisualStyleBackColor = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(79, 65);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(166, 20);
            this.tbLogin.TabIndex = 4;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(32, 68);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(41, 13);
            this.lLogin.TabIndex = 6;
            this.lLogin.Text = "Логин:";
            // 
            // gAuthorization
            // 
            this.gAuthorization.Controls.Add(this.rWindows);
            this.gAuthorization.Controls.Add(this.lLogin);
            this.gAuthorization.Controls.Add(this.btnOk);
            this.gAuthorization.Controls.Add(this.tbLogin);
            this.gAuthorization.Controls.Add(this.btnExit);
            this.gAuthorization.Controls.Add(this.rSql);
            this.gAuthorization.Location = new System.Drawing.Point(12, 11);
            this.gAuthorization.Name = "gAuthorization";
            this.gAuthorization.Size = new System.Drawing.Size(271, 120);
            this.gAuthorization.TabIndex = 7;
            this.gAuthorization.TabStop = false;
            this.gAuthorization.Text = "Авторизация";
            // 
            // UserAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 143);
            this.Controls.Add(this.gAuthorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAuthorization";
            this.gAuthorization.ResumeLayout(false);
            this.gAuthorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rWindows;
        private System.Windows.Forms.RadioButton rSql;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.GroupBox gAuthorization;
    }
}