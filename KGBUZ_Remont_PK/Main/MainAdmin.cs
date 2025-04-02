using KGBUZ_Remont_PK.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Exel = Microsoft.Office.Interop.Excel;

namespace KGBUZ_Remont_PK.Main
{
    public partial class MainAdmin : Form
    {
        public static int resultIDWrach;
        public static string NazvanieErrorUser;
        public static string OpisanieErrorUser;
        public static string TehLogin;

        public static int TestColTable;
        public MainAdmin()
        {
            InitializeComponent();
            LoadData();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            TestColTable = dgvSelectError.ColumnCount;
        }

        private void MainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {
            try
            {
                string sqlText = "select Nazvanie, Wremia_Opoweshenia, Opisanie from JurnalOchibok where FK_StatusOshibki != 1";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, DataBase.connStr);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvSelectError.DataSource = table;
                dgvSelectError.Columns[0].HeaderText = "Название ошибки";
                dgvSelectError.Columns[0].Width = 100;
                dgvSelectError.Columns[1].HeaderText = "Время появления";
                dgvSelectError.Columns[1].Width = 100;
                dgvSelectError.Columns[2].HeaderText = "Описание";
                dgvSelectError.Columns[2].Width = 300;

                dgvSelectError.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvSelectError.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Порблема с БД!" + ex, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                SqlConnection connection = new SqlConnection(DataBase.connStr);
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "Select Ima + ' ' + Fam + ' ' + Otch from TehProgrammist where KodTP = @IdTeh";
                cmd.Parameters.AddWithValue("@IdTeh", Authorization.IDUser);

                TehLogin = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Порблема с БД!" + ex, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvSelectError_DoubleClick(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DataBase.connStr);

            connection.Open();

            SqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT FK_Wrach from JurnalOchibok where Opisanie = @opisanie";
            cmd.Parameters.AddWithValue("@opisanie", dgvSelectError.CurrentRow.Cells[2].Value.ToString());

            resultIDWrach = (int)cmd.ExecuteScalar();

            lbIDWrach.Text = resultIDWrach.ToString();

            NazvanieErrorUser = dgvSelectError.CurrentRow.Cells[0].Value.ToString();
            OpisanieErrorUser = dgvSelectError.CurrentRow.Cells[2].Value.ToString();


            InfoError infoError = new InfoError();
            infoError.ShowDialog();

            LoadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sclad sclad = new Sclad();
            sclad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reestr reestr = new Reestr();
            reestr.ShowDialog();
        }

        private void tbPoisk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPoisk.Text))
            {
                tbPoisk.Text = "Поиск";
                tbPoisk.ForeColor = Color.Gray;
            }
        }

        private void btSearc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSelectError.RowCount; i++)
            {
                dgvSelectError.Rows[i].Selected = false;
                for (int j = 0; j < dgvSelectError.ColumnCount; j++)
                    if (dgvSelectError.Rows[i].Cells[j].Value != null)
                        if (dgvSelectError.Rows[i].Cells[j].Value.ToString().Contains(tbPoisk.Text))
                        {
                            dgvSelectError.Rows[i].Selected = true;
                            break;
                        }

            }
        }

        private void btCreateReport_Click(object sender, EventArgs e)
        {
            // Создаём Excel объекты
            Exel.Application excelApp = new Exel.Application();
            Exel.Workbook workbook = excelApp.Workbooks.Add();
            Exel.Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Отчёт по ошибкам";

            // Заголовок отчёта
            worksheet.Range["B3", "G3"].Merge();
            worksheet.Cells[3, 2] = "Отчёт по истории возникших ошибок в работе ПК";
            Exel.Range titleRange = worksheet.Range["B3", "G3"];
            titleRange.HorizontalAlignment = Exel.XlHAlign.xlHAlignCenter;
            titleRange.VerticalAlignment = Exel.XlVAlign.xlVAlignCenter;
            titleRange.Font.Name = "Times New Roman";
            titleRange.Font.Size = 14;
            titleRange.Font.Bold = true;

            // Дата отчёта
            worksheet.Range["B4", "G4"].Merge();
            worksheet.Cells[4, 2] = $"Дата создания: {DateTime.Now:yyyy.MM.dd}";
            Exel.Range dateRange = worksheet.Range["B4", "G4"];
            dateRange.HorizontalAlignment = Exel.XlHAlign.xlHAlignCenter;
            dateRange.VerticalAlignment = Exel.XlVAlign.xlVAlignCenter;

            // Информация о составителе отчёта
            worksheet.Range["H2", "I2"].Merge();
            worksheet.Cells[3, 8] = "КГБУЗ \"Романовская ЦРБ\"";
            Exel.Range dateRange2 = worksheet.Range["B4", "G4"];
            dateRange2.HorizontalAlignment = Exel.XlHAlign.xlHAlignCenter;
            dateRange2.VerticalAlignment = Exel.XlVAlign.xlVAlignCenter;

            worksheet.Cells[4, 8] = $"Составил отчёт техник-программист {TehLogin}";

            // Заголовки колонок
            worksheet.Range["A8", "A8"].Merge();
            worksheet.Cells[8, 1] = "Название";
            worksheet.Range["B8", "F8"].Merge();
            worksheet.Cells[8, 2] = "Описание";
            worksheet.Range["G8", "G8"].Merge();
            worksheet.Cells[8, 7] = "Статус";
            worksheet.Range["H8", "H8"].Merge();
            worksheet.Cells[8, 8] = "Фамилия врача";
            worksheet.Range["I8", "I8"].Merge();
            worksheet.Cells[8, 9] = "Имя врача";

            // Установка ширины колонок
            worksheet.Columns[1].ColumnWidth = 20;
            worksheet.Columns[2].ColumnWidth = 40;
            worksheet.Columns[7].ColumnWidth = 15;
            worksheet.Columns[8].ColumnWidth = 15;
            worksheet.Columns[9].ColumnWidth = 15;

            // Стили для заголовков
            Exel.Range headerRange = worksheet.Range["A8", "I8"];
            headerRange.Font.Bold = true;
            headerRange.Interior.Color = Color.LightGray;
            headerRange.HorizontalAlignment = Exel.XlHAlign.xlHAlignCenter;
            headerRange.VerticalAlignment = Exel.XlVAlign.xlVAlignCenter;
            headerRange.Borders.LineStyle = Exel.XlLineStyle.xlContinuous;

            // Заполнение таблицы данными из базы данных
            string sqlText = "SELECT JurnalOchibok.Nazvanie, JurnalOchibok.Opisanie, StatusOshibki.NazvanieError, Wrach.Fam, Wrach.Ima " +
                             "FROM JurnalOchibok " +
                             "JOIN StatusOshibki ON JurnalOchibok.FK_StatusOshibki = StatusOshibki.KodSO " +
                             "JOIN Wrach ON JurnalOchibok.FK_Wrach = Wrach.KodWr " +
                             "WHERE JurnalOchibok.MetodRemonta LIKE ''";
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlText, DataBase.connStr))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Заполнение данных в Excel
                int rowIndex = 9;
                foreach (DataRow row in table.Rows)
                {
                    worksheet.Cells[rowIndex, 1] = row["Nazvanie"];
                    worksheet.Cells[rowIndex, 2] = row["Opisanie"];
                    worksheet.Cells[rowIndex, 7] = row["NazvanieError"];
                    worksheet.Cells[rowIndex, 8] = row["Fam"];
                    worksheet.Cells[rowIndex, 9] = row["Ima"];

                    // Объединение ячеек под описанием
                    worksheet.Range[worksheet.Cells[rowIndex, 2], worksheet.Cells[rowIndex, 6]].Merge();

                    // Выравнивание текста по вертикали и включение переноса текста
                    Exel.Range dataRow = worksheet.Range[worksheet.Cells[rowIndex, 1], worksheet.Cells[rowIndex, 9]];
                    dataRow.VerticalAlignment = Exel.XlVAlign.xlVAlignCenter;
                    dataRow.WrapText = true; // Включение переноса текста
                    dataRow.EntireRow.AutoFit(); // Автоподгонка высоты строки

                    rowIndex++;
                }
                Exel.Range signatureRange = worksheet.Range[worksheet.Cells[rowIndex + 1, 1], worksheet.Cells[rowIndex + 1, 2]];
                signatureRange.ClearContents(); // Очистка содержимого перед объединением
                signatureRange.Merge();
                worksheet.Cells[rowIndex + 1, 1] = "Подпись";
                signatureRange.Borders[Exel.XlBordersIndex.xlEdgeBottom].LineStyle = Exel.XlLineStyle.xlContinuous;

                // Применение границ к таблице
                Exel.Range dataRange = worksheet.Range["A8", worksheet.Cells[rowIndex - 1, 9]];
                dataRange.Borders[Exel.XlBordersIndex.xlEdgeBottom].LineStyle = Exel.XlLineStyle.xlContinuous;
                dataRange.Borders[Exel.XlBordersIndex.xlEdgeRight].LineStyle = Exel.XlLineStyle.xlContinuous;
                dataRange.Borders[Exel.XlBordersIndex.xlInsideHorizontal].LineStyle = Exel.XlLineStyle.xlContinuous;
                dataRange.Borders[Exel.XlBordersIndex.xlInsideVertical].LineStyle = Exel.XlLineStyle.xlContinuous;
                dataRange.Borders[Exel.XlBordersIndex.xlEdgeTop].LineStyle = Exel.XlLineStyle.xlContinuous;
            }

            // Отображение Excel для пользователя
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}
