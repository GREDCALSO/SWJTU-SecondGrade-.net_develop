namespace 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统
{
    partial class StudentPage
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tVStudentFunc = new System.Windows.Forms.TreeView();
            this.contentPanel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tVStudentFunc);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.contentPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(995, 661);
            this.splitContainer2.SplitterDistance = 292;
            this.splitContainer2.TabIndex = 0;
            // 
            // tVStudentFunc
            // 
            this.tVStudentFunc.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tVStudentFunc.Location = new System.Drawing.Point(3, 0);
            this.tVStudentFunc.Name = "tVStudentFunc";
            this.tVStudentFunc.Size = new System.Drawing.Size(286, 658);
            this.tVStudentFunc.TabIndex = 0;
            this.tVStudentFunc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVStudentFunc_AfterSelect);
            // 
            // contentPanel1
            // 
            this.contentPanel1.Location = new System.Drawing.Point(-1, 0);
            this.contentPanel1.Name = "contentPanel1";
            this.contentPanel1.Size = new System.Drawing.Size(700, 658);
            this.contentPanel1.TabIndex = 0;
            // 
            // StudentPage
            // 
            this.ClientSize = new System.Drawing.Size(995, 661);
            this.Controls.Add(this.splitContainer2);
            this.Name = "StudentPage";
            this.Text = "学生页面";
            this.Load += new System.EventHandler(this.studentpage_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tVStudentFunction;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tVStudentFunc;
        private System.Windows.Forms.Panel contentPanel1;
    }
}