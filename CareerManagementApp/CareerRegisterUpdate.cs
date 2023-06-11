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
    public partial class CareerRegisterUpdate : Form
    {
        string requestID = string.Empty;
        string CareerName = string.Empty;
        public CareerRegisterUpdate(string requestID, string CareerName)
        {
            InitializeComponent();
            this.requestID = requestID;
            this.CareerName = CareerName;
        }
        public CareerRegisterUpdate()
        {
            InitializeComponent();
        }

        private void CareerRegisterUpdate_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            FormDesign.SetTextBoxPlaceholder(CareerName_tb, "作業名");
            FormDesign.SetTextBoxPlaceholder(Scale_tb, "規模");
            FormDesign.SetTextBoxPlaceholder(Engine_tb, "体制");
            FormDesign.SetTextBoxPlaceholder(Remarks_tb, "備考");
            panel1.Region = Region.FromHrgn(FormDesign.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(FormDesign.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            if (!requestID.Equals(string.Empty))
            {
                CareerName_tb.ForeColor = SystemColors.WindowText;
                CareerName_tb.Text = requestID+" : "+ CareerName;
                label12.Text = "経歴情報編集";
                Register_btn.Text = "編集";
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SelectedCheckBoxes(panel1));
            MessageBox.Show(SelectedCheckBoxes(panel2));

            DateTime startDays = dateTimePicker1.Value;
            DateTime endDays = dateTimePicker2.Value;
            MessageBox.Show(SelectedDays(startDays, endDays));

        }
        //内容や参加の結果を取得
        private string SelectedCheckBoxes(Panel panel)
        {
            List<CheckBox> checkBoxes = panel.Controls.OfType<CheckBox>().OrderBy(c => c.TabIndex).ToList();
            List<string> resultSegments = new List<string>();
            List<int> continuousIndexes = new List<int>();

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    int currentIndex = checkBox.TabIndex;
                    if (continuousIndexes.Count == 0 || currentIndex == continuousIndexes.Last() + 1)
                    {
                        continuousIndexes.Add(currentIndex);
                    }
                    else
                    {
                        if (continuousIndexes.Count > 1)
                        {
                            string segment = continuousIndexes.First().ToString() + " - " + continuousIndexes.Last().ToString();
                            resultSegments.Add(segment);
                        }
                        else
                        {
                            resultSegments.Add(continuousIndexes.First().ToString());
                        }
                        continuousIndexes.Clear();
                        continuousIndexes.Add(currentIndex);
                    }
                }
            }

            if (continuousIndexes.Count > 1)
            {
                string segment = continuousIndexes.First().ToString() + " - " + continuousIndexes.Last().ToString();
                resultSegments.Add(segment);
            }
            else if (continuousIndexes.Count == 1)
            {
                resultSegments.Add(continuousIndexes.First().ToString());
            }

            string result = string.Join(", ", resultSegments);
            return result;
        }
        //作業期間を取得
        private string SelectedDays(DateTime startDays, DateTime endDays)
        {
            if (startDays > endDays)
            {
                DateTime temp = startDays;
                startDays = endDays;
                endDays = temp;
            }

            TimeSpan duration = endDays - startDays;

            int years = duration.Days / 365;
            int months = (duration.Days % 365) / 30;

            string result = years.ToString() + "年" + months.ToString() + "ヶ月";
            return result;
        }

    }
}
