using KGBUZ_Remont_PK.Class;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK.Main
{
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
            lbIDUser.Text = Authorization.IDUser.ToString();
            StartMenu();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void StartMenu()
        {
            SqlConnection connection = new SqlConnection(DataBase.connStr);
            connection.Open();

            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT ima from Wrach where KodWR = @Id";
                cmd.Parameters.AddWithValue("@Id", lbIDUser.Text.ToString());

                tbIma.Text = (string)cmd.ExecuteScalar();
            }
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT fam from Wrach where KodWR = @Id";
                cmd.Parameters.AddWithValue("@Id", lbIDUser.Text.ToString());

                tbFam.Text = (string)cmd.ExecuteScalar();
            }
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT Otch from Wrach where KodWR = @Id";
                cmd.Parameters.AddWithValue("@Id", lbIDUser.Text.ToString());

                tbOtch.Text = (string)cmd.ExecuteScalar();
            }
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT Nazvanie from Wrach, Dolznost\r\nwhere FK_Dolznost = KodDol and KodWR = @Id";
                cmd.Parameters.AddWithValue("@Id", lbIDUser.Text.ToString());

                tbDolz.Text = (string)cmd.ExecuteScalar();
            }
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT Kabinet from Wrach where KodWR = @Id";
                cmd.Parameters.AddWithValue("@Id", lbIDUser.Text.ToString());

                tbKab.Text = ((int)cmd.ExecuteScalar()).ToString();
            }
        }

        private void MainUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbNazvanieError_Enter(object sender, EventArgs e)
        {
            if (tbNazvanieError.Text == "Название ошибки")
            {
                tbNazvanieError.Clear();
                tbNazvanieError.ForeColor = Color.Black;
            }
        }

        private void tbNazvanieError_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNazvanieError.Text))
            {
                tbNazvanieError.Text = "Название ошибки";
                tbNazvanieError.ForeColor = Color.Gray;
            }
        }

        private void tbopisanieError_Enter(object sender, EventArgs e)
        {
            if (tbopisanieError.Text == "Описание ошибки")
            {
                tbopisanieError.Clear();
                tbopisanieError.ForeColor = Color.Black;
            }
        }

        private void tbopisanieError_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbopisanieError.Text))
            {
                tbopisanieError.Text = "Описание ошибки";
                tbopisanieError.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert Into JurnalOchibok Values ('" + tbNazvanieError.Text.ToString() + "', '" + tbopisanieError.Text.ToString() + "', '" + "', 2" + ", '" + lbIDUser.Text + "', '" + DateTime.Now + "')", conn);
            cmd.ExecuteNonQuery();

            var result = MessageBox.Show("Ваша ошибка ушпешно отправлена технику-программисту\n Хотите ли вы сообщить ещё об одной ошибке?", "Уведомление", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                Application.Exit();
            }

            conn.Close();
        }
    }
}
