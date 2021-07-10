
namespace AccountingExpensesIncome
{
    partial class EditOperations
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
            this.dgvOperations = new System.Windows.Forms.DataGridView();
            this.gOperation = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbOperation = new System.Windows.Forms.TextBox();
            this.lOperation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).BeginInit();
            this.gOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOperations
            // 
            this.dgvOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperations.ColumnHeadersHeight = 41;
            this.dgvOperations.Location = new System.Drawing.Point(12, 12);
            this.dgvOperations.Name = "dgvOperations";
            this.dgvOperations.ReadOnly = true;
            this.dgvOperations.RowHeadersVisible = false;
            this.dgvOperations.Size = new System.Drawing.Size(776, 291);
            this.dgvOperations.TabIndex = 0;
            // 
            // gOperation
            // 
            this.gOperation.Controls.Add(this.tbOperation);
            this.gOperation.Controls.Add(this.lOperation);
            this.gOperation.Controls.Add(this.btnAdd);
            this.gOperation.Location = new System.Drawing.Point(12, 309);
            this.gOperation.Name = "gOperation";
            this.gOperation.Size = new System.Drawing.Size(776, 80);
            this.gOperation.TabIndex = 1;
            this.gOperation.TabStop = false;
            this.gOperation.Text = "Добавление типа операции";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(670, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = " Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbOperation
            // 
            this.tbOperation.Location = new System.Drawing.Point(380, 21);
            this.tbOperation.Name = "tbOperation";
            this.tbOperation.Size = new System.Drawing.Size(164, 20);
            this.tbOperation.TabIndex = 4;
            // 
            // lOperation
            // 
            this.lOperation.AutoSize = true;
            this.lOperation.Location = new System.Drawing.Point(211, 24);
            this.lOperation.Name = "lOperation";
            this.lOperation.Size = new System.Drawing.Size(163, 13);
            this.lOperation.TabIndex = 3;
            this.lOperation.Text = "Наименование типа операции:";
            // 
            // EditOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.gOperation);
            this.Controls.Add(this.dgvOperations);
            this.MaximizeBox = false;
            this.Name = "EditOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление типами операций";
            this.Load += new System.EventHandler(this.EditOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).EndInit();
            this.gOperation.ResumeLayout(false);
            this.gOperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperations;
        private System.Windows.Forms.GroupBox gOperation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbOperation;
        private System.Windows.Forms.Label lOperation;
    }
}