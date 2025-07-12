namespace EvaluationSystem.UI
{
    partial class StuMainPage
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
            AntdUI.MenuItem menuItem11 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem12 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem13 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem14 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem15 = new AntdUI.MenuItem();
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
            this.pageHeader1.Size = new System.Drawing.Size(1511, 61);
            this.pageHeader1.SubText = "学生";
            this.pageHeader1.TabIndex = 0;
            this.pageHeader1.Text = "主页";
            // 
            // menu1
            // 
            menuItem11.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem12.Text = "待评级";
            menuItem13.Text = "已评价";
            menuItem11.Sub.Add(menuItem12);
            menuItem11.Sub.Add(menuItem13);
            menuItem11.Text = "评价任务";
            menuItem14.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem15.Text = "已选课程";
            menuItem14.Sub.Add(menuItem15);
            menuItem14.Text = "选课详情";
            this.menu1.Items.Add(menuItem11);
            this.menu1.Items.Add(menuItem14);
            this.menu1.Location = new System.Drawing.Point(13, 111);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(399, 796);
            this.menu1.TabIndex = 1;
            this.menu1.Text = "menu1";
            // 
            // StuMainPage
            // 
            this.AutoHandDpi = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 919);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.pageHeader1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StuMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StuMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Menu menu1;
    }
}