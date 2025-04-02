using KGBUZ_Remont_PK.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KGBUZ_Remont_PK.Main
{
    public partial class Authorization : Form
    {
        public static int IDUser;
        public static string TestLogin;
        public static string TestPassword;
        public Authorization()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
        }

        private void btAuthorization_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(DataBase.connStr))
                {
                    sqlcon.Open();

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    DataTable dataTable2 = new DataTable();
                    SqlDataAdapter adapter2 = new SqlDataAdapter();

                    SqlCommand command = new SqlCommand("select FK_TypeDostupa from TehProgrammist\r\nwhere Login_User = @login and Password_User = @password", sqlcon);
                    command.Parameters.AddWithValue("@login", tbLogin.Text.ToString());
                    command.Parameters.AddWithValue("@password", tbPassword.Text.ToString());

                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);

                    SqlCommand command2 = new SqlCommand("select FK_TypeDostupa from Wrach\r\nwhere Login_User = @login2 and Password_User = @password2", sqlcon);
                    command2.Parameters.AddWithValue("@login2", tbLogin.Text.ToString());
                    command2.Parameters.AddWithValue("@password2", tbPassword.Text.ToString());

                    adapter2.SelectCommand = command2;
                    adapter2.Fill(dataTable2);

                    if (dataTable.Rows.Count > 0)
                    {
                        SqlConnection connection = new SqlConnection(DataBase.connStr);
                        connection.Open();

                        SqlCommand cmd = connection.CreateCommand();

                        cmd.CommandText = "SELECT KodTP from TehProgrammist where Login_User = @login3 and Password_User = @password3";
                        cmd.Parameters.AddWithValue("@login3", tbLogin.Text.ToString());
                        cmd.Parameters.AddWithValue("@password3", tbPassword.Text.ToString());

                        IDUser = ((int)cmd.ExecuteScalar());

                        this.Hide();
                        MainAdmin mainAdmin = new MainAdmin();
                        mainAdmin.Show();

                    }
                    else
                    {
                        if (dataTable2.Rows.Count > 0)
                        {
                            SqlConnection connection = new SqlConnection(DataBase.connStr);
                            connection.Open();

                            SqlCommand cmd = connection.CreateCommand();

                            cmd.CommandText = "SELECT KodWr from Wrach\r\nwhere Login_User = @login and Password_User = @password";
                            cmd.Parameters.AddWithValue("@login", tbLogin.Text.ToString());
                            cmd.Parameters.AddWithValue("@password", tbPassword.Text.ToString());

                            IDUser = (int)cmd.ExecuteScalar();

                            lbID.Text = IDUser.ToString();

                            this.Hide();
                            MainUser mainuser = new MainUser();
                            mainuser.Show();
                        }
                        else
                        {
                            MessageBox.Show("Не верный логин или пароль!");
                        }
                    }
                    sqlcon.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели неверный пароль","Внимание!");
            }
        }
    }
}
