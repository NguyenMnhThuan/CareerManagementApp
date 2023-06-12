using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerManagementApp
{
    public partial class ReportList : Form
    {
        string id = string.Empty;
        string EmpID = string.Empty;
        string author = string.Empty;
        int ReportID = 0;
        bool showAll = false;
        public ReportList(string id, string author)
        {
            InitializeComponent();
            this.id = id;
            this.author = author;
        }
        public ReportList(string id, string EmpID, string author)
        {
            InitializeComponent();
            this.id = id;
            this.author = author;
            this.EmpID = EmpID;
        }
        public ReportList(string id, string author, bool showAll)
        {
            InitializeComponent();
            this.id = id;
            this.author = author;
            this.showAll = showAll;
        }

        private void ReportList_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            FormDesign.SetTextBoxPlaceholder(Search_tb, "キワードを入力…");
            if (showAll == true)
            {
                label2.Text = "全面談報告";
                Update_btn.Text = "詳細";
            }
            else if (!EmpID.Equals(string.Empty))
            {
                label2.Text = "各社員面談報告";
            }
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {

        }
        private void Reset_btn_Click(object sender, EventArgs e)
        {

        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            if (!EmpID.Equals(string.Empty))
            {
                this.Close();
            }
            else
            {
                Menu menu = new Menu(id, author);
                menu.Show();
                this.Close();
            }
        }
        private void Report_dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Report_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Report_dgv.SelectedRows[0];
                if (selectedRow.Cells[0].Value != null && Regex.IsMatch(selectedRow.Cells[0].Value.ToString(), ".*[0-9].*"))
                {
                    ReportID = int.Parse(selectedRow.Cells[0].Value.ToString());
                }
            }
        }
        private void Register_btn_Click(object sender, EventArgs e)
        {
            Report report = new Report(id);
            report.ShowDialog();
            this.Hide();
            this.Show();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (ReportID != 0)
            {
                if (showAll == true)
                {
                    Report report = new Report(id, EmpID, ReportID, showAll);
                    report.ShowDialog();
                    this.Hide();
                    ReportID = 0;
                    this.Show();
                }
                else
                {
                    Report report = new Report(id, EmpID, ReportID);
                    report.ShowDialog();
                    this.Hide();
                    ReportID = 0;
                    this.Show();
                }
            }
            else
            {
                MessageClass.MSError3();
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (ReportID != 0)
            {

            }
            else
            {
                MessageClass.MSError3();
            }
        }
    }
}
