namespace EvaluationSystem.UI
{
    partial class TehrMainPage
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
            AntdUI.MenuItem menuItem19 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem20 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem21 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem22 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem23 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem24 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem25 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem26 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem27 = new AntdUI.MenuItem();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.menu1 = new AntdUI.Menu();
            this.SuspendLayout();
            // 
            // pageHeader1
            // 
            this.pageHeader1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageHeader1.Location = new System.Drawing.Point(12, 12);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.Size = new System.Drawing.Size(1496, 61);
            this.pageHeader1.SubText = "教师";
            this.pageHeader1.TabIndex = 0;
            this.pageHeader1.Text = "主页";
            // 
            // menu1
            // 
            menuItem19.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem20.Text = "待评价";
            menuItem21.Text = "已评价";
            menuItem19.Sub.Add(menuItem20);
            menuItem19.Sub.Add(menuItem21);
            menuItem19.Text = "评价任务";
            menuItem22.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem23.Text = "获得的评价详情";
            menuItem24.Text = "评级总分详情";
            menuItem25.Text = "综合报告";
            menuItem22.Sub.Add(menuItem23);
            menuItem22.Sub.Add(menuItem24);
            menuItem22.Sub.Add(menuItem25);
            menuItem22.Text = "我的评级";
            menuItem26.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem27.Text = "课程详情";
            menuItem26.Sub.Add(menuItem27);
            menuItem26.Text = "执教课程";
            this.menu1.Items.Add(menuItem19);
            this.menu1.Items.Add(menuItem22);
            this.menu1.Items.Add(menuItem26);
            this.menu1.Location = new System.Drawing.Point(13, 100);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(428, 914);
            this.menu1.TabIndex = 1;
            this.menu1.Text = "menu1";
            // 
            // TehrMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 1026);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.pageHeader1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TehrMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TehrMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Menu menu1;
    }
}