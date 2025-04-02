using System;

namespace KGBUZ_Remont_PK.Main
{
    partial class Authorization
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btAuthorization = new System.Windows.Forms.Button();
            this.btShowPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbLogin.ForeColor = System.Drawing.Color.Black;
            this.tbLogin.Location = new System.Drawing.Point(70, 100);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(260, 25);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(70, 160);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(226, 25);
            this.tbPassword.TabIndex = 1;
            // 
            // btAuthorization
            // 
            this.btAuthorization.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btAuthorization.FlatAppearance.BorderSize = 0;
            this.btAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAuthorization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAuthorization.ForeColor = System.Drawing.Color.White;
            this.btAuthorization.Location = new System.Drawing.Point(70, 210);
            this.btAuthorization.Name = "btAuthorization";
            this.btAuthorization.Size = new System.Drawing.Size(260, 35);
            this.btAuthorization.TabIndex = 2;
            this.btAuthorization.Text = "Войти";
            this.btAuthorization.UseVisualStyleBackColor = false;
            this.btAuthorization.Click += new System.EventHandler(this.btAuthorization_Click);
            // 
            // btShowPassword
            // 
            this.btShowPassword.BackColor = System.Drawing.Color.White;
            this.btShowPassword.FlatAppearance.BorderSize = 0;
            this.btShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShowPassword.Location = new System.Drawing.Point(302, 158);
            this.btShowPassword.Name = "btShowPassword";
            this.btShowPassword.Size = new System.Drawing.Size(28, 27);
            this.btShowPassword.TabIndex = 3;
            this.btShowPassword.Text = "👁️";
            this.btShowPassword.UseVisualStyleBackColor = false;
            this.btShowPassword.Click += new System.EventHandler(this.btShowPassword_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(66, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "КГБУЗ \"Романовская ЦРБ\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(388, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 7;
            // 
            // Authorization
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btAuthorization);
            this.Controls.Add(this.btShowPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btAuthorization;
        private System.Windows.Forms.Button btShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        // Показать/скрыть пароль
        private void btShowPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '•')
            {
                tbPassword.PasswordChar = '\0';  // Показывать пароль
            }
            else
            {
                tbPassword.PasswordChar = '•';  // Скрывать пароль
            }
        }

        private System.Windows.Forms.Label lbID;
    }
}