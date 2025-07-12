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
    public partial class AdminMainPage : AntdUI.Window
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            // 修复错误：使用 e.Value 代替 e.SelectedItem
            var selectedItem = e.Value; // MenuSelectEventArgs 的 Value 属性返回 MenuItem 类型
            if (selectedItem == null)
            {
                MessageBox.Show("未选择任何菜单项，请重试。");
                return;
            }

            // 根据菜单选择项加载不同的内容
            switch (selectedItem.Text)
            {
                case "查看任务":
                    // 加载已评价内容
                    label1.Show();
                    label2.Hide();
                    //LoadEvaluatedTasks();
                    break;
                case "发布任务":
                    // 加载待评价内容
                    label1.Hide();
                    label2.Show();
                    //LoadPendingTasks();
                    break;
                default:
                    MessageBox.Show("未知菜单项，请联系管理员。");
                    break;
            }
        }
    }
}
