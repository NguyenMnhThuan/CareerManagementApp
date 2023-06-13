namespace CareerManagementApp
{
    partial class ReportList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.Report_dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.60584F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.39416F));
            this.tableLayoutPanel10.Controls.Add(this.Back_btn, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1370, 45);
            this.tableLayoutPanel10.TabIndex = 19;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Back_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Back_btn.Location = new System.Drawing.Point(1258, 3);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(106, 39);
            this.Back_btn.TabIndex = 7;
            this.Back_btn.Text = "戻る";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1251, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "面談報告一覧";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Reset_btn.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.Reset_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reset_btn.Location = new System.Drawing.Point(1150, 95);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(106, 39);
            this.Reset_btn.TabIndex = 2;
            this.Reset_btn.Text = "↺";
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Search_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Search_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Search_btn.Location = new System.Drawing.Point(1006, 95);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(106, 39);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "検索";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Search_tb
            // 
            this.Search_tb.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.Search_tb.Location = new System.Drawing.Point(259, 95);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(709, 39);
            this.Search_tb.TabIndex = 0;
            this.Search_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Report_dgv
            // 
            this.Report_dgv.AllowUserToResizeColumns = false;
            this.Report_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.Report_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Report_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Report_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Report_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Report_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Report_dgv.ColumnHeadersHeight = 55;
            this.Report_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Report_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Report_dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.Report_dgv.EnableHeadersVisualStyles = false;
            this.Report_dgv.GridColor = System.Drawing.Color.Gray;
            this.Report_dgv.Location = new System.Drawing.Point(112, 179);
            this.Report_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.Report_dgv.MultiSelect = false;
            this.Report_dgv.Name = "Report_dgv";
            this.Report_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Report_dgv.RowHeadersVisible = false;
            this.Report_dgv.RowHeadersWidth = 50;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Report_dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Report_dgv.RowTemplate.Height = 24;
            this.Report_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report_dgv.Size = new System.Drawing.Size(1141, 472);
            this.Report_dgv.TabIndex = 6;
            this.Report_dgv.SelectionChanged += new System.EventHandler(this.Report_dgv_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 6.168436F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 21.31608F;
            this.Column2.HeaderText = "報告日";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 39.5522F;
            this.Column3.HeaderText = "報告者";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 76.58845F;
            this.Column4.HeaderText = "被面談者";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 151.8064F;
            this.Column5.HeaderText = "面談日付";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 304.5686F;
            this.Column6.HeaderText = "面談先会社名";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 280;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.Register_btn);
            this.panel1.Location = new System.Drawing.Point(1254, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 702);
            this.panel1.TabIndex = 23;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Update_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Update_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Update_btn.Location = new System.Drawing.Point(5, 219);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(106, 53);
            this.Update_btn.TabIndex = 4;
            this.Update_btn.Text = "編集";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Register_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Register_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Register_btn.Location = new System.Drawing.Point(4, 134);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(106, 53);
            this.Register_btn.TabIndex = 3;
            this.Register_btn.Text = "登録";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // ReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.Report_dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel10);
            this.MaximizeBox = false;
            this.Name = "ReportList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "面談報告書一覧";
            this.Load += new System.EventHandler(this.ReportList_Load);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.DataGridView Report_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}