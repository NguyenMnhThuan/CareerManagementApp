using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerManagementApp
{
    public partial class EmployeeRegisterUpdate : Form
    {
        string EmpID_before = string.Empty;
        public EmployeeRegisterUpdate()
        {
            InitializeComponent();
        }
        public EmployeeRegisterUpdate(string RequestEmpID)
        {
            InitializeComponent();
            EmpID_before = RequestEmpID;
        }

        private void EmployeeRegisterUpdate_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Region = Region.FromHrgn(FormDesign.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            FormDesign.SetTextBoxPlaceholder(EmployeeID_tb, "社員ID");
            FormDesign.SetTextBoxPlaceholder(Password_tb, "パスワード");
            FormDesign.SetTextBoxPlaceholder(Email_tb, "○○@furutani-sangyou.co.jp");
            FormDesign.ComboBox_Placeholder(Authority_cb, "権限");
            OK_btn.Text = "登録";
            if (!EmpID_before.Equals(string.Empty))
            {
                EmployeeID_tb.ForeColor = SystemColors.WindowText;
                EmployeeID_tb.Text = EmpID_before;
                label1.Text = "社員情報編集";
                OK_btn.Text = "編集";
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
