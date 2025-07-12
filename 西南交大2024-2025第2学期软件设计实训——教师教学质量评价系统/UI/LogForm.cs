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
using EvaluationSystem.DAL;
namespace EvaluationSystem.UI
{
    public partial class LogForm : AntdUI.Window
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var authService = new AuthService();
            if (authService.Login(txtUsername.Text, txtPassword.Text))
            {
                // 登录成功后获取用户信息
                using (var context = new UserContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.Username == txtUsername.Text);
                    if (user == null)
                    {
                        MessageBox.Show("用户信息异常！");
                        return;
                    }

                    string charaNo = user.Chara_No;
                    Form mainForm = null;

                    if (charaNo.StartsWith("660"))
                    {
                        mainForm = new TehrMainPage();
                    }
                    else if (charaNo.StartsWith("440"))
                    {
                        mainForm = new StuMainPage();
                    }
                    else if (charaNo.StartsWith("990"))
                    {
                        mainForm = new MtorMainPage();
                    }
                    else if (charaNo.StartsWith("128"))
                    {
                        mainForm = new AdminMainPage();
                    }
                    else
                    {
                        MessageBox.Show("角色识别失败！");
                        return;
                    }

                    //登录后关闭登录窗口，打开主页窗口
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close(); // 关闭登录窗口
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重试！");
                txtUsername.Clear();
                txtPassword.Clear();
            }
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
