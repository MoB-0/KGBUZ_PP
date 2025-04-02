using KGBUZ_Remont_PK.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK.Main
{
    public partial class InsertDetalPKWrach : Form
    {
        public InsertDetalPKWrach()
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

        private void btInsertDetal_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into NomerSborki values (@nazvanieSborki,@kodD_ID,@IDPK)", conn);
            cmd.Parameters.AddWithValue("@nazvanieSborki", InfoPK.NomerSbor.ToString());
            cmd.Parameters.AddWithValue("@kodD_ID", cbInsertDetal.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@IDPK", InfoPK.IDPK.ToString());
            cmd.ExecuteNonQuery();

            var result = MessageBox.Show("Деталь успешно добалена\n Хотите ли вы добавить ещё?", "Уведомление", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                this.Close();
            }

            conn.Close();
        }
    }
}
