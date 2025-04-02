using KGBUZ_Remont_PK.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK.Main
{
    public partial class InsertDetalVSclad : Form
    {
        public InsertDetalVSclad()
        {
            InitializeComponent();
            LoadDVS();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void LoadDVS()
        {
            try
            {
                string sqlText = "select KodD, Nazvanie from Detali";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, DataBase.connStr);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cbInsertDetal.DataSource = table;
                cbInsertDetal.DisplayMember = "Nazvanie";
                cbInsertDetal.ValueMember = "KodD";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Порблема с БД!" + ex,
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btInsertDetalNaSclad_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into Sklad values (@ID)", conn);
            cmd.Parameters.AddWithValue("@ID", cbInsertDetal.SelectedValue.ToString());
            cmd.ExecuteNonQuery();

            var result = MessageBox.Show("Деталь успешно зачислена на склад!\n Хотите ли вы добавить ещё?", "Уведомление", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                this.Close();
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DobavlenieDetaliPK dobavlenieDetaliPK = new DobavlenieDetaliPK();
            dobavlenieDetaliPK.ShowDialog();

            LoadDVS();
        }
    }
}
