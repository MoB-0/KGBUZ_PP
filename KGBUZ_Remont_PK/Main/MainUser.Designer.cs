namespace KGBUZ_Remont_PK.Main
{
    partial class MainUser
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNazvanieError = new System.Windows.Forms.TextBox();
            this.tbopisanieError = new System.Windows.Forms.TextBox();
            this.btMessageError = new System.Windows.Forms.Button();
            this.lbKab = new System.Windows.Forms.Label();
            this.lbDolz = new System.Windows.Forms.Label();
            this.lbOtch = new System.Windows.Forms.Label();
            this.lbFam = new System.Windows.Forms.Label();
            this.lbIma = new System.Windows.Forms.Label();
            this.tbKab = new System.Windows.Forms.TextBox();
            this.tbDolz = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbIma = new System.Windows.Forms.TextBox();
            this.lbIDUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbNazvanieError);
            this.splitContainer1.Panel1.Controls.Add(this.tbopisanieError);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btMessageError);
            this.splitContainer1.Panel2.Controls.Add(this.lbKab);
            this.splitContainer1.Panel2.Controls.Add(this.lbDolz);
            this.splitContainer1.Panel2.Controls.Add(this.lbOtch);
            this.splitContainer1.Panel2.Controls.Add(this.lbFam);
            this.splitContainer1.Panel2.Controls.Add(this.lbIma);
            this.splitContainer1.Panel2.Controls.Add(this.tbKab);
            this.splitContainer1.Panel2.Controls.Add(this.tbDolz);
            this.splitContainer1.Panel2.Controls.Add(this.tbOtch);
            this.splitContainer1.Panel2.Controls.Add(this.tbFam);
            this.splitContainer1.Panel2.Controls.Add(this.tbIma);
            this.splitContainer1.Panel2.Controls.Add(this.lbIDUser);
            this.splitContainer1.Size = new System.Drawing.Size(534, 285);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Заголовок";
            // 
            // tbNazvanieError
            // 
            this.tbNazvanieError.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNazvanieError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNazvanieError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbNazvanieError.ForeColor = System.Drawing.Color.Black;
            this.tbNazvanieError.Location = new System.Drawing.Point(7, 30);
            this.tbNazvanieError.Name = "tbNazvanieError";
            this.tbNazvanieError.Size = new System.Drawing.Size(265, 25);
            this.tbNazvanieError.TabIndex = 14;
            this.tbNazvanieError.Text = "Название ошибки";
            this.tbNazvanieError.Enter += new System.EventHandler(this.tbNazvanieError_Enter);
            this.tbNazvanieError.Leave += new System.EventHandler(this.tbNazvanieError_Leave);
            // 
            // tbopisanieError
            // 
            this.tbopisanieError.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbopisanieError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbopisanieError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbopisanieError.ForeColor = System.Drawing.Color.Black;
            this.tbopisanieError.Location = new System.Drawing.Point(10, 77);
            this.tbopisanieError.Multiline = true;
            this.tbopisanieError.Name = "tbopisanieError";
            this.tbopisanieError.Size = new System.Drawing.Size(265, 204);
            this.tbopisanieError.TabIndex = 13;
            this.tbopisanieError.Text = "Описание ошибки";
            this.tbopisanieError.Enter += new System.EventHandler(this.tbopisanieError_Enter);
            this.tbopisanieError.Leave += new System.EventHandler(this.tbopisanieError_Leave);
            // 
            // btMessageError
            // 
            this.btMessageError.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btMessageError.FlatAppearance.BorderSize = 0;
            this.btMessageError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMessageError.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMessageError.ForeColor = System.Drawing.Color.White;
            this.btMessageError.Location = new System.Drawing.Point(6, 222);
            this.btMessageError.Name = "btMessageError";
            this.btMessageError.Size = new System.Drawing.Size(229, 58);
            this.btMessageError.TabIndex = 12;
            this.btMessageError.Text = "Сообщить об ошибке";
            this.btMessageError.UseVisualStyleBackColor = false;
            this.btMessageError.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbKab
            // 
            this.lbKab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKab.ForeColor = System.Drawing.Color.Gray;
            this.lbKab.Location = new System.Drawing.Point(6, 152);
            this.lbKab.Name = "lbKab";
            this.lbKab.Size = new System.Drawing.Size(84, 25);
            this.lbKab.TabIndex = 11;
            this.lbKab.Text = "Кабинет";
            // 
            // lbDolz
            // 
            this.lbDolz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDolz.ForeColor = System.Drawing.Color.Gray;
            this.lbDolz.Location = new System.Drawing.Point(6, 121);
            this.lbDolz.Name = "lbDolz";
            this.lbDolz.Size = new System.Drawing.Size(86, 23);
            this.lbDolz.TabIndex = 10;
            this.lbDolz.Text = "Должность";
            // 
            // lbOtch
            // 
            this.lbOtch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOtch.ForeColor = System.Drawing.Color.Gray;
            this.lbOtch.Location = new System.Drawing.Point(6, 90);
            this.lbOtch.Name = "lbOtch";
            this.lbOtch.Size = new System.Drawing.Size(86, 21);
            this.lbOtch.TabIndex = 9;
            this.lbOtch.Text = "Отчество";
            // 
            // lbFam
            // 
            this.lbFam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFam.ForeColor = System.Drawing.Color.Gray;
            this.lbFam.Location = new System.Drawing.Point(6, 59);
            this.lbFam.Name = "lbFam";
            this.lbFam.Size = new System.Drawing.Size(86, 25);
            this.lbFam.TabIndex = 8;
            this.lbFam.Text = "Фамилия";
            // 
            // lbIma
            // 
            this.lbIma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIma.ForeColor = System.Drawing.Color.Gray;
            this.lbIma.Location = new System.Drawing.Point(6, 28);
            this.lbIma.Name = "lbIma";
            this.lbIma.Size = new System.Drawing.Size(86, 25);
            this.lbIma.TabIndex = 7;
            this.lbIma.Text = "Имя";
            // 
            // tbKab
            // 
            this.tbKab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbKab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKab.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbKab.ForeColor = System.Drawing.Color.Black;
            this.tbKab.Location = new System.Drawing.Point(96, 152);
            this.tbKab.Name = "tbKab";
            this.tbKab.ReadOnly = true;
            this.tbKab.Size = new System.Drawing.Size(139, 25);
            this.tbKab.TabIndex = 6;
            // 
            // tbDolz
            // 
            this.tbDolz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDolz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDolz.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbDolz.ForeColor = System.Drawing.Color.Black;
            this.tbDolz.Location = new System.Drawing.Point(96, 121);
            this.tbDolz.Name = "tbDolz";
            this.tbDolz.ReadOnly = true;
            this.tbDolz.Size = new System.Drawing.Size(139, 25);
            this.tbDolz.TabIndex = 5;
            // 
            // tbOtch
            // 
            this.tbOtch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbOtch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOtch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbOtch.ForeColor = System.Drawing.Color.Black;
            this.tbOtch.Location = new System.Drawing.Point(96, 90);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.ReadOnly = true;
            this.tbOtch.Size = new System.Drawing.Size(139, 25);
            this.tbOtch.TabIndex = 4;
            // 
            // tbFam
            // 
            this.tbFam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbFam.ForeColor = System.Drawing.Color.Black;
            this.tbFam.Location = new System.Drawing.Point(96, 59);
            this.tbFam.Name = "tbFam";
            this.tbFam.ReadOnly = true;
            this.tbFam.Size = new System.Drawing.Size(139, 25);
            this.tbFam.TabIndex = 3;
            // 
            // tbIma
            // 
            this.tbIma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbIma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbIma.ForeColor = System.Drawing.Color.Black;
            this.tbIma.Location = new System.Drawing.Point(96, 28);
            this.tbIma.Name = "tbIma";
            this.tbIma.ReadOnly = true;
            this.tbIma.Size = new System.Drawing.Size(139, 25);
            this.tbIma.TabIndex = 2;
            // 
            // lbIDUser
            // 
            this.lbIDUser.AutoSize = true;
            this.lbIDUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbIDUser.ForeColor = System.Drawing.Color.Gray;
            this.lbIDUser.Location = new System.Drawing.Point(81, 6);
            this.lbIDUser.Name = "lbIDUser";
            this.lbIDUser.Size = new System.Drawing.Size(0, 21);
            this.lbIDUser.TabIndex = 0;
            this.lbIDUser.Visible = false;
            // 
            // MainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 285);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainUser";
            this.Text = "Отправить сообщение об ошибке";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUser_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbNazvanieError;
        private System.Windows.Forms.TextBox tbopisanieError;
        private System.Windows.Forms.Button btMessageError;
        private System.Windows.Forms.Label lbKab;
        private System.Windows.Forms.Label lbDolz;
        private System.Windows.Forms.Label lbOtch;
        private System.Windows.Forms.Label lbFam;
        private System.Windows.Forms.Label lbIma;
        private System.Windows.Forms.TextBox tbKab;
        private System.Windows.Forms.TextBox tbDolz;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbIma;
        private System.Windows.Forms.Label lbIDUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
