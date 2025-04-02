namespace KGBUZ_Remont_PK.Main
{
    partial class InsertDetalPKWrach
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
            this.btInsertDetal = new System.Windows.Forms.Button();
            this.lbDetalRanee = new System.Windows.Forms.Label();
            this.cbInsertDetal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btInsertDetal
            // 
            this.btInsertDetal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btInsertDetal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btInsertDetal.ForeColor = System.Drawing.Color.White;
            this.btInsertDetal.Location = new System.Drawing.Point(88, 111);
            this.btInsertDetal.Name = "btInsertDetal";
            this.btInsertDetal.Size = new System.Drawing.Size(232, 39);
            this.btInsertDetal.TabIndex = 6;
            this.btInsertDetal.Text = "Добавить";
            this.btInsertDetal.UseVisualStyleBackColor = false;
            this.btInsertDetal.Click += new System.EventHandler(this.btInsertDetal_Click);
            // 
            // lbDetalRanee
            // 
            this.lbDetalRanee.AutoSize = true;
            this.lbDetalRanee.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbDetalRanee.Location = new System.Drawing.Point(124, 31);
            this.lbDetalRanee.Name = "lbDetalRanee";
            this.lbDetalRanee.Size = new System.Drawing.Size(166, 28);
            this.lbDetalRanee.TabIndex = 5;
            this.lbDetalRanee.Text = "Добавить деталь";
            // 
            // cbInsertDetal
            // 
            this.cbInsertDetal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbInsertDetal.FormattingEnabled = true;
            this.cbInsertDetal.Location = new System.Drawing.Point(73, 70);
            this.cbInsertDetal.Name = "cbInsertDetal";
            this.cbInsertDetal.Size = new System.Drawing.Size(256, 25);
            this.cbInsertDetal.TabIndex = 4;
            // 
            // InsertDetalPKWrach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 187);
            this.Controls.Add(this.btInsertDetal);
            this.Controls.Add(this.lbDetalRanee);
            this.Controls.Add(this.cbInsertDetal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InsertDetalPKWrach";
            this.Text = "Добавить деталь в ПК";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInsertDetal;
        private System.Windows.Forms.Label lbDetalRanee;
        private System.Windows.Forms.ComboBox cbInsertDetal;
    }
}