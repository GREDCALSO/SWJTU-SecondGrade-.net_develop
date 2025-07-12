namespace EvaluationSystem.UI
{
    partial class AdminMainPage
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
            AntdUI.MenuItem menuItem14 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem15 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem16 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem17 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem18 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem19 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem20 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem21 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem22 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem23 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem24 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem25 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem26 = new AntdUI.MenuItem();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.table1 = new AntdUI.Table();
            this.menu1 = new AntdUI.Menu();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pageHeader1
            // 
            this.pageHeader1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageHeader1.Location = new System.Drawing.Point(12, 12);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.Size = new System.Drawing.Size(1428, 59);
            this.pageHeader1.SubText = "管理员";
            this.pageHeader1.TabIndex = 0;
            this.pageHeader1.Text = "主页";
            // 
            // table1
            // 
            this.table1.Location = new System.Drawing.Point(586, 535);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(562, 420);
            this.table1.TabIndex = 1;
            this.table1.Text = "table1";
            // 
            // menu1
            // 
            this.menu1.Indent = true;
            menuItem14.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem15.Text = "查看任务";
            menuItem16.Text = "发布任务";
            menuItem14.Sub.Add(menuItem15);
            menuItem14.Sub.Add(menuItem16);
            menuItem14.Text = "评价任务管理";
            menuItem17.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem18.Text = "全部课程";
            menuItem19.Text = "选课情况";
            menuItem17.Sub.Add(menuItem18);
            menuItem17.Sub.Add(menuItem19);
            menuItem17.Text = "课程管理";
            menuItem20.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem21.Text = "教师";
            menuItem22.Text = "学生";
            menuItem23.Text = "督导组";
            menuItem20.Sub.Add(menuItem21);
            menuItem20.Sub.Add(menuItem22);
            menuItem20.Sub.Add(menuItem23);
            menuItem20.Text = "人员管理";
            menuItem24.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem25.Text = "全部评价详情";
            menuItem26.Text = "教师评分总分";
            menuItem24.Sub.Add(menuItem25);
            menuItem24.Sub.Add(menuItem26);
            menuItem24.Text = "教学质量评价详情";
            this.menu1.Items.Add(menuItem14);
            this.menu1.Items.Add(menuItem17);
            this.menu1.Items.Add(menuItem20);
            this.menu1.Items.Add(menuItem24);
            this.menu1.Location = new System.Drawing.Point(12, 100);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(341, 911);
            this.menu1.TabIndex = 3;
            this.menu1.Text = "menu1";
            this.menu1.SelectChanged += new AntdUI.SelectEventHandler(this.menu1_SelectChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "显示1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "显示2";
            // 
            // AdminMainPage
            // 
            this.AutoHandDpi = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 1023);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.pageHeader1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Table table1;
        private AntdUI.Menu menu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}