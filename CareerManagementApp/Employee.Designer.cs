namespace CareerManagementApp
{
    partial class Employee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.Email_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Employee_dgv = new System.Windows.Forms.DataGridView();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.Status_cb = new System.Windows.Forms.ComboBox();
            this.Exp_cb = new System.Windows.Forms.ComboBox();
            this.Languages_cb = new System.Windows.Forms.ComboBox();
            this.Age_cb = new System.Windows.Forms.ComboBox();
            this.Personal_btn = new System.Windows.Forms.Button();
            this.Report_btn = new System.Windows.Forms.Button();
            this.Sending_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dgv)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tableLayoutPanel10.TabIndex = 16;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Back_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Back_btn.Location = new System.Drawing.Point(1258, 3);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(106, 39);
            this.Back_btn.TabIndex = 17;
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
            this.label2.Text = "社員一覧";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.Register_btn);
            this.panel1.Controls.Add(this.Email_btn);
            this.panel1.Location = new System.Drawing.Point(1254, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 818);
            this.panel1.TabIndex = 11;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Update_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Update_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Update_btn.Location = new System.Drawing.Point(5, 219);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(106, 53);
            this.Update_btn.TabIndex = 13;
            this.Update_btn.Text = "編集";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Delete_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delete_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Delete_btn.Location = new System.Drawing.Point(4, 310);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(106, 53);
            this.Delete_btn.TabIndex = 14;
            this.Delete_btn.Text = "削除";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Register_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Register_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Register_btn.Location = new System.Drawing.Point(4, 134);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(106, 53);
            this.Register_btn.TabIndex = 12;
            this.Register_btn.Text = "登録";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Email_btn
            // 
            this.Email_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Email_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Email_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Email_btn.Location = new System.Drawing.Point(5, 553);
            this.Email_btn.Name = "Email_btn";
            this.Email_btn.Size = new System.Drawing.Size(106, 53);
            this.Email_btn.TabIndex = 15;
            this.Email_btn.Text = "メール";
            this.Email_btn.UseVisualStyleBackColor = false;
            this.Email_btn.Click += new System.EventHandler(this.Email_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Reset_btn.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.Reset_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reset_btn.Location = new System.Drawing.Point(1148, 67);
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
            this.Search_btn.Location = new System.Drawing.Point(1020, 67);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(106, 39);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "検索";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Employee_dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.Employee_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Employee_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Employee_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Employee_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Employee_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Employee_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Employee_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Employee_dgv.ColumnHeadersHeight = 55;
            this.Employee_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Employee_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column9,
            this.Column10,
            this.UpdateDate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Employee_dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.Employee_dgv.EnableHeadersVisualStyles = false;
            this.Employee_dgv.GridColor = System.Drawing.Color.Gray;
            this.Employee_dgv.Location = new System.Drawing.Point(113, 177);
            this.Employee_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.Employee_dgv.MultiSelect = false;
            this.Employee_dgv.Name = "Employee_dgv";
            this.Employee_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Employee_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Employee_dgv.RowHeadersVisible = false;
            this.Employee_dgv.RowHeadersWidth = 50;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Employee_dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Employee_dgv.RowTemplate.Height = 24;
            this.Employee_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Employee_dgv.Size = new System.Drawing.Size(1139, 472);
            this.Employee_dgv.TabIndex = 18;
            this.Employee_dgv.SelectionChanged += new System.EventHandler(this.Employee_dgv_SelectionChanged);
            // 
            // Search_tb
            // 
            this.Search_tb.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.Search_tb.Location = new System.Drawing.Point(284, 67);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(709, 39);
            this.Search_tb.TabIndex = 0;
            this.Search_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Status_cb
            // 
            this.Status_cb.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Status_cb.FormattingEnabled = true;
            this.Status_cb.Items.AddRange(new object[] {
            "更新有",
            "更新無"});
            this.Status_cb.Location = new System.Drawing.Point(1086, 124);
            this.Status_cb.Name = "Status_cb";
            this.Status_cb.Size = new System.Drawing.Size(168, 35);
            this.Status_cb.TabIndex = 6;
            this.Status_cb.Text = "更新状況";
            // 
            // Exp_cb
            // 
            this.Exp_cb.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Exp_cb.FormattingEnabled = true;
            this.Exp_cb.Items.AddRange(new object[] {
            "1年未満",
            "1～3年",
            "3年以上"});
            this.Exp_cb.Location = new System.Drawing.Point(822, 124);
            this.Exp_cb.Name = "Exp_cb";
            this.Exp_cb.Size = new System.Drawing.Size(171, 35);
            this.Exp_cb.TabIndex = 5;
            this.Exp_cb.Text = "経験年数";
            // 
            // Languages_cb
            // 
            this.Languages_cb.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Languages_cb.FormattingEnabled = true;
            this.Languages_cb.Location = new System.Drawing.Point(553, 124);
            this.Languages_cb.Name = "Languages_cb";
            this.Languages_cb.Size = new System.Drawing.Size(171, 35);
            this.Languages_cb.TabIndex = 4;
            this.Languages_cb.Text = "言語";
            // 
            // Age_cb
            // 
            this.Age_cb.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Age_cb.FormattingEnabled = true;
            this.Age_cb.Items.AddRange(new object[] {
            "20～25歳",
            "25～35歳",
            "35歳以上"});
            this.Age_cb.Location = new System.Drawing.Point(284, 124);
            this.Age_cb.Name = "Age_cb";
            this.Age_cb.Size = new System.Drawing.Size(171, 35);
            this.Age_cb.TabIndex = 3;
            this.Age_cb.Text = "年齢";
            // 
            // Personal_btn
            // 
            this.Personal_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Personal_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Personal_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Personal_btn.Location = new System.Drawing.Point(5, 134);
            this.Personal_btn.Name = "Personal_btn";
            this.Personal_btn.Size = new System.Drawing.Size(106, 53);
            this.Personal_btn.TabIndex = 8;
            this.Personal_btn.Text = "情報";
            this.Personal_btn.UseVisualStyleBackColor = false;
            this.Personal_btn.Click += new System.EventHandler(this.Personal_btn_Click);
            // 
            // Report_btn
            // 
            this.Report_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Report_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Report_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Report_btn.Location = new System.Drawing.Point(5, 219);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(106, 53);
            this.Report_btn.TabIndex = 9;
            this.Report_btn.Text = "面談";
            this.Report_btn.UseVisualStyleBackColor = false;
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // Sending_btn
            // 
            this.Sending_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Sending_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Sending_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Sending_btn.Location = new System.Drawing.Point(5, 310);
            this.Sending_btn.Name = "Sending_btn";
            this.Sending_btn.Size = new System.Drawing.Size(106, 53);
            this.Sending_btn.TabIndex = 10;
            this.Sending_btn.Text = "送信中";
            this.Sending_btn.UseVisualStyleBackColor = false;
            this.Sending_btn.Click += new System.EventHandler(this.Sending_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Personal_btn);
            this.panel2.Controls.Add(this.Sending_btn);
            this.panel2.Controls.Add(this.Report_btn);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 706);
            this.panel2.TabIndex = 7;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "社員ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "社員氏名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "フリガナ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "性別";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "メールアドレス";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "メール状況";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // UpdateDate
            // 
            this.UpdateDate.HeaderText = "更新日付";
            this.UpdateDate.Name = "UpdateDate";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Age_cb);
            this.Controls.Add(this.Languages_cb);
            this.Controls.Add(this.Exp_cb);
            this.Controls.Add(this.Status_cb);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.Employee_dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel10);
            this.MaximizeBox = false;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社員管理";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.DataGridView Employee_dgv;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Email_btn;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.ComboBox Status_cb;
        private System.Windows.Forms.ComboBox Exp_cb;
        private System.Windows.Forms.ComboBox Languages_cb;
        private System.Windows.Forms.ComboBox Age_cb;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Personal_btn;
        private System.Windows.Forms.Button Report_btn;
        private System.Windows.Forms.Button Sending_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateDate;
    }
}