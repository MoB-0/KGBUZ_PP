using KGBUZ_Remont_PK.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK.Main
{
    public partial class InfoPK : Form
    {
        public static string IDPK;
        public static string NomerSbor;
        public InfoPK()
        {
            InitializeComponent();
            load();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void load()
        {
            try
            {
                string sqlText = "select Detali.KodD, Kategoria.NazvanieKategorii, Detali.Nazvanie, Detali.Harakterostiki  from NomerSborki, Detali, PK, Kategoria\r\nwhere FK_PK = KodPK and FK_Detali = KodD and FK_Kategoria = KodKat and FK_Wrach =  " + MainAdmin.resultIDWrach.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, DataBase.connStr);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvSelectDetali.DataSource = table;
                dgvSelectDetali.Columns[0].HeaderText = "ID";
                dgvSelectDetali.Columns[0].Width = 50;
                dgvSelectDetali.Columns[1].HeaderText = "Категория";
                dgvSelectDetali.Columns[1].Width = 80;
                dgvSelectDetali.Columns[2].HeaderText = "Название";
                dgvSelectDetali.Columns[2].Width = 100;
                dgvSelectDetali.Columns[3].HeaderText = "Характеристики";
                dgvSelectDetali.Columns[3].Width = 200;

                dgvSelectDetali.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvSelectDetali.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                using (SqlConnection conn = new SqlConnection(DataBase.connStr))
                {

                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "select KodPK from PK\r\nwhere FK_Wrach = @IDWrach";
                    cmd.Parameters.AddWithValue("@IDWrach", MainAdmin.resultIDWrach.ToString());

                    lbPK.Text = cmd.ExecuteScalar().ToString();

                    IDPK = lbPK.Text.ToString();

                    conn.Close();
                }
                using (SqlConnection conn = new SqlConnection(DataBase.connStr))
                {

                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "select distinct Nazvanie from NomerSborki\r\nwhere FK_PK = @IDPK";
                    cmd.Parameters.AddWithValue("@IDPK", lbPK.Text.ToString());

                    lbNomerSborki.Text = cmd.ExecuteScalar().ToString();

                    NomerSbor = lbNomerSborki.Text.ToString();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Порблема с БД!" + ex, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSelectDetali_DoubleClick(object sender, EventArgs e)
        {
            lbNazvaniedetali.Text = dgvSelectDetali.CurrentRow.Cells[2].Value.ToString();

            lbOpisaniedetali.Text = dgvSelectDetali.CurrentRow.Cells[3].Value.ToString();

            lbIDDetali.Text = dgvSelectDetali.CurrentRow.Cells[0].Value.ToString();

            tbIDDetal.Text = dgvSelectDetali.CurrentRow.Cells[0].Value.ToString();


        }

        private void btDobavitDetal_Click(object sender, EventArgs e)
        {
            InsertDetalPKWrach insertDetalPKWrach = new InsertDetalPKWrach();
            insertDetalPKWrach.ShowDialog();

            load();
        }

        private void tbIDDetal_Enter(object sender, EventArgs e)
        {
            if (tbIDDetal.Text == "ID оборудования")
            {
                tbIDDetal.Clear();
                tbIDDetal.ForeColor = Color.Black;
            }
        }

        private void tbIDDetal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIDDetal.Text))
            {
                tbIDDetal.Text = "ID оборудования";
                tbIDDetal.ForeColor = Color.Gray;
            }
        }

        private void btSpisatDetalID_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.connStr))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand("delete from NomerSborki\r\nwhere Nazvanie = @IdSborki and FK_Detali = @iddetali", conn);
                cmd1.Parameters.AddWithValue("@IdSborki", NomerSbor.ToString());
                cmd1.Parameters.AddWithValue("@iddetali", tbIDDetal.Text.ToString());
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Информация об оборудовании удалена", "Уведомление", MessageBoxButtons.OK);

                load();
                conn.Close();
            }
        }
    }
}
