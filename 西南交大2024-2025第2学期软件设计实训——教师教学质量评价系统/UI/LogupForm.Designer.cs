namespace EvaluationSystem.UI
{
    partial class LogupForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdobtnAdmin = new System.Windows.Forms.RadioButton();
            this.rdobtnDDZ = new System.Windows.Forms.RadioButton();
            this.rdobtnTec = new System.Windows.Forms.RadioButton();
            this.rdobtnStu = new System.Windows.Forms.RadioButton();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.txtUsername1 = new AntdUI.Input();
            this.lblUsername1 = new AntdUI.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPassword1 = new AntdUI.Label();
            this.txtPassword1 = new AntdUI.Input();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPassword2 = new AntdUI.Label();
            this.txtPassword2 = new AntdUI.Input();
            this.lblCharaNo = new AntdUI.Label();
            this.txtCharaNo = new AntdUI.Input();
            this.btnLogUp = new AntdUI.Button();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCharaName = new AntdUI.Input();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCollege = new System.Windows.Forms.Label();
            this.selColleges = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdobtnAdmin);
            this.panel1.Controls.Add(this.rdobtnDDZ);
            this.panel1.Controls.Add(this.rdobtnTec);
            this.panel1.Controls.Add(this.rdobtnStu);
            this.panel1.Controls.Add(this.lblCharacter);
            this.panel1.Location = new System.Drawing.Point(12, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 282);
            this.panel1.TabIndex = 2;
            // 
            // rdobtnAdmin
            // 
            this.rdobtnAdmin.AutoSize = true;
            this.rdobtnAdmin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdobtnAdmin.Location = new System.Drawing.Point(391, 205);
            this.rdobtnAdmin.Name = "rdobtnAdmin";
            this.rdobtnAdmin.Size = new System.Drawing.Size(159, 35);
            this.rdobtnAdmin.TabIndex = 6;
            this.rdobtnAdmin.Text = "学院管理员";
            this.rdobtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rdobtnDDZ
            // 
            this.rdobtnDDZ.AutoSize = true;
            this.rdobtnDDZ.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdobtnDDZ.Location = new System.Drawing.Point(391, 150);
            this.rdobtnDDZ.Name = "rdobtnDDZ";
            this.rdobtnDDZ.Size = new System.Drawing.Size(111, 35);
            this.rdobtnDDZ.TabIndex = 5;
            this.rdobtnDDZ.Text = "督导组";
            this.rdobtnDDZ.UseVisualStyleBackColor = true;
            // 
            // rdobtnTec
            // 
            this.rdobtnTec.AutoSize = true;
            this.rdobtnTec.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdobtnTec.Location = new System.Drawing.Point(391, 90);
            this.rdobtnTec.Name = "rdobtnTec";
            this.rdobtnTec.Size = new System.Drawing.Size(87, 35);
            this.rdobtnTec.TabIndex = 4;
            this.rdobtnTec.Text = "教师";
            this.rdobtnTec.UseVisualStyleBackColor = true;
            // 
            // rdobtnStu
            // 
            this.rdobtnStu.AutoSize = true;
            this.rdobtnStu.Checked = true;
            this.rdobtnStu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdobtnStu.Location = new System.Drawing.Point(391, 39);
            this.rdobtnStu.Name = "rdobtnStu";
            this.rdobtnStu.Size = new System.Drawing.Size(87, 35);
            this.rdobtnStu.TabIndex = 3;
            this.rdobtnStu.TabStop = true;
            this.rdobtnStu.Text = "学生";
            this.rdobtnStu.UseVisualStyleBackColor = true;
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCharacter.Location = new System.Drawing.Point(179, 117);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(146, 41);
            this.lblCharacter.TabIndex = 1;
            this.lblCharacter.Text = "选择角色";
            // 
            // txtUsername1
            // 
            this.txtUsername1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUsername1.Location = new System.Drawing.Point(256, 12);
            this.txtUsername1.Name = "txtUsername1";
            this.txtUsername1.PlaceholderText = "输入用户名";
            this.txtUsername1.Size = new System.Drawing.Size(248, 82);
            this.txtUsername1.TabIndex = 3;
            // 
            // lblUsername1
            // 
            this.lblUsername1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUsername1.Location = new System.Drawing.Point(53, 26);
            this.lblUsername1.Name = "lblUsername1";
            this.lblUsername1.Size = new System.Drawing.Size(120, 54);
            this.lblUsername1.TabIndex = 7;
            this.lblUsername1.Text = "用户名";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsername1);
            this.panel2.Controls.Add(this.txtUsername1);
            this.panel2.Location = new System.Drawing.Point(842, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 108);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPassword1);
            this.panel3.Controls.Add(this.txtPassword1);
            this.panel3.Location = new System.Drawing.Point(842, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 108);
            this.panel3.TabIndex = 12;
            // 
            // lblPassword1
            // 
            this.lblPassword1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword1.Location = new System.Drawing.Point(53, 26);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(120, 54);
            this.lblPassword1.TabIndex = 7;
            this.lblPassword1.Text = "密码";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword1.Location = new System.Drawing.Point(256, 12);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.PlaceholderText = "输入密码";
            this.txtPassword1.Size = new System.Drawing.Size(248, 82);
            this.txtPassword1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPassword2);
            this.panel4.Controls.Add(this.txtPassword2);
            this.panel4.Location = new System.Drawing.Point(842, 487);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 108);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblPassword2
            // 
            this.lblPassword2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword2.Location = new System.Drawing.Point(53, 26);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(120, 54);
            this.lblPassword2.TabIndex = 7;
            this.lblPassword2.Text = "确认密码";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword2.Location = new System.Drawing.Point(256, 13);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.PlaceholderText = "再次输入密码";
            this.txtPassword2.Size = new System.Drawing.Size(248, 82);
            this.txtPassword2.TabIndex = 3;
            // 
            // lblCharaNo
            // 
            this.lblCharaNo.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCharaNo.Location = new System.Drawing.Point(179, 155);
            this.lblCharaNo.Name = "lblCharaNo";
            this.lblCharaNo.Size = new System.Drawing.Size(120, 54);
            this.lblCharaNo.TabIndex = 7;
            this.lblCharaNo.Text = "角色编号";
            // 
            // txtCharaNo
            // 
            this.txtCharaNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCharaNo.Location = new System.Drawing.Point(321, 143);
            this.txtCharaNo.Name = "txtCharaNo";
            this.txtCharaNo.PlaceholderText = "输入学号，工号或组号";
            this.txtCharaNo.Size = new System.Drawing.Size(291, 82);
            this.txtCharaNo.TabIndex = 3;
            // 
            // btnLogUp
            // 
            this.btnLogUp.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnLogUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(107)))), ((int)(((byte)(219)))));
            this.btnLogUp.BackExtend = "blue";
            this.btnLogUp.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnLogUp.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogUp.Location = new System.Drawing.Point(945, 690);
            this.btnLogUp.Name = "btnLogUp";
            this.btnLogUp.Size = new System.Drawing.Size(346, 126);
            this.btnLogUp.TabIndex = 14;
            this.btnLogUp.Text = "注册";
            this.btnLogUp.Click += new System.EventHandler(this.btnLogUp_Click);
            // 
            // pageHeader1
            // 
            this.pageHeader1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageHeader1.Location = new System.Drawing.Point(12, 8);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.Size = new System.Drawing.Size(1409, 53);
            this.pageHeader1.TabIndex = 15;
            this.pageHeader1.Text = "注册";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.selColleges);
            this.panel6.Controls.Add(this.lblCollege);
            this.panel6.Controls.Add(this.txtCharaNo);
            this.panel6.Controls.Add(this.lblCharaNo);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtCharaName);
            this.panel6.Location = new System.Drawing.Point(82, 487);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(666, 410);
            this.panel6.TabIndex = 16;
            // 
            // txtCharaName
            // 
            this.txtCharaName.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCharaName.Location = new System.Drawing.Point(321, 26);
            this.txtCharaName.Name = "txtCharaName";
            this.txtCharaName.PlaceholderText = "输入姓名或组名";
            this.txtCharaName.Size = new System.Drawing.Size(291, 82);
            this.txtCharaName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(198, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "角色名";
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCollege.Location = new System.Drawing.Point(109, 272);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(73, 37);
            this.lblCollege.TabIndex = 9;
            this.lblCollege.Text = "学院";
            // 
            // selColleges
            // 
            this.selColleges.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selColleges.FormattingEnabled = true;
            this.selColleges.Location = new System.Drawing.Point(205, 270);
            this.selColleges.Name = "selColleges";
            this.selColleges.Size = new System.Drawing.Size(430, 44);
            this.selColleges.TabIndex = 17;
            // 
            // LogupForm
            // 
            this.AutoHandDpi = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1433, 1003);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.btnLogUp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogupForm";
            this.Text = "LogupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.RadioButton rdobtnAdmin;
        private System.Windows.Forms.RadioButton rdobtnDDZ;
        private System.Windows.Forms.RadioButton rdobtnTec;
        private System.Windows.Forms.RadioButton rdobtnStu;
        private AntdUI.Input txtUsername1;
        private AntdUI.Label lblUsername1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AntdUI.Label lblPassword1;
        private AntdUI.Input txtPassword1;
        private System.Windows.Forms.Panel panel4;
        private AntdUI.Label lblPassword2;
        private AntdUI.Input txtPassword2;
        private AntdUI.Label lblCharaNo;
        private AntdUI.Input txtCharaNo;
        private AntdUI.Button btnLogUp;
        private AntdUI.PageHeader pageHeader1;
        private System.Windows.Forms.Panel panel6;
        private AntdUI.Input txtCharaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.ComboBox selColleges;
    }
}