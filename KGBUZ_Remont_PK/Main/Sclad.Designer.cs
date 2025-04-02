namespace KGBUZ_Remont_PK.Main
{
    partial class Sclad
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
            this.dgvSelectDetali = new System.Windows.Forms.DataGridView();
            this.btSpisatdetal = new System.Windows.Forms.Button();
            this.btInsertDetal = new System.Windows.Forms.Button();
            this.btCreateReport = new System.Windows.Forms.Button();
            this.tbIDDetali = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectDetali)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectDetali
            // 
            this.dgvSelectDetali.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectDetali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectDetali.Location = new System.Drawing.Point(10, 10);
            this.dgvSelectDetali.Name = "dgvSelectDetali";
            this.dgvSelectDetali.ReadOnly = true;
            this.dgvSelectDetali.Size = new System.Drawing.Size(665, 318);
            this.dgvSelectDetali.TabIndex = 0;
            this.dgvSelectDetali.DoubleClick += new System.EventHandler(this.dgvSelectDetali_DoubleClick);
            // 
            // btSpisatdetal
            // 
            this.btSpisatdetal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSpisatdetal.FlatAppearance.BorderSize = 0;
            this.btSpisatdetal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSpisatdetal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSpisatdetal.ForeColor = System.Drawing.Color.White;
            this.btSpisatdetal.Location = new System.Drawing.Point(130, 334);
            this.btSpisatdetal.Name = "btSpisatdetal";
            this.btSpisatdetal.Size = new System.Drawing.Size(172, 26);
            this.btSpisatdetal.TabIndex = 1;
            this.btSpisatdetal.Text = "Списать";
            this.btSpisatdetal.UseVisualStyleBackColor = false;
            this.btSpisatdetal.Click += new System.EventHandler(this.btSpisatdetal_Click);
            // 
            // btInsertDetal
            // 
            this.btInsertDetal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btInsertDetal.FlatAppearance.BorderSize = 0;
            this.btInsertDetal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsertDetal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btInsertDetal.ForeColor = System.Drawing.Color.White;
            this.btInsertDetal.Location = new System.Drawing.Point(308, 334);
            this.btInsertDetal.Name = "btInsertDetal";
            this.btInsertDetal.Size = new System.Drawing.Size(172, 26);
            this.btInsertDetal.TabIndex = 2;
            this.btInsertDetal.Text = "Добавить";
            this.btInsertDetal.UseVisualStyleBackColor = false;
            this.btInsertDetal.Click += new System.EventHandler(this.btInsertDetal_Click);
            // 
            // btCreateReport
            // 
            this.btCreateReport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btCreateReport.FlatAppearance.BorderSize = 0;
            this.btCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreateReport.ForeColor = System.Drawing.Color.White;
            this.btCreateReport.Location = new System.Drawing.Point(486, 334);
            this.btCreateReport.Name = "btCreateReport";
            this.btCreateReport.Size = new System.Drawing.Size(189, 26);
            this.btCreateReport.TabIndex = 3;
            this.btCreateReport.Text = "Отчёт";
            this.btCreateReport.UseVisualStyleBackColor = false;
            this.btCreateReport.Click += new System.EventHandler(this.btCreateReport_Click);
            // 
            // tbIDDetali
            // 
            this.tbIDDetali.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbIDDetali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIDDetali.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbIDDetali.ForeColor = System.Drawing.Color.Black;
            this.tbIDDetali.Location = new System.Drawing.Point(10, 334);
            this.tbIDDetali.Name = "tbIDDetali";
            this.tbIDDetali.ReadOnly = true;
            this.tbIDDetali.Size = new System.Drawing.Size(114, 25);
            this.tbIDDetali.TabIndex = 4;
            this.tbIDDetali.Text = "ID оборудования";
            this.tbIDDetali.Enter += new System.EventHandler(this.tbIDDetali_Enter);
            this.tbIDDetali.Leave += new System.EventHandler(this.tbIDDetali_Leave);
            // 
            // Sclad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 365);
            this.Controls.Add(this.tbIDDetali);
            this.Controls.Add(this.btCreateReport);
            this.Controls.Add(this.btInsertDetal);
            this.Controls.Add(this.btSpisatdetal);
            this.Controls.Add(this.dgvSelectDetali);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sclad";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectDetali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectDetali;
        private System.Windows.Forms.Button btSpisatdetal;
        private System.Windows.Forms.Button btInsertDetal;
        private System.Windows.Forms.Button btCreateReport;
        private System.Windows.Forms.TextBox tbIDDetali;
    }
}
