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
using System.Configuration;

namespace CareerManagementApp
{
    public partial class PersonalCareer : Form
    {
        string id = string.Empty;
        string EmpID = string.Empty;
        string author = string.Empty;
        string newFilePath = string.Empty;
        string CareerName = string.Empty;
        public static string connectString = ConfigurationManager.AppSettings["SqlServerAddress"];
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
            //LoadCareerData();
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
                remarks_lb.Text = "新大阪駅～心斎橋駅10分、歩いてフルタニ産業まで10分";
            }
        }
        private void LoadCareerData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT c.CAREER_NAME AS '作業名', c.DETAILS AS '内容', c.ENTRY AS '参加'," +
                                   "CONVERT(varchar, c.START_DATE, 111) + ' - ' + CONVERT(varchar, c.END_DATE, 111) + ' (' + c.PERIOD + ')' AS '開始日終了日期間', " +
                                   "c.REGINE + ' ' + c.SCALE AS '規模体制', " +
                                   "c.REMARKS AS '備考' " +
                                   "FROM CAREER c " +
                                   "WHERE c.EMPLOYEE_ID = @EmpID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpID", "Emp001");

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        Career_dgv.Rows.Clear(); // データをクリア

                        // データを表示
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = Career_dgv.Rows.Add();

                            // DataGridViewの各セルに値を設定
                            Career_dgv.Rows[rowIndex].Cells["作業名"].Value = row["作業名"];
                            Career_dgv.Rows[rowIndex].Cells["内容"].Value = row["内容"];
                            Career_dgv.Rows[rowIndex].Cells["参加"].Value = row["参加"];
                            Career_dgv.Rows[rowIndex].Cells["開始日終了日期間"].Value = row["開始日終了日期間"];
                            Career_dgv.Rows[rowIndex].Cells["規模体制"].Value = row["規模体制"];
                            Career_dgv.Rows[rowIndex].Cells["備考"].Value = row["備考"];
                        }
                    }

                    // ComboBox列に値を割り当て
                    AssignComboBoxValues();
                }
                catch (SqlException ex)
                {
                    MessageClass.MSError2(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void AssignComboBoxValues()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT c.CAREER_NAME AS '作業名', " +
                                   "s.MODEL_ID AS '機種', " +
                                   "s.OS_ID AS 'OS', " +
                                   "s.PG_LANGUAGES_ID AS '言語', " +
                                   "s.TOOL_ETC_ID AS 'DBネットワークツール等' " +
                                   "FROM CAREER c " +
                                   "JOIN TECHNOLOGY s ON c.CAREER_ID = s.CAREER_ID " +
                                   "WHERE c.EMPLOYEE_ID = @EmpID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpID", "Emp001");

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        // ComboBox列に値を割り当て
                        DataGridViewComboBoxColumn machineColumn = (DataGridViewComboBoxColumn)Career_dgv.Columns["機種"];
                        DataGridViewComboBoxColumn osColumn = (DataGridViewComboBoxColumn)Career_dgv.Columns["OS"];
                        DataGridViewComboBoxColumn languageColumn = (DataGridViewComboBoxColumn)Career_dgv.Columns["言語"];
                        DataGridViewComboBoxColumn toolColumn = (DataGridViewComboBoxColumn)Career_dgv.Columns["DBネットワークツール等"];

                        machineColumn.Items.Clear();
                        osColumn.Items.Clear();
                        languageColumn.Items.Clear();
                        toolColumn.Items.Clear();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string machineValue = row["機種"].ToString();
                            string osValue = row["OS"].ToString();
                            string languageValue = row["言語"].ToString();
                            string toolValue = row["DBネットワークツール等"].ToString();

                            if (!machineColumn.Items.Contains(machineValue))
                                machineColumn.Items.Add(machineValue);

                            if (!osColumn.Items.Contains(osValue))
                                osColumn.Items.Add(osValue);

                            if (!languageColumn.Items.Contains(languageValue))
                                languageColumn.Items.Add(languageValue);

                            if (!toolColumn.Items.Contains(toolValue))
                                toolColumn.Items.Add(toolValue);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageClass.MSError2(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
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
                string excelFilePath = ConfigurationManager.AppSettings["ExcelDirectory"];
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

        private void Career_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
