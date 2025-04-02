namespace KGBUZ_Remont_PK.Main
{
    partial class InsertDetalVSclad
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
            this.cbInsertDetal = new System.Windows.Forms.ComboBox();
            this.lbDetalRanee = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btInsertDetalNaSclad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbInsertDetal
            // 
            this.cbInsertDetal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbInsertDetal.FormattingEnabled = true;
            this.cbInsertDetal.Location = new System.Drawing.Point(24, 62);
            this.cbInsertDetal.Name = "cbInsertDetal";
            this.cbInsertDetal.Size = new System.Drawing.Size(328, 25);
            this.cbInsertDetal.TabIndex = 0;
            // 
            // lbDetalRanee
            // 
            this.lbDetalRanee.AutoSize = true;
            this.lbDetalRanee.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbDetalRanee.Location = new System.Drawing.Point(3, 31);
            this.lbDetalRanee.Name = "lbDetalRanee";
            this.lbDetalRanee.Size = new System.Drawing.Size(370, 28);
            this.lbDetalRanee.TabIndex = 1;
            this.lbDetalRanee.Text = "Добавить уже существовавшую деталь";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btInsertDetalNaSclad
            // 
            this.btInsertDetalNaSclad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btInsertDetalNaSclad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btInsertDetalNaSclad.ForeColor = System.Drawing.Color.White;
            this.btInsertDetalNaSclad.Location = new System.Drawing.Point(72, 93);
            this.btInsertDetalNaSclad.Name = "btInsertDetalNaSclad";
            this.btInsertDetalNaSclad.Size = new System.Drawing.Size(232, 39);
            this.btInsertDetalNaSclad.TabIndex = 3;
            this.btInsertDetalNaSclad.Text = "Добавить";
            this.btInsertDetalNaSclad.UseVisualStyleBackColor = false;
            this.btInsertDetalNaSclad.Click += new System.EventHandler(this.btInsertDetalNaSclad_Click);
            // 
            // InsertDetalVSclad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 135);
            this.Controls.Add(this.btInsertDetalNaSclad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDetalRanee);
            this.Controls.Add(this.cbInsertDetal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InsertDetalVSclad";
            this.Text = "Добавление детали в базу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInsertDetal;
        private System.Windows.Forms.Label lbDetalRanee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btInsertDetalNaSclad;
    }
}