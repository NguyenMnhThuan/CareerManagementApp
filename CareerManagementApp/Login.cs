using Aspose.Cells.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CareerManagementApp
{
    public partial class Login : Form
    {
        public static string connectString = ConnectString.connectString;
        public Login()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width,Height);
            BackgroundImageLayout = ImageLayout.Stretch;

            FormDesign.SetTextBoxPlaceholder(EmployeeID_tb, "社員IDを入力…");
            EmployeeID_tb.MaxLength = 10;
            Password_tb.MaxLength = 20;
            Password_tb.PasswordChar = '*';
            panel1.Region = Region.FromHrgn(FormDesign.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                Password_tb.PasswordChar = '\0';
            }
            else
            {
                Password_tb.PasswordChar = '*';
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {

            string employeeID = EmployeeID_tb.Text;
            string password = Password_tb.Text;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT AUTHORITY FROM EMPLOYEE WHERE EMPLOYEE_ID = @EmployeeID AND PASSWORD = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string authority = reader.GetString(0);

                                // 権限を確認し、対応するフォームを作成して表示します
                                if (authority.Equals("管理者"))
                                {
                                    Menu menu = new Menu(employeeID, "管理者");
                                    menu.Show();
                                    this.Hide();
                                }
                                else if (authority.Equals("一般"))
                                {
                                    Menu menu = new Menu(employeeID, "一般");
                                    menu.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageClass.MSError1();
                                EmployeeID_tb.Text = string.Empty;
                                Password_tb.Text = string.Empty;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageClass.MSError2(ex);
                }

            }
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("このアプリケーションを閉じますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the form closing event
                }
                else
                {
                    if (Application.OpenForms.Count > 0) // Only the current form is open
                    {
                        Application.Exit(); // Close the application
                    }
                }
            }
        }

    }
}
