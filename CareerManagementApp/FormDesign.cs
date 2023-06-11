using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerManagementApp
{
    public class FormDesign
    {
        public static Image CreateRainbowBackground(int Width, int Height)
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush gradientBrush = new LinearGradientBrush(rectangle, Color.AliceBlue, Color.SteelBlue, LinearGradientMode.Horizontal);

            graphics.FillRectangle(gradientBrush, rectangle);

            return bitmap;
        }
        // Hàm tạo hình chữ nhật có góc bo tròn
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);

        public static void ComboBox_Placeholder(ComboBox comboBox, string placeholder)
        {
            comboBox.Text = placeholder;
            comboBox.ForeColor = SystemColors.GrayText;

            comboBox.Enter += (s, e) =>
            {
                if (comboBox.Text == placeholder)
                {
                    comboBox.Text = string.Empty;
                    comboBox.ForeColor = SystemColors.WindowText;
                }
            };

            comboBox.Leave += (s, e) =>
            {
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = placeholder;
                    comboBox.ForeColor = SystemColors.GrayText;
                }
            };
        }
        public static void SetTextBoxPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = SystemColors.GrayText;
            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
        }
    }
}
