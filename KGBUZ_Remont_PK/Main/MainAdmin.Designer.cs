namespace KGBUZ_Remont_PK.Main
{
    partial class MainAdmin
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
            this.lbIDAdmin = new System.Windows.Forms.Label();
            this.btCreateReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvSelectError = new System.Windows.Forms.DataGridView();
            this.tbPoisk = new System.Windows.Forms.TextBox();
            this.btSearc = new System.Windows.Forms.Button();
            this.lbIDWrach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIDAdmin
            // 
            this.lbIDAdmin.AutoSize = true;
            this.lbIDAdmin.Location = new System.Drawing.Point(947, 14);
            this.lbIDAdmin.Name = "lbIDAdmin";
            this.lbIDAdmin.Size = new System.Drawing.Size(0, 13);
            this.lbIDAdmin.TabIndex = 0;
            this.lbIDAdmin.Visible = false;
            // 
            // btCreateReport
            // 
            this.btCreateReport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btCreateReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreateReport.ForeColor = System.Drawing.Color.White;
            this.btCreateReport.Location = new System.Drawing.Point(12, 324);
            this.btCreateReport.Name = "btCreateReport";
            this.btCreateReport.Size = new System.Drawing.Size(189, 32);
            this.btCreateReport.TabIndex = 1;
            this.btCreateReport.Text = "Сформировать отчёт";
            this.btCreateReport.UseVisualStyleBackColor = false;
            this.btCreateReport.Click += new System.EventHandler(this.btCreateReport_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(217, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Склад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(420, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Реестр";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvSelectError
            // 
            this.dgvSelectError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectError.Location = new System.Drawing.Point(12, 40);
            this.dgvSelectError.Name = "dgvSelectError";
            this.dgvSelectError.ReadOnly = true;
            this.dgvSelectError.Size = new System.Drawing.Size(589, 278);
            this.dgvSelectError.TabIndex = 4;
            this.dgvSelectError.DoubleClick += new System.EventHandler(this.dgvSelectError_DoubleClick);
            // 
            // tbPoisk
            // 
            this.tbPoisk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbPoisk.Location = new System.Drawing.Point(12, 9);
            this.tbPoisk.Name = "tbPoisk";
            this.tbPoisk.Size = new System.Drawing.Size(475, 25);
            this.tbPoisk.TabIndex = 5;
            this.tbPoisk.Text = "Поиск";
            this.tbPoisk.Enter += new System.EventHandler(this.tbPoisk_Enter);
            this.tbPoisk.Leave += new System.EventHandler(this.tbPoisk_Leave);
            // 
            // btSearc
            // 
            this.btSearc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSearc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSearc.ForeColor = System.Drawing.Color.White;
            this.btSearc.Location = new System.Drawing.Point(493, 9);
            this.btSearc.Name = "btSearc";
            this.btSearc.Size = new System.Drawing.Size(108, 28);
            this.btSearc.TabIndex = 6;
            this.btSearc.Text = "Найти";
            this.btSearc.UseVisualStyleBackColor = false;
            this.btSearc.Click += new System.EventHandler(this.btSearc_Click);
            // 
            // lbIDWrach
            // 
            this.lbIDWrach.AutoSize = true;
            this.lbIDWrach.Location = new System.Drawing.Point(607, 20);
            this.lbIDWrach.Name = "lbIDWrach";
            this.lbIDWrach.Size = new System.Drawing.Size(13, 13);
            this.lbIDWrach.TabIndex = 7;
            this.lbIDWrach.Text = "0";
            this.lbIDWrach.Visible = false;
            // 
            // MainAdmin
            // 
            this.ClientSize = new System.Drawing.Size(608, 364);
            this.Controls.Add(this.lbIDWrach);
            this.Controls.Add(this.btSearc);
            this.Controls.Add(this.tbPoisk);
            this.Controls.Add(this.dgvSelectError);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCreateReport);
            this.Controls.Add(this.lbIDAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainAdmin";
            this.Text = "Журнал обнаруженных ошибок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAdmin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbIDAdmin;
        private System.Windows.Forms.Button btCreateReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbPoisk;
        private System.Windows.Forms.Button btSearc;
        public System.Windows.Forms.Label lbIDWrach;
        public System.Windows.Forms.DataGridView dgvSelectError;
    }
}