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
    public partial class Report : Form
    {
        string id = string.Empty;
        string EmpID = string.Empty;
        int ReportID = 0;
        bool showAll = false;
        public Report(string requestID)
        {
            InitializeComponent();
            this.id = requestID;
        }
        public Report(string requestID, string empID, int reportID)
        {
            InitializeComponent();
            this.id = requestID;
            EmpID = empID;
            ReportID = reportID;
        }
        public Report(string requestID, string empID, int reportID, bool showAll)
        {
            InitializeComponent();
            this.id = requestID;
            EmpID = empID;
            ReportID = reportID;
            this.showAll = showAll; 
        }

        private void Report_Load(object sender, EventArgs e)
        {
            Fix_btn.Hide();
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            FormDesign.SetTextBoxPlaceholder(reportName_tb, "報告者");
            FormDesign.SetTextBoxPlaceholder(EmpBelong_tb, "所属");
            FormDesign.SetTextBoxPlaceholder(EmpName_tb, "氏名");
            FormDesign.SetTextBoxPlaceholder(InterviewBelong_tb, "所属");
            FormDesign.SetTextBoxPlaceholder(InterviewName_tb, "氏名");
            FormDesign.SetTextBoxPlaceholder(from_tb, "00：00");
            FormDesign.SetTextBoxPlaceholder(to_tb, "00：00");
            FormDesign.SetTextBoxPlaceholder(Result_tb, "結果");
            FormDesign.SetTextBoxPlaceholder(Reason_tb, "理由");
            FormDesign.SetTextBoxPlaceholder(Remarks_tb, "備考");
            FormDesign.SetTextBoxPlaceholder(Details_tb, "案件内容");
            FormDesign.SetTextBoxPlaceholder(Question_tb, "質疑応答");
            FormDesign.SetTextBoxPlaceholder(impression_tb, "所感");
            //実際データから取得”WHERE REPORT_ID = @ReportID”
            reportName_tb.ForeColor = SystemColors.WindowText;
            reportName_tb.Text = id;
            if (!EmpID.Equals(string.Empty) || ReportID != 0)
            {
                EmpName_tb.ForeColor = SystemColors.WindowText;
                EmpName_tb.Text = EmpID;
                label7.Text = "面談報告書編集";
                Register_btn.Text = "編集";
                if (showAll == true)
                {
                    label7.Text = "面談報告書詳細";
                    Register_btn.Hide();
                    Fix_btn.Show();
                    Register_btn.Text = "確定";
                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            label7.Text = "面談報告書詳細";
            Register_btn.Hide();
            Fix_btn.Show();
        }

        private void Fix_btn_Click(object sender, EventArgs e)
        {
            label7.Text = "面談報告書編集";
            Fix_btn.Hide();
            Register_btn.Show();
        }
    }
}
