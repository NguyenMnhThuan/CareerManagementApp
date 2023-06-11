namespace CareerManagementApp
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllReport_btn = new System.Windows.Forms.Button();
            this.Skill_btn = new System.Windows.Forms.Button();
            this.Employee_btn = new System.Windows.Forms.Button();
            this.Report_btn = new System.Windows.Forms.Button();
            this.Personal_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.AllReport_btn);
            this.panel1.Controls.Add(this.Skill_btn);
            this.panel1.Controls.Add(this.Employee_btn);
            this.panel1.Controls.Add(this.Report_btn);
            this.panel1.Controls.Add(this.Personal_btn);
            this.panel1.Location = new System.Drawing.Point(186, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 272);
            this.panel1.TabIndex = 2;
            // 
            // AllReport_btn
            // 
            this.AllReport_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.AllReport_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllReport_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AllReport_btn.Location = new System.Drawing.Point(98, 117);
            this.AllReport_btn.Name = "AllReport_btn";
            this.AllReport_btn.Size = new System.Drawing.Size(210, 35);
            this.AllReport_btn.TabIndex = 3;
            this.AllReport_btn.Text = "全面談報告";
            this.AllReport_btn.UseVisualStyleBackColor = false;
            this.AllReport_btn.Click += new System.EventHandler(this.AllReport_btn_Click);
            // 
            // Skill_btn
            // 
            this.Skill_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Skill_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Skill_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Skill_btn.Location = new System.Drawing.Point(98, 231);
            this.Skill_btn.Name = "Skill_btn";
            this.Skill_btn.Size = new System.Drawing.Size(210, 35);
            this.Skill_btn.TabIndex = 5;
            this.Skill_btn.Text = "技術管理";
            this.Skill_btn.UseVisualStyleBackColor = false;
            this.Skill_btn.Click += new System.EventHandler(this.Skill_btn_Click);
            // 
            // Employee_btn
            // 
            this.Employee_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Employee_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Employee_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Employee_btn.Location = new System.Drawing.Point(98, 174);
            this.Employee_btn.Name = "Employee_btn";
            this.Employee_btn.Size = new System.Drawing.Size(210, 35);
            this.Employee_btn.TabIndex = 4;
            this.Employee_btn.Text = "社員一覧";
            this.Employee_btn.UseVisualStyleBackColor = false;
            this.Employee_btn.Click += new System.EventHandler(this.Employee_btn_Click);
            // 
            // Report_btn
            // 
            this.Report_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Report_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Report_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Report_btn.Location = new System.Drawing.Point(98, 66);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(210, 35);
            this.Report_btn.TabIndex = 2;
            this.Report_btn.Text = "面談報告一覧";
            this.Report_btn.UseVisualStyleBackColor = false;
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // Personal_btn
            // 
            this.Personal_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Personal_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Personal_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Personal_btn.Location = new System.Drawing.Point(98, 11);
            this.Personal_btn.Name = "Personal_btn";
            this.Personal_btn.Size = new System.Drawing.Size(210, 35);
            this.Personal_btn.TabIndex = 1;
            this.Personal_btn.Text = "個人情報・経歴";
            this.Personal_btn.UseVisualStyleBackColor = false;
            this.Personal_btn.Click += new System.EventHandler(this.Personal_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Logout_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Logout_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Logout_btn.Location = new System.Drawing.Point(666, 12);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(106, 35);
            this.Logout_btn.TabIndex = 6;
            this.Logout_btn.Text = "ログアウト";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メニュー";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Personal_btn;
        private System.Windows.Forms.Button AllReport_btn;
        private System.Windows.Forms.Button Skill_btn;
        private System.Windows.Forms.Button Employee_btn;
        private System.Windows.Forms.Button Report_btn;
        private System.Windows.Forms.Button Logout_btn;
    }
}