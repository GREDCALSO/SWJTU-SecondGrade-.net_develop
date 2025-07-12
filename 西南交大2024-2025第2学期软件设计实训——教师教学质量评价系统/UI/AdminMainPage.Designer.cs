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
            AntdUI.MenuItem menuItem40 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem41 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem42 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem43 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem44 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem45 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem46 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem47 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem48 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem49 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem50 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem51 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem52 = new AntdUI.MenuItem();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.table1 = new AntdUI.Table();
            this.menu1 = new AntdUI.Menu();
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
            this.table1.Location = new System.Drawing.Point(698, 266);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(562, 420);
            this.table1.TabIndex = 1;
            this.table1.Text = "table1";
            // 
            // menu1
            // 
            this.menu1.Indent = true;
            menuItem40.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem41.Text = "查看任务";
            menuItem42.Text = "发布任务";
            menuItem40.Sub.Add(menuItem41);
            menuItem40.Sub.Add(menuItem42);
            menuItem40.Text = "评价任务管理";
            menuItem43.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem44.Text = "全部课程";
            menuItem45.Text = "选课情况";
            menuItem43.Sub.Add(menuItem44);
            menuItem43.Sub.Add(menuItem45);
            menuItem43.Text = "课程管理";
            menuItem46.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem47.Text = "教师";
            menuItem48.Text = "学生";
            menuItem49.Text = "督导组";
            menuItem46.Sub.Add(menuItem47);
            menuItem46.Sub.Add(menuItem48);
            menuItem46.Sub.Add(menuItem49);
            menuItem46.Text = "人员管理";
            menuItem50.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem51.Text = "全部评价详情";
            menuItem52.Text = "教师评分总分";
            menuItem50.Sub.Add(menuItem51);
            menuItem50.Sub.Add(menuItem52);
            menuItem50.Text = "教学质量评价详情";
            this.menu1.Items.Add(menuItem40);
            this.menu1.Items.Add(menuItem43);
            this.menu1.Items.Add(menuItem46);
            this.menu1.Items.Add(menuItem50);
            this.menu1.Location = new System.Drawing.Point(12, 100);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(341, 911);
            this.menu1.TabIndex = 3;
            this.menu1.Text = "menu1";
            // 
            // AdminMainPage
            // 
            this.AutoHandDpi = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 1023);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.pageHeader1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Table table1;
        private AntdUI.Menu menu1;
    }
}