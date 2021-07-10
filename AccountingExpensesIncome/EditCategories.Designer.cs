
namespace AccountingExpensesIncome
{
    partial class EditCategories
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
            this.gCategory = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lCategory = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.gCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // gCategory
            // 
            this.gCategory.Controls.Add(this.tbCategory);
            this.gCategory.Controls.Add(this.lCategory);
            this.gCategory.Controls.Add(this.btnAdd);
            this.gCategory.Location = new System.Drawing.Point(12, 308);
            this.gCategory.Name = "gCategory";
            this.gCategory.Size = new System.Drawing.Size(776, 80);
            this.gCategory.TabIndex = 0;
            this.gCategory.TabStop = false;
            this.gCategory.Text = "Добавление категории";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.ColumnHeadersHeight = 41;
            this.dgvCategories.Location = new System.Drawing.Point(12, 12);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.Size = new System.Drawing.Size(776, 290);
            this.dgvCategories.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(670, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Location = new System.Drawing.Point(248, 24);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(141, 13);
            this.lCategory.TabIndex = 1;
            this.lCategory.Text = "Наименование категории:";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(395, 21);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(164, 20);
            this.tbCategory.TabIndex = 2;
            // 
            // EditCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.gCategory);
            this.MaximizeBox = false;
            this.Name = "EditCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление категориями";
            this.Load += new System.EventHandler(this.EditCategories_Load);
            this.gCategory.ResumeLayout(false);
            this.gCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gCategory;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.Button btnAdd;
    }
}