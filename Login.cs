using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateUser(textBox1.Text, textBox2.Text))
            {
                // 打开主窗体
                Form1 mainForm = new Form1();

                this.Hide();
                mainForm.ShowDialog();

                // 关闭登录窗体
                this.Close();
                               
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重试。");
            }
            
        }


        private bool ValidateUser(string username, string password)
        {
            // 在这里编写验证用户名和密码的逻辑
            // 返回 true 或 false，表示验证是否成功
            // 这里只是一个示例，您需要根据实际情况进行验证
            return (username == "admin" && password == "123456");
        }
    }
}
