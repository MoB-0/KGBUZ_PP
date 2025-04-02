using KGBUZ_Remont_PK.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Exel = Microsoft.Office.Interop.Excel;

namespace KGBUZ_Remont_PK.Main
{
    public partial class Sclad : Form
    {
        public Sclad()
        {
            InitializeComponent();
            load();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void load()
        {
            try
            {
                string sqlText = "Select Sklad.KodS, Detali.Nazvanie, Kategoria.NazvanieKategorii, Harakterostiki from Sklad, Detali, Kategoria\r\nwhere FK_Detali = KodD and FK_Kategoria = KodKat";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, DataBase.connStr);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvSelectDetali.DataSource = table;
                dgvSelectDetali.Columns[0].HeaderText = "ID";
                dgvSelectDetali.Columns[0].Width = 25;
                dgvSelectDetali.Columns[1].HeaderText = "Название";
                dgvSelectDetali.Columns[1].Width = 130;
                dgvSelectDetali.Columns[2].HeaderText = "Категория";
                dgvSelectDetali.Columns[2].Width = 150;
                dgvSelectDetali.Columns[3].HeaderText = "Характеристики";
                dgvSelectDetali.Columns[3].Width = 300;

                dgvSelectDetali.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvSelectDetali.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Порблема с БД!" + ex, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbIDDetali_Enter(object sender, EventArgs e)
        {
            if (tbIDDetali.Text == "ID оборудования")
            {
                tbIDDetali.Clear();
                tbIDDetali.ForeColor = Color.Black;
            }
        }

        private void tbIDDetali_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIDDetali.Text))
            {
                tbIDDetali.Text = "ID оборудования";
                tbIDDetali.ForeColor = Color.Gray;
            }
        }

        private void dgvSelectDetali_DoubleClick(object sender, EventArgs e)
        {
            tbIDDetali.Text = dgvSelectDetali.CurrentRow.Cells[0].Value.ToString();
        }

        private void btSpisatdetal_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Delete from Sklad\r\nwhere KodS = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", tbIDDetali.Text.ToString());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Информация об оборудовании на складе удалена", "Уведомление", MessageBoxButtons.OK);

            conn.Close();

            load();
        }

        private void btInsertDetal_Click(object sender, EventArgs e)
        {
            InsertDetalVSclad insertDetalVSclad = new InsertDetalVSclad();
            insertDetalVSclad.ShowDialog();
            load();
        }

        private void btCreateReport_Click(object sender, EventArgs e)
        {
            Exel.Application excelApp = new Exel.Application();
            Exel.Workbook workbook = excelApp.Workbooks.Add();
            Exel.Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Отчёт | Детали на складе";

            // Установка заголовка отчета
            Exel.Range titleRange = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 3]];
            titleRange.ClearContents(); // Очистка содержимого перед объединением
            titleRange.Merge();
            worksheet.Cells[2, 1] = "Отчёт по наличию деталей на складе";
            titleRange.Font.Size = 16;
            titleRange.Font.Bold = true;
            titleRange.HorizontalAlignment = Exel.XlHAlign.xlHAlignCenter;

            // Установка даты
            Exel.Range dateRange = worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 3]];
            dateRange.ClearContents(); // Очистка содержимого перед объединением
            dateRange.Merge();
            worksheet.Cells[3, 1] = $"Дата создания: {DateTime.Now:yyyy.MM.dd}";
            dateRange.HorizontalAlignment = Exel.XlHAlign.xlHAlignCenter;

            // Информация о составителе
            Exel.Range authorRange = worksheet.Range[worksheet.Cells[3, 4], worksheet.Cells[3, 5]];
            authorRange.ClearContents(); // Очистка содержимого перед объединением
            authorRange.Merge();
            worksheet.Cells[3, 4] = "КГБУЗ \"Романовская ЦРБ\"";
            worksheet.Cells[4, 4] = $"Составил отчёт техник-программист {MainAdmin.TehLogin}";
            authorRange.HorizontalAlignment = Exel.XlHAlign.xlHAlignLeft;

            // Заголовки таблицы
            worksheet.Cells[6, 1] = "Код";
            worksheet.Cells[6, 2] = "Название детали";
            worksheet.Cells[6, 3] = "Категория";
            worksheet.Cells[6, 4] = "Характеристики";
            Exel.Range headerRange = worksheet.Range[worksheet.Cells[6, 1], worksheet.Cells[6, 4]];
            headerRange.Font.Bold = true;
            headerRange.Borders.LineStyle = Exel.XlLineStyle.xlContinuous;

            // Задание ширины столбцов
            worksheet.Columns[1].ColumnWidth = 10;
            worksheet.Columns[2].ColumnWidth = 30;
            worksheet.Columns[3].ColumnWidth = 20;
            worksheet.Columns[4].ColumnWidth = 40;

            // Получение данных из базы данных
            string sqlQuery = "SELECT Sklad.KodS, Detali.Nazvanie, Kategoria.NazvanieKategorii, Harakterostiki FROM Sklad, Detali, Kategoria WHERE FK_Detali = KodD AND FK_Kategoria = KodKat";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, DataBase.connStr);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Заполнение таблицы данными
            int startRow = 7;
            foreach (DataRow row in table.Rows)
            {
                worksheet.Cells[startRow, 1] = row["KodS"];
                worksheet.Cells[startRow, 2] = row["Nazvanie"];
                worksheet.Cells[startRow, 3] = row["NazvanieKategorii"];
                worksheet.Cells[startRow, 4] = row["Harakterostiki"];

                Exel.Range dataRowRange = worksheet.Range[worksheet.Cells[startRow, 1], worksheet.Cells[startRow, 4]];
                dataRowRange.Borders.LineStyle = Exel.XlLineStyle.xlContinuous;
                dataRowRange.WrapText = true;  // Перенос текста для больших значений
                startRow++;
            }

            // Подпись
            Exel.Range signatureRange = worksheet.Range[worksheet.Cells[startRow + 1, 1], worksheet.Cells[startRow + 1, 2]];
            signatureRange.ClearContents(); // Очистка содержимого перед объединением
            signatureRange.Merge();
            worksheet.Cells[startRow + 1, 1] = "Подпись";
            signatureRange.Borders[Exel.XlBordersIndex.xlEdgeBottom].LineStyle = Exel.XlLineStyle.xlContinuous;

            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}
