namespace KGBUZ_Remont_PK.Main
{
    partial class DobavlenieDetaliPK
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
            this.tbNazvan = new System.Windows.Forms.TextBox();
            this.tbOpisan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategoria = new System.Windows.Forms.ComboBox();
            this.btNewDetalInsert = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.btDobavlenieKategorii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNazvan
            // 
            this.tbNazvan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNazvan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNazvan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbNazvan.Location = new System.Drawing.Point(50, 50);
            this.tbNazvan.Name = "tbNazvan";
            this.tbNazvan.Size = new System.Drawing.Size(400, 25);
            this.tbNazvan.TabIndex = 1;
            // 
            // tbOpisan
            // 
            this.tbOpisan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbOpisan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOpisan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbOpisan.Location = new System.Drawing.Point(50, 170);
            this.tbOpisan.Multiline = true;
            this.tbOpisan.Name = "tbOpisan";
            this.tbOpisan.Size = new System.Drawing.Size(400, 60);
            this.tbOpisan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Характеристики";
            // 
            // cbKategoria
            // 
            this.cbKategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKategoria.Location = new System.Drawing.Point(50, 110);
            this.cbKategoria.Name = "cbKategoria";
            this.cbKategoria.Size = new System.Drawing.Size(362, 25);
            this.cbKategoria.TabIndex = 3;
            // 
            // btNewDetalInsert
            // 
            this.btNewDetalInsert.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btNewDetalInsert.FlatAppearance.BorderSize = 0;
            this.btNewDetalInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewDetalInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNewDetalInsert.ForeColor = System.Drawing.Color.White;
            this.btNewDetalInsert.Location = new System.Drawing.Point(150, 240);
            this.btNewDetalInsert.Name = "btNewDetalInsert";
            this.btNewDetalInsert.Size = new System.Drawing.Size(200, 40);
            this.btNewDetalInsert.TabIndex = 6;
            this.btNewDetalInsert.Text = "Добавить";
            this.btNewDetalInsert.UseVisualStyleBackColor = false;
            this.btNewDetalInsert.Click += new System.EventHandler(this.btNewDetalInsert_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(450, 10);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 8;
            // 
            // btDobavlenieKategorii
            // 
            this.btDobavlenieKategorii.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btDobavlenieKategorii.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDobavlenieKategorii.ForeColor = System.Drawing.Color.White;
            this.btDobavlenieKategorii.Location = new System.Drawing.Point(418, 107);
            this.btDobavlenieKategorii.Name = "btDobavlenieKategorii";
            this.btDobavlenieKategorii.Size = new System.Drawing.Size(32, 29);
            this.btDobavlenieKategorii.TabIndex = 9;
            this.btDobavlenieKategorii.Text = "+";
            this.btDobavlenieKategorii.UseVisualStyleBackColor = false;
            this.btDobavlenieKategorii.Click += new System.EventHandler(this.btDobavlenieKategorii_Click);
            // 
            // DobavlenieDetaliPK
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btDobavlenieKategorii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNazvan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOpisan);
            this.Controls.Add(this.btNewDetalInsert);
            this.Controls.Add(this.lbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DobavlenieDetaliPK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление детали";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazvan;
        private System.Windows.Forms.TextBox tbOpisan;
        private System.Windows.Forms.ComboBox cbKategoria;
        private System.Windows.Forms.Button btNewDetalInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbID; // ID Label
        private System.Windows.Forms.Button btDobavlenieKategorii;
    }
}