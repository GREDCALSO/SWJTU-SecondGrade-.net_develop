using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统
{
    public partial class StudentPage : Form
    {
        private PendingEvaluationControl pendingControl;
        private CompletedEvaluationControl completedControl;

        public StudentPage()
        {
            InitializeComponent(); // 这里已经初始化了所有控件
        }

        private void studentpage_Load(object sender, EventArgs e)
        {
            // 确保 splitContainer2 和 contentPanel1 已正确初始化
            if (splitContainer2 == null || contentPanel1 == null)
            {
                throw new Exception("控件未正确初始化！");
            }

            // 确保 contentPanel1 已添加到 splitContainer2.Panel2
            if (!splitContainer2.Panel2.Controls.Contains(contentPanel1))
            {
                contentPanel1.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(contentPanel1);
            }

            // 初始化 TreeView
            tVStudentFunc.Nodes.Add("待评价");
            tVStudentFunc.Nodes.Add("已评价");
            tVStudentFunc.ExpandAll();

            // 默认选中第一个节点
            if (tVStudentFunc.Nodes.Count > 0)
            {
                tVStudentFunc.SelectedNode = tVStudentFunc.Nodes[0];
            }

            // 初始化 pendingControl 和 completedControl
            pendingControl = new PendingEvaluationControl();
            completedControl = new CompletedEvaluationControl();

            // 默认显示待评价
            ShowPendingEvaluation();

            // 绑定事件
            tVStudentFunc.AfterSelect += tVStudentFunc_AfterSelect;
        }

        private void ShowPendingEvaluation()
        {
            if (pendingControl == null)
            {
                pendingControl = new PendingEvaluationControl(); // 确保不为 null
            }

            contentPanel1.Controls.Clear();
            pendingControl.Dock = DockStyle.Fill;
            contentPanel1.Controls.Add(pendingControl);
        }

        private void ShowCompletedEvaluation()
        {
            if (completedControl == null)
            {
                completedControl = new CompletedEvaluationControl(); // 确保不为 null
            }

            contentPanel1.Controls.Clear();
            completedControl.Dock = DockStyle.Fill;
            contentPanel1.Controls.Add(completedControl);
        }

        private void tVStudentFunc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "待评价")
            {
                ShowPendingEvaluation();
            }
            else if (e.Node.Text == "已评价")
            {
                ShowCompletedEvaluation();
            }
        }

        
    }
}

       
    
