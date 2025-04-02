using KGBUZ_Remont_PK.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK.Main
{
    public partial class Reestr : Form
    {
        public Reestr()
        {
            InitializeComponent();
            load();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void load()
        {
            try
            {
                string sqlText = "select Nazvanie, Opisanie, MetodRemonta from JurnalOchibok\r\nwhere MetodRemonta not like ''";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, DataBase.connStr);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvSelectMethodRechenia.DataSource = table;
                dgvSelectMethodRechenia.Columns[0].HeaderText = "Название ошибки";
                dgvSelectMethodRechenia.Columns[0].Width = 100;
                dgvSelectMethodRechenia.Columns[1].HeaderText = "Описание";
                dgvSelectMethodRechenia.Columns[1].Width = 300;
                dgvSelectMethodRechenia.Columns[2].HeaderText = "Метод решения";
                dgvSelectMethodRechenia.Columns[2].Width = 300;

                dgvSelectMethodRechenia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvSelectMethodRechenia.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Порблема с БД!" + ex, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSearc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSelectMethodRechenia.RowCount; i++)
            {
                dgvSelectMethodRechenia.Rows[i].Selected = false;
                for (int j = 0; j < dgvSelectMethodRechenia.ColumnCount; j++)
                    if (dgvSelectMethodRechenia.Rows[i].Cells[j].Value != null)
                        if (dgvSelectMethodRechenia.Rows[i].Cells[j].Value.ToString().Contains(tbPoisk.Text))
                        {
                            dgvSelectMethodRechenia.Rows[i].Selected = true;
                            break;
                        }

            }
        }

        private void tbPoisk_Enter(object sender, EventArgs e)
        {
            if (tbPoisk.Text == "Поиск")
            {
                tbPoisk.Clear();
                tbPoisk.ForeColor = Color.Black;
            }
        }

        private void tbPoisk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPoisk.Text))
            {
                tbPoisk.Text = "Поиск";
                tbPoisk.ForeColor = Color.Gray;
            }
        }
    }
}
