using EvaluationSystem.BLL;
using EvaluationSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSystem.UI
{
    public partial class LogupForm : AntdUI.Window
    {
        private string selectedCollegeNo;

        public LogupForm()
        {
            InitializeComponent();
            LoadColleges();
            // Initialize selectedCollegeNo after selColleges is populated
            selColleges.SelectedIndexChanged += SelColleges_SelectedIndexChanged;
        }

        private void SelColleges_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update selectedCollegeNo when the selection changes
            selectedCollegeNo = selColleges.SelectedValue?.ToString();
        }

        private void LoadColleges()
        {
            using (var context = new CollegeContext())
            {
                var colleges = context.Colleges
                    .Where(c => c.is_deleted == 0)
                    .Select(c => new { c.College_No, c.Name })
                    .ToList();

                selColleges.DataSource = colleges;
                selColleges.DisplayMember = "Name";      // 显示学院名称
                selColleges.ValueMember = "College_No";  // 选中项的值为学院编号
                // 初始化默认学院编号
                if (colleges.Count > 0)
                    selectedCollegeNo = colleges[0].College_No;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLogUp_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text != txtPassword2.Text)
            {
                MessageBox.Show("两次密码输入不一致！请重新输入");
                txtPassword1.Clear();
                txtPassword2.Clear();
                return;
            }
            if (string.IsNullOrEmpty(selectedCollegeNo))
            {
                MessageBox.Show("请选择学院！");
                return;
            }
            // 用中间变量存储角色编号，根据radiobtn的选择情况，在前面加上区分前缀
            var characterNumber = "000";
            if (rdobtnStu.Checked)
            {
                characterNumber = "440" + txtCharaNo.Text;
            }
            else if (rdobtnTec.Checked)
            {
                characterNumber = "660" + txtCharaNo.Text;
            }
            else if (rdobtnDDZ.Checked)
            {
                characterNumber = "990" + txtCharaNo.Text;
            }
            else if (rdobtnAdmin.Checked)
            {
                characterNumber = "128" + txtCharaNo.Text;
            }
            else
            {
                MessageBox.Show("请选择角色");
            }
            
            
            var authService = new AuthService();
            if (authService.Register(txtUsername1.Text, txtPassword2.Text, characterNumber, txtCharaName.Text, selectedCollegeNo))
            {
                MessageBox.Show("注册成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }
    }
}
