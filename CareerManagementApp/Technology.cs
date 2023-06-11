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
    public partial class Technology : Form
    {
        string id = "";
        string author = "";
        string SkillName = string.Empty;
        public Technology(string id, string author)
        {
            InitializeComponent();
            this.id = id;
            this.author = author;
            Technology_cb.SelectedIndexChanged += Technology_cb_SelectedIndexChanged;
        }
        
        private void Technology_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            FormDesign.SetTextBoxPlaceholder(Search_tb, "キワードを入力…");
            FormDesign.SetTextBoxPlaceholder(Skill_tb, "技術名(romaji)");
            FormDesign.ComboBox_Placeholder(Technology_cb, "技術選択");
            panel1.Region = Region.FromHrgn(FormDesign.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(id, author);
            menu.Show();
            this.Close();
        }

        private void Technology_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = Technology_cb.SelectedItem.ToString();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            FormDesign.SetTextBoxPlaceholder(Search_tb, "キワードを入力…");
            FormDesign.SetTextBoxPlaceholder(Skill_tb, "技術名(romaji)");
        }

        private void Technology_dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Technology_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Technology_dgv.SelectedRows[0];
                if (selectedRow.Cells[1].Value != null)
                {
                    SkillName = selectedRow.Cells[1].Value.ToString();
                }
            }
            Skill_tb.ForeColor = SystemColors.WindowText;
            Skill_tb.Text = SkillName;
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
