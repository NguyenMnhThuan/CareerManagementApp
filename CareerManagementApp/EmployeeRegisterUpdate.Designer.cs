namespace CareerManagementApp
{
    partial class EmployeeRegisterUpdate
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
            this.EmployeeID_tb = new System.Windows.Forms.TextBox();
            this.Email_tb = new System.Windows.Forms.TextBox();
            this.Authority_cb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "社員情報登録";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeID_tb
            // 
            this.EmployeeID_tb.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.EmployeeID_tb.Location = new System.Drawing.Point(60, 38);
            this.EmployeeID_tb.Name = "EmployeeID_tb";
            this.EmployeeID_tb.Size = new System.Drawing.Size(290, 31);
            this.EmployeeID_tb.TabIndex = 1;
            // 
            // Email_tb
            // 
            this.Email_tb.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.Email_tb.Location = new System.Drawing.Point(60, 208);
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.Size = new System.Drawing.Size(290, 31);
            this.Email_tb.TabIndex = 4;
            // 
            // Authority_cb
            // 
            this.Authority_cb.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.Authority_cb.FormattingEnabled = true;
            this.Authority_cb.Items.AddRange(new object[] {
            "管理者",
            "一般"});
            this.Authority_cb.Location = new System.Drawing.Point(60, 151);
            this.Authority_cb.Name = "Authority_cb";
            this.Authority_cb.Size = new System.Drawing.Size(108, 32);
            this.Authority_cb.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Password_tb);
            this.panel1.Controls.Add(this.EmployeeID_tb);
            this.panel1.Controls.Add(this.Authority_cb);
            this.panel1.Controls.Add(this.Email_tb);
            this.panel1.Location = new System.Drawing.Point(186, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 272);
            this.panel1.TabIndex = 0;
            // 
            // Password_tb
            // 
            this.Password_tb.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.Password_tb.Location = new System.Drawing.Point(60, 97);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(290, 31);
            this.Password_tb.TabIndex = 2;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Back_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Back_btn.Location = new System.Drawing.Point(666, 9);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(106, 34);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "戻る";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // OK_btn
            // 
            this.OK_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.OK_btn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OK_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OK_btn.Location = new System.Drawing.Point(320, 347);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(137, 38);
            this.OK_btn.TabIndex = 5;
            this.OK_btn.Text = "登録・編集";
            this.OK_btn.UseVisualStyleBackColor = false;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // EmployeeRegisterUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "EmployeeRegisterUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社員情報登録・編集";
            this.Load += new System.EventHandler(this.EmployeeRegisterUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeID_tb;
        private System.Windows.Forms.TextBox Email_tb;
        private System.Windows.Forms.ComboBox Authority_cb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button OK_btn;
    }
}