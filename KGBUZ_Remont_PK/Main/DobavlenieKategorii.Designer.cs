namespace KGBUZ_Remont_PK
{
    partial class DobavlenieKategorii
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
            this.tbNazwinie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDobawlenie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNazwinie
            // 
            this.tbNazwinie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNazwinie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNazwinie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbNazwinie.ForeColor = System.Drawing.Color.Black;
            this.tbNazwinie.Location = new System.Drawing.Point(12, 37);
            this.tbNazwinie.Name = "tbNazwinie";
            this.tbNazwinie.Size = new System.Drawing.Size(361, 25);
            this.tbNazwinie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // btDobawlenie
            // 
            this.btDobawlenie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btDobawlenie.FlatAppearance.BorderSize = 0;
            this.btDobawlenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDobawlenie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDobawlenie.ForeColor = System.Drawing.Color.White;
            this.btDobawlenie.Location = new System.Drawing.Point(62, 68);
            this.btDobawlenie.Name = "btDobawlenie";
            this.btDobawlenie.Size = new System.Drawing.Size(260, 35);
            this.btDobawlenie.TabIndex = 7;
            this.btDobawlenie.Text = "Добавить";
            this.btDobawlenie.UseVisualStyleBackColor = false;
            this.btDobawlenie.Click += new System.EventHandler(this.btDobawlenie_Click);
            // 
            // DobavlenieKategorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 112);
            this.Controls.Add(this.btDobawlenie);
            this.Controls.Add(this.tbNazwinie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DobavlenieKategorii";
            this.Text = "Добавление новой категории";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazwinie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDobawlenie;
    }
}