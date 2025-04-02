using KGBUZ_Remont_PK.Class;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK
{
    public partial class DobavlenieKategorii : Form
    {
        public DobavlenieKategorii()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btDobawlenie_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into Kategoria values (@nazvanieKategorii)", conn);
            cmd.Parameters.AddWithValue("@nazvanieKategorii", tbNazwinie.Text.ToString());
            cmd.ExecuteNonQuery();

            var result = MessageBox.Show("Категория успешно добалена\n Хотите ли вы добавить ещё?", "Уведомление", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                this.Close();
            }

            conn.Close();
        }
    }
}
