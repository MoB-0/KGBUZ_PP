namespace KGBUZ_Remont_PK.Main
{
    partial class Reestr
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvSelectMethodRechenia = new System.Windows.Forms.DataGridView();
            this.btSearc = new System.Windows.Forms.Button();
            this.tbPoisk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectMethodRechenia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectMethodRechenia
            // 
            this.dgvSelectMethodRechenia.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectMethodRechenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectMethodRechenia.Location = new System.Drawing.Point(10, 49);
            this.dgvSelectMethodRechenia.Name = "dgvSelectMethodRechenia";
            this.dgvSelectMethodRechenia.Size = new System.Drawing.Size(665, 330);
            this.dgvSelectMethodRechenia.TabIndex = 0;
            // 
            // btSearc
            // 
            this.btSearc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSearc.FlatAppearance.BorderSize = 0;
            this.btSearc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btSearc.ForeColor = System.Drawing.Color.White;
            this.btSearc.Location = new System.Drawing.Point(423, 10);
            this.btSearc.Name = "btSearc";
            this.btSearc.Size = new System.Drawing.Size(81, 26);
            this.btSearc.TabIndex = 8;
            this.btSearc.Text = "Найти";
            this.btSearc.UseVisualStyleBackColor = false;
            this.btSearc.Click += new System.EventHandler(this.btSearc_Click);
            // 
            // tbPoisk
            // 
            this.tbPoisk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPoisk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPoisk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbPoisk.ForeColor = System.Drawing.Color.Black;
            this.tbPoisk.Location = new System.Drawing.Point(10, 10);
            this.tbPoisk.Name = "tbPoisk";
            this.tbPoisk.Size = new System.Drawing.Size(407, 25);
            this.tbPoisk.TabIndex = 7;
            this.tbPoisk.Text = "Поиск";
            this.tbPoisk.Enter += new System.EventHandler(this.tbPoisk_Enter);
            this.tbPoisk.Leave += new System.EventHandler(this.tbPoisk_Leave);
            // 
            // Reestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btSearc);
            this.Controls.Add(this.tbPoisk);
            this.Controls.Add(this.dgvSelectMethodRechenia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reestr";
            this.Text = "Реестр методик решения ошибок";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectMethodRechenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectMethodRechenia;
        private System.Windows.Forms.Button btSearc;
        private System.Windows.Forms.TextBox tbPoisk;
    }
}
