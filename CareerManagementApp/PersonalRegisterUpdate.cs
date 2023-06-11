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
    public partial class PersonalRegisterUpdate : Form
    {
        string requestID = string.Empty;
        public PersonalRegisterUpdate(string requestID)
        {
            InitializeComponent();
            this.requestID = requestID;
            Add_btn.Click += Add_btn_Click;
        }

        private void PersonalRegisterUpdate_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            FormDesign.SetTextBoxPlaceholder(name_tb, "名前");
            FormDesign.SetTextBoxPlaceholder(inisal_tb, "イニシャル");
            FormDesign.SetTextBoxPlaceholder(furigana_tb, "フリガナ");
            FormDesign.SetTextBoxPlaceholder(address_tb, "現住所");
            FormDesign.SetTextBoxPlaceholder(school1_tb, "学歴１");
            FormDesign.SetTextBoxPlaceholder(school2_tb, "学歴２");
            FormDesign.SetTextBoxPlaceholder(school3_tb, "学歴３");
            FormDesign.SetTextBoxPlaceholder(diploma_tb, "資格登録");
            FormDesign.SetTextBoxPlaceholder(Remarks_tb, "特記事項");
            FormDesign.ComboBox_Placeholder(Belong_cb, "所属選択");
            FormDesign.ComboBox_Placeholder(Diploma_cb, "資格確認");
            name_tb.ForeColor = SystemColors.WindowText;
            name_tb.Text = requestID;
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            string degree = diploma_tb.Text.Trim();

            if (!string.IsNullOrEmpty(degree))
            {
                if (Diploma_cb.Items.Contains(degree))
                {
                    Diploma_cb.Items[Diploma_cb.Items.IndexOf(degree)] = degree;
                }
                else
                {
                    Diploma_cb.Items.Add(degree);
                }
                diploma_tb.Clear();
                Diploma_cb.Text = string.Empty;
                Diploma_cb.ForeColor = SystemColors.WindowText;
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (Diploma_cb.SelectedIndex != -1)
            {
                Diploma_cb.Items.RemoveAt(Diploma_cb.SelectedIndex);
                Diploma_cb.Text = string.Empty;
            }
        }

        private void Diploma_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Diploma_cb.SelectedIndex != -1)
            {
                string selectedDegree = Diploma_cb.SelectedItem.ToString();
                diploma_tb.Text = selectedDegree;
                diploma_tb.ForeColor = SystemColors.WindowText;
            }
        }


        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
