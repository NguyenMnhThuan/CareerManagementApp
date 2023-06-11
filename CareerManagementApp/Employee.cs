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
    public partial class Employee : Form
    {
        string id = string.Empty;
        string author = string.Empty;
        string EmpID = string.Empty;
        public Employee(string requestID, string authority)
        {
            InitializeComponent();
            id = requestID;
            author = authority;
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            FormDesign.SetTextBoxPlaceholder(Search_tb, "キワードを入力…");
            FormDesign.ComboBox_Placeholder(Age_cb, "年齢");
            FormDesign.ComboBox_Placeholder(Languages_cb, "言語");
            FormDesign.ComboBox_Placeholder(Exp_cb, "経験年数");
            FormDesign.ComboBox_Placeholder(Status_cb, "更新状況");
            Status_cb.Hide();
        }
        //戻る
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(id, author);
            menu.Show();
            this.Close();
        }
        //メールを送信
        private void Email_btn_Click(object sender, EventArgs e)
        {

        }
        //送信リストを確認
        private void Sending_btn_Click(object sender, EventArgs e)
        {
            Status_cb.Show();
        }
        //リセット
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            FormDesign.SetTextBoxPlaceholder(Search_tb, "キワードを入力…");
            Status_cb.Hide();
        }
        //検索機能
        private void Search_btn_Click(object sender, EventArgs e)
        {

        }
        //社員IDを取得
        private void Employee_dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Employee_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Employee_dgv.SelectedRows[0];
                if (selectedRow.Cells[0].Value != null)
                {
                    EmpID = selectedRow.Cells[0].Value.ToString();
                }
            }
        }
        //アカウントを登録
        private void Register_btn_Click(object sender, EventArgs e)
        {
            EmployeeRegisterUpdate employeeRegisterUpdate = new EmployeeRegisterUpdate();
            employeeRegisterUpdate.ShowDialog();
            this.Hide();
            this.Show();
        }
        //アカウントを編集
        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (!EmpID.Equals(string.Empty))
            {
                EmployeeRegisterUpdate employeeRegisterUpdate = new EmployeeRegisterUpdate(EmpID);
                employeeRegisterUpdate.ShowDialog();
                this.Hide();
                EmpID = "";
                this.Show();
            }
            else
            {
                MessageClass.MSError3();
            }
        }
        //アカウントを削除
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (!EmpID.Equals(string.Empty))
            {
                
            }
            else
            {
                MessageClass.MSError3();
            }
        }
        //社員情報を確認
        private void Personal_btn_Click(object sender, EventArgs e)
        {
            if (!EmpID.Equals(string.Empty))
            {
                PersonalCareer personalCareer = new PersonalCareer(id, EmpID, author);
                personalCareer.ShowDialog();
                this.Hide();
                EmpID = "";
                this.Show();
            }
            else
            {
                MessageClass.MSError3();
            }
        }
        //面談報告を確認
        private void Report_btn_Click(object sender, EventArgs e)
        {
            if (!EmpID.Equals(string.Empty))
            {
                ReportList reportList = new ReportList(id, EmpID, author);
                reportList.ShowDialog();
                this.Hide();
                EmpID = "";
                this.Show();
            }
            else
            {
                MessageClass.MSError3();
            }
        }
    }
}
