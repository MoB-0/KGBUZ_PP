using KGBUZ_Remont_PK.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK.Main
{
    public partial class DobavlenieDetaliPK : Form
    {
        public DobavlenieDetaliPK()
        {
            InitializeComponent();
            LoadDP();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void LoadDP()
        {
            try
            {
                string sqlText = "select KodKat, NazvanieKategorii from Kategoria";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, DataBase.connStr);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cbKategoria.DataSource = table;
                cbKategoria.DisplayMember = "NazvanieKategorii";
                cbKategoria.ValueMember = "KodKat";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Порблема с БД!" + ex,
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btNewDetalInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into Detali values (@nazvanie,@kategoria,@opisanie)", conn);
            cmd.Parameters.AddWithValue("@nazvanie", tbNazvan.Text.ToString());
            cmd.Parameters.AddWithValue("@kategoria", cbKategoria.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@opisanie", tbOpisan.Text.ToString());
            cmd.ExecuteNonQuery();

            var result = MessageBox.Show("Деталь успешно внесена в базу!", "Уведомление", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                this.Close();
            }

            conn.Close();
        }

        private void btDobavlenieKategorii_Click(object sender, EventArgs e)
        {
            DobavlenieKategorii dobavlenieKategorii = new DobavlenieKategorii();
            dobavlenieKategorii.ShowDialog();

            LoadDP();
        }
    }
}
