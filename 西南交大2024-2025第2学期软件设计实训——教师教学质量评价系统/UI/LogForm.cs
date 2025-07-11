using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSystem.BLL;
using 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统;

namespace EvaluationSystem.UI
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var authService = new AuthService(); // BLL服务
            if (authService.Login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("登录成功！");
                StudentPage studentPage = new StudentPage();
                studentPage.Show();
                this.Hide();
                studentPage.FormClosed += (s, args) => this.Close();
            }
            else
                MessageBox.Show("用户名或密码错误！");
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
         
       
    }
}
