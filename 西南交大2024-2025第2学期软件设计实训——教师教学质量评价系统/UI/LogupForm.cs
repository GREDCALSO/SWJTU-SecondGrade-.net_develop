using EvaluationSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSystem.UI
{
    public partial class LogupForm : Form
    {
        public LogupForm()
        {
            InitializeComponent();
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
            if (authService.Register(txtUsername1.Text, txtPassword2.Text, characterNumber))
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
