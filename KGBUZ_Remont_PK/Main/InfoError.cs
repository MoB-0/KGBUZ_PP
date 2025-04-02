using KGBUZ_Remont_PK.Class;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK.Main
{
    public partial class InfoError : Form
    {
        public InfoError()
        {
            InitializeComponent();

            lbIDInfoError.Text = MainAdmin.resultIDWrach.ToString();

            tbMethodReshenia.Visible = false;
            tbMethodReshenia.Enabled = false;
            tbMethodReshenia.Hide();

            load();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void load()
        {
            SqlConnection connection = new SqlConnection(DataBase.connStr);
            connection.Open();
            try
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT ima from Wrach where KodWR = @Id";
                    cmd.Parameters.AddWithValue("@Id", lbIDInfoError.Text.ToString());

                    tbIma.Text = (string)cmd.ExecuteScalar();
                }
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT fam from Wrach where KodWR = @Id";
                    cmd.Parameters.AddWithValue("@Id", lbIDInfoError.Text.ToString());

                    tbFam.Text = (string)cmd.ExecuteScalar();
                }
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Otch from Wrach where KodWR = @Id";
                    cmd.Parameters.AddWithValue("@Id", lbIDInfoError.Text.ToString());

                    tbOtch.Text = (string)cmd.ExecuteScalar();
                }
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Nazvanie from Wrach, Dolznost\r\nwhere FK_Dolznost = KodDol and KodWR = @Id";
                    cmd.Parameters.AddWithValue("@Id", lbIDInfoError.Text.ToString());

                    tbDolz.Text = (string)cmd.ExecuteScalar();
                }
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Kabinet from Wrach where KodWR = @Id";
                    cmd.Parameters.AddWithValue("@Id", lbIDInfoError.Text.ToString());

                    tbKab.Text = ((int)cmd.ExecuteScalar()).ToString();
                }

                tbNazvanieError.Text = MainAdmin.NazvanieErrorUser.ToString();

                tbOpisanieError.Text = MainAdmin.OpisanieErrorUser;
            }
            catch
            {
                MessageBox.Show("Выберите заполненную форму ошибки!", "Внимание!", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InfoPK infoPK = new InfoPK();
            infoPK.ShowDialog();
        }

        private void btReestr_Click(object sender, EventArgs e)
        {
            Reestr reestr = new Reestr();
            reestr.ShowDialog();
        }

        private void btOffIsprav_Click(object sender, EventArgs e)
        {
            if (cbxInsetMethod.Checked)
            {
                SqlConnection conn = new SqlConnection(DataBase.connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE JurnalOchibok SET FK_StatusOshibki = 1, MetodRemonta = @methodremonta \r\nWHERE FK_StatusOshibki = 2 and FK_Wrach = @ID and MetodRemonta like ''", conn);
                cmd.Parameters.AddWithValue("@ID", lbIDInfoError.Text.ToString());
                cmd.Parameters.AddWithValue("@methodremonta", tbMethodReshenia.Text.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные об ошибке обновлены, а также метод решения добавлен в реестр", "Уведомление", MessageBoxButtons.OK);

                this.Close();

                conn.Close();
            }
            else
            {
                SqlConnection conn = new SqlConnection(DataBase.connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE JurnalOchibok SET FK_StatusOshibki = 1\r\nWHERE FK_StatusOshibki = 2 and FK_Wrach = @ID and MetodRemonta like ''", conn);
                cmd.Parameters.AddWithValue("@ID", lbIDInfoError.Text.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные об ошибке обновлены", "Уведомление", MessageBoxButtons.OK);

                this.Close();

                conn.Close();
            }
        }

        private void tbMethodReshenia_Enter(object sender, EventArgs e)
        {
            if (tbMethodReshenia.Text == "Метод решения")
            {
                tbMethodReshenia.Clear();
                tbMethodReshenia.ForeColor = Color.Black;
            }
        }

        private void tbMethodReshenia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMethodReshenia.Text))
            {
                tbMethodReshenia.Text = "Метод решения";
                tbMethodReshenia.ForeColor = Color.Gray;
            }
        }

        private void cbxInsetMethod_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxInsetMethod.Checked)
            {
                tbMethodReshenia.Visible = true;
                tbMethodReshenia.Enabled = true;
                tbMethodReshenia.Show();

                this.Width = 1050;
            }
            else
            {
                tbMethodReshenia.Visible = false;
                tbMethodReshenia.Enabled = false;
                tbMethodReshenia.Hide();

                this.Width = 753;
            }
        }
    }
}
