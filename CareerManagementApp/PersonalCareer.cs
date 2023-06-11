using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using Aspose.Cells;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace CareerManagementApp
{
    public partial class PersonalCareer : Form
    {
        string id = string.Empty;
        string EmpID = string.Empty;
        string author = string.Empty;
        string newFilePath = string.Empty;
        string CareerName = string.Empty;
        public PersonalCareer(string requestID, string authority)
        {
            InitializeComponent();
            id = requestID;
            author = authority;
        }
        public PersonalCareer(string requestID,string requestEmpID, string authority)
        {
            InitializeComponent();
            id = requestID;
            author = authority;
            EmpID = requestEmpID;
        }

        private void PersonalCareer_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            BackgroundImage = FormDesign.CreateRainbowBackground(Width, Height);
            BackgroundImageLayout = ImageLayout.Stretch;
            if (!EmpID.Equals(string.Empty))
            {
                furigana_lb.Text = EmpID;
            }
            else
            {
                furigana_lb.Text = id;
                name_lb.Text = "NGUYEN_MINH_THUAN";
                gender_lb.Text = "男";
                age_lb.Text = "23";
                birthday_lb.Text = DateTime.Now.ToString("yyyy/mm/dd");
                address_lb.Text = "大阪府大阪市東淀川区東中島1丁目12-30-615";
                school1_lb.Text = "ECCコンピュータ専門学校";
                enroll1_lb.Text = "2020/04/01";
                graduate1_lb.Text = "2023/03/10";
                diploma1_lb.Text = "基本情報技術者試験ー午前";
                remarks_lb.Text = "新大阪駅～心斎橋駅10分、歩いてフルタニ産業まで10分";
            }
        }
        private void LoadCareerData()
        {
            // Kết nối đến cơ sở dữ liệu SQL Server
            SqlConnection connection = new SqlConnection("connectionString");
            connection.Open();

            // Tạo câu truy vấn SQL để lấy dữ liệu từ bảng Career và Skill
            string query = "SELECT c.作業名, c.内容, c.参加, c.開始日 + ' - ' + c.終了日 + ' (' + c.期間 + ')' AS 開始日_終了日_期間, c.規模 + ' ' + c.体制 AS 規模_体制, c.感想, s.機種, s.OS, s.言語, s.ツール等 " +
                           "FROM Career c " +
                           "JOIN Skill s ON c.ID = s.CareerID";

            // Thực hiện câu truy vấn và lấy dữ liệu vào DataTable
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataTable);

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            Career_dgv.DataSource = dataTable;

            // Cập nhật giá trị cho các cột ComboBox
            foreach (DataGridViewRow row in Career_dgv.Rows)
            {
                // Cột 機種
                DataGridViewComboBoxCell machineCell = (DataGridViewComboBoxCell)row.Cells["機種"];
                machineCell.DataSource = GetDistinctValues(dataTable, "機種");

                // Cột OS
                DataGridViewComboBoxCell osCell = (DataGridViewComboBoxCell)row.Cells["OS"];
                osCell.DataSource = GetDistinctValues(dataTable, "OS");

                // Cột 言語
                DataGridViewComboBoxCell languageCell = (DataGridViewComboBoxCell)row.Cells["言語"];
                languageCell.DataSource = GetDistinctValues(dataTable, "言語");

                // Cột ツール等
                DataGridViewComboBoxCell toolCell = (DataGridViewComboBoxCell)row.Cells["ツール等"];
                toolCell.DataSource = GetDistinctValues(dataTable, "ツール等");
            }

            // Đóng kết nối đến cơ sở dữ liệu
            connection.Close();

        }

        private List<string> GetDistinctValues(DataTable dataTable, string columnName)
        {
            List<string> distinctValues = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                string value = row[columnName].ToString();

                if (!distinctValues.Contains(value))
                {
                    distinctValues.Add(value);
                }
            }

            return distinctValues;
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
        private void Career_dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Career_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Career_dgv.SelectedRows[0];
                if (selectedRow.Cells[0].Value != null)
                {
                    CareerName = selectedRow.Cells[0].Value.ToString();
                }
            }
        }

        private void Fix_btn_Click(object sender, EventArgs e)
        {
            if (!EmpID.Equals(string.Empty))
            {
                PersonalRegisterUpdate personalRegisterUpdate = new PersonalRegisterUpdate(EmpID);
                personalRegisterUpdate.ShowDialog();
            }
            else
            {
                PersonalRegisterUpdate personalRegisterUpdate = new PersonalRegisterUpdate(id);
                personalRegisterUpdate.ShowDialog();
            }
            this.Hide();
            this.Show();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            CareerRegisterUpdate careerRegisterUpdate = new CareerRegisterUpdate();
            careerRegisterUpdate.ShowDialog();
            this.Hide();
            this.Show();
        }
        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (!CareerName.Equals(string.Empty))
            {
                if (!EmpID.Equals(string.Empty))
                {
                    CareerRegisterUpdate careerRegisterUpdate = new CareerRegisterUpdate(EmpID, CareerName);
                    careerRegisterUpdate.ShowDialog();
                }
                else
                {
                    CareerRegisterUpdate careerRegisterUpdate = new CareerRegisterUpdate(id, CareerName);
                    careerRegisterUpdate.ShowDialog();
                }
                this.Hide();
                CareerName = "";
                this.Show();
            }
            else
            {
                MessageClass.MSError3();
            }
        }
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (!CareerName.Equals(string.Empty))
            {

            }
            else
            {
                MessageClass.MSError3();
            }
        }


        private void Export_btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "PDFファイルを保存する場所を選ぶ？";
                saveFileDialog.DefaultExt = "pdf"; // Định dạng mặc định là PDF
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; // Bộ lọc chỉ hiển thị tệp PDF
                string excelFilePath = "C:/Users/nguyen-minh-thuan/Desktop/経歴書テンプレート.xls";
                string pdfFilePath = "";
                string value1 = furigana_lb.Text;
                string value2 = name_lb.Text;
                if (value1.Equals(string.Empty) || value2.Equals(string.Empty))
                {
                    return;
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AddRowToExcel(excelFilePath, value2);
                    pdfFilePath = saveFileDialog.FileName;
                    SaveToExcel(newFilePath, value1, value2);
                    ConvertExcelToPDF(newFilePath, pdfFilePath);
                    // Hiển thị thông báo thành công
                    MessageBox.Show("Excel file converted to PDF successfully.");
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Error converting Excel file to PDF: " + ex.Message);
            }
            finally
            {
                // Đặt lại biểu tượng chuột mặc định
                Cursor.Current = Cursors.Default;
            }
        }
        private void SaveToExcel(string filePath, string value1, string value2)
        {
            try
            {
                // Load the Excel file using Aspose.Cells
                Workbook workbook = new Workbook(filePath);

                // Get the first worksheet in the workbook
                Worksheet worksheet = workbook.Worksheets[0];

                // Save value1 to cell H3
                worksheet.Cells["H3"].PutValue(value1);

                // Save value2 to cell T4
                worksheet.Cells["H4"].PutValue(value2);

                int rowCount = Career_dgv.Rows.Count;
                int index = 0;
                for (int i = 0; i < (rowCount - 1) * 5; i += 5)
                {
                    worksheet.Cells["A" + (i + 17)].PutValue(Career_dgv.Rows[index].Cells[0].Value);
                    worksheet.Cells["H" + (i + 17)].PutValue(Career_dgv.Rows[index].Cells[1].Value);
                    worksheet.Cells["J" + (i + 17)].PutValue(Career_dgv.Rows[index].Cells[2].Value);
                    
                    DataGridViewComboBoxCell languagesComboBoxCell = (DataGridViewComboBoxCell)Career_dgv.Rows[index].Cells[5];

                    DataGridViewComboBoxCell toolsComboBoxCell = (DataGridViewComboBoxCell)Career_dgv.Rows[index].Cells[6];

                    foreach (string language in languagesComboBoxCell.Items)
                    {
                        int rowIndex = (i + 17) + languagesComboBoxCell.Items.IndexOf(language);

                        worksheet.Cells["L" + rowIndex.ToString()].PutValue(language);
                    }
                    // Loop through each tool value in the ComboBox Tools
                    foreach (string tool in toolsComboBoxCell.Items)
                    {
                        int rowIndex = (i + 17) + toolsComboBoxCell.Items.IndexOf(tool);

                        worksheet.Cells["M" + rowIndex.ToString()].PutValue(tool);
                    }
                    index++;
                }

                // Save the changes in the Excel file
                workbook.Save(filePath);

                //MessageBox.Show("Data saved to Excel successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data to Excel: " + ex.Message);
            }
        }

        private void ConvertExcelToPDF(string excelFilePath, string pdfFilePath)
        {
            try
            {
                // Load the Excel file using Aspose.Cells
                Workbook workbook = new Workbook(excelFilePath);

                // Save the Excel file as PDF
                workbook.Save(pdfFilePath, SaveFormat.Pdf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting Excel file to PDF: " + ex.Message);
            }
        }

        private void AddRowToExcel(string filePath, string value)
        {
            newFilePath = Path.ChangeExtension(filePath, ".xls"); // Lấy tên tệp mới từ tệp Excel gốc
            string newFileName = Path.GetFileNameWithoutExtension(newFilePath) + "_" + value; // Tạo tên tệp mới
            newFilePath = Path.Combine(Path.GetDirectoryName(newFilePath), newFileName + ".xls"); // Xây dựng đường dẫn đến tệp mới

            int rowCount = Career_dgv.Rows.Count - 1;
            // Create an instance of Excel Application
            Excel.Application excelApp = new Excel.Application();

            // Open the Excel workbook
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

            // Get the first worksheet
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            try
            {
                // Copy the source range A17:BD21
                Excel.Range sourceRange = worksheet.Range["A17:BD21"];
                sourceRange.Copy();

                // Insert the copied range into the destination range A22:BD26
                Excel.Range destinationRange = worksheet.Range["A22:BD26"];
                for (int i = 0; i < (rowCount - 1); i++)
                {
                    sourceRange.Copy();
                    destinationRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
                }
                // Save the changes to the new Excel file
                workbook.SaveAs(newFilePath);

                //MessageBox.Show("New Excel file created successfully at: " + newFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating new Excel file: " + ex.Message);
            }
            finally
            {
                // Close the workbook and release the resources
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            }
        }


    }
}
