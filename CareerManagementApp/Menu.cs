using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerManagementApp
{
    public partial class Menu : Form
    {
        public string id = "";
        public string author;
        public string pattern = "";
        public static string connectString = ConnectString.connectString;
        public Menu(string account, string authority = "一般")
        {
            InitializeComponent();
            id = account;
            author = authority;
            
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Region = Region.FromHrgn(FormDesign.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            if (id != null && author.Equals("一般"))
            {
                AllReport_btn.Hide();
                Employee_btn.Hide();
                Skill_btn.Hide();
                Personal_btn.Location = new Point(98, 95);
                Report_btn.Location = new Point(98, 152);
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Personal_btn_Click(object sender, EventArgs e)
        {
            PersonalCareer personalCareer = new PersonalCareer(id, author);
            personalCareer.Show();
            this.Close();
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            ReportList reportList = new ReportList(id, author);
            reportList.Show();
            this.Close();
        }

        private void AllReport_btn_Click(object sender, EventArgs e)
        {
            ReportList reportList = new ReportList(id, author, true);
            reportList.Show();
            this.Close();
        }

        private void Employee_btn_Click(object sender, EventArgs e)
        {
            Employee employyee = new Employee(id, author);
            employyee.Show();
            this.Close();
        }

        private void Skill_btn_Click(object sender, EventArgs e)
        {
            Technology technology = new Technology(id, author);
            technology.Show();
            this.Close();
        }
    }
}
