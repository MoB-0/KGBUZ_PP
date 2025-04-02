namespace KGBUZ_Remont_PK.Main
{
    partial class InfoPK
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
            this.btDobavitDetal = new System.Windows.Forms.Button();
            this.btSpisatDetalID = new System.Windows.Forms.Button();
            this.lbNazvaniedetali = new System.Windows.Forms.Label();
            this.lbOpisaniedetali = new System.Windows.Forms.Label();
            this.lbIDDetali = new System.Windows.Forms.Label();
            this.tbIDDetal = new System.Windows.Forms.TextBox();
            this.lbPK = new System.Windows.Forms.Label();
            this.lbNomerSborki = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectDetali)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectDetali
            // 
            this.dgvSelectDetali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectDetali.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSelectDetali.Location = new System.Drawing.Point(0, 0);
            this.dgvSelectDetali.Name = "dgvSelectDetali";
            this.dgvSelectDetali.ReadOnly = true;
            this.dgvSelectDetali.Size = new System.Drawing.Size(512, 330);
            this.dgvSelectDetali.TabIndex = 1;
            this.dgvSelectDetali.DoubleClick += new System.EventHandler(this.dgvSelectDetali_DoubleClick);
            // 
            // btDobavitDetal
            // 
            this.btDobavitDetal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btDobavitDetal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btDobavitDetal.ForeColor = System.Drawing.Color.White;
            this.btDobavitDetal.Location = new System.Drawing.Point(279, 336);
            this.btDobavitDetal.Name = "btDobavitDetal";
            this.btDobavitDetal.Size = new System.Drawing.Size(221, 33);
            this.btDobavitDetal.TabIndex = 4;
            this.btDobavitDetal.Text = "Добавить";
            this.btDobavitDetal.UseVisualStyleBackColor = false;
            this.btDobavitDetal.Click += new System.EventHandler(this.btDobavitDetal_Click);
            // 
            // btSpisatDetalID
            // 
            this.btSpisatDetalID.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSpisatDetalID.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btSpisatDetalID.ForeColor = System.Drawing.Color.White;
            this.btSpisatDetalID.Location = new System.Drawing.Point(49, 336);
            this.btSpisatDetalID.Name = "btSpisatDetalID";
            this.btSpisatDetalID.Size = new System.Drawing.Size(224, 33);
            this.btSpisatDetalID.TabIndex = 3;
            this.btSpisatDetalID.Text = "Списать";
            this.btSpisatDetalID.UseVisualStyleBackColor = false;
            this.btSpisatDetalID.Click += new System.EventHandler(this.btSpisatDetalID_Click);
            // 
            // lbNazvaniedetali
            // 
            this.lbNazvaniedetali.AutoSize = true;
            this.lbNazvaniedetali.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbNazvaniedetali.Location = new System.Drawing.Point(12, 430);
            this.lbNazvaniedetali.Name = "lbNazvaniedetali";
            this.lbNazvaniedetali.Size = new System.Drawing.Size(0, 19);
            this.lbNazvaniedetali.TabIndex = 5;
            this.lbNazvaniedetali.Visible = false;
            // 
            // lbOpisaniedetali
            // 
            this.lbOpisaniedetali.AutoSize = true;
            this.lbOpisaniedetali.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbOpisaniedetali.Location = new System.Drawing.Point(753, 430);
            this.lbOpisaniedetali.Name = "lbOpisaniedetali";
            this.lbOpisaniedetali.Size = new System.Drawing.Size(0, 19);
            this.lbOpisaniedetali.TabIndex = 6;
            this.lbOpisaniedetali.Visible = false;
            // 
            // lbIDDetali
            // 
            this.lbIDDetali.AutoSize = true;
            this.lbIDDetali.Location = new System.Drawing.Point(788, 9);
            this.lbIDDetali.Name = "lbIDDetali";
            this.lbIDDetali.Size = new System.Drawing.Size(0, 13);
            this.lbIDDetali.TabIndex = 7;
            this.lbIDDetali.Visible = false;
            // 
            // tbIDDetal
            // 
            this.tbIDDetal.Location = new System.Drawing.Point(3, 340);
            this.tbIDDetal.Name = "tbIDDetal";
            this.tbIDDetal.ReadOnly = true;
            this.tbIDDetal.Size = new System.Drawing.Size(40, 20);
            this.tbIDDetal.TabIndex = 8;
            this.tbIDDetal.Text = "ID";
            this.tbIDDetal.Enter += new System.EventHandler(this.tbIDDetal_Enter);
            this.tbIDDetal.Leave += new System.EventHandler(this.tbIDDetal_Leave);
            // 
            // lbPK
            // 
            this.lbPK.AutoSize = true;
            this.lbPK.Location = new System.Drawing.Point(0, 363);
            this.lbPK.Name = "lbPK";
            this.lbPK.Size = new System.Drawing.Size(21, 13);
            this.lbPK.TabIndex = 9;
            this.lbPK.Text = "PK";
            this.lbPK.Visible = false;
            // 
            // lbNomerSborki
            // 
            this.lbNomerSborki.AutoSize = true;
            this.lbNomerSborki.Location = new System.Drawing.Point(13, 372);
            this.lbNomerSborki.Name = "lbNomerSborki";
            this.lbNomerSborki.Size = new System.Drawing.Size(66, 13);
            this.lbNomerSborki.TabIndex = 10;
            this.lbNomerSborki.Text = "nomerSborki";
            this.lbNomerSborki.Visible = false;
            // 
            // InfoPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 372);
            this.Controls.Add(this.lbNomerSborki);
            this.Controls.Add(this.lbPK);
            this.Controls.Add(this.tbIDDetal);
            this.Controls.Add(this.lbIDDetali);
            this.Controls.Add(this.lbOpisaniedetali);
            this.Controls.Add(this.lbNazvaniedetali);
            this.Controls.Add(this.btDobavitDetal);
            this.Controls.Add(this.btSpisatDetalID);
            this.Controls.Add(this.dgvSelectDetali);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InfoPK";
            this.Text = "Информация о ПК врача";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectDetali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectDetali;
        private System.Windows.Forms.Button btDobavitDetal;
        private System.Windows.Forms.Button btSpisatDetalID;
        private System.Windows.Forms.Label lbNazvaniedetali;
        private System.Windows.Forms.Label lbOpisaniedetali;
        private System.Windows.Forms.Label lbIDDetali;
        private System.Windows.Forms.TextBox tbIDDetal;
        public System.Windows.Forms.Label lbPK;
        public System.Windows.Forms.Label lbNomerSborki;
    }
}