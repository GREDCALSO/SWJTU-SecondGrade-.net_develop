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
                MessageBox.Show("登录成功！");
            else
                MessageBox.Show("用户名或密码错误！");
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var formRegister = new LogupForm();
            //formRegister.Owner = this;
            formRegister.ShowDialog();
        }
    }
}
