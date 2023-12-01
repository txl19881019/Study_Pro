using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private readonly HttpClient httpClient;
        public Login()
        {
            InitializeComponent();
            /*Icon icon = new Icon("path/to/your/icon.ico");

            // 将图标分配给窗口的Icon属性
            this.Icon = icon;*/
            Trace.Listeners.Add(new ConsoleTraceListener()); // 输出到控制台
            // 创建HttpClient实例
            httpClient = new HttpClient();

            checkNet();
        }


        private async void checkNet()
        {

            Trace.WriteLine("Start checkNet");
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(Config.checkversion);
                response.EnsureSuccessStatusCode(); // 确保请求成功

                string responseBody = await response.Content.ReadAsStringAsync();
                Version version = JsonConvert.DeserializeObject<Version>(responseBody);
                Trace.WriteLine(version.version);
                Trace.WriteLine(version.code);
                Trace.WriteLine(version.message);
                Trace.WriteLine(version.url);

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"请求失败: {ex.Message}", "Error");
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            login_success();

            /*if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空");
                return;

            }
            string jsonContent = "{\"username\":\"" + textBox1.Text + "\",\"password\":\"" + textBox2.Text + "\"}";
            // 创建HttpContent对象
            HttpContent httpContent = new StringContent(jsonContent);

            // 设置请求头部信息（可选）
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await httpClient.PostAsync(Config.loginUrl, httpContent);
            response.EnsureSuccessStatusCode(); // 确保请求成功
            string responseBody = await response.Content.ReadAsStringAsync();
            HttpResponse<string> http = JsonConvert.DeserializeObject<HttpResponse<string>>(responseBody);
            Trace.WriteLine(http.Code);
            if (http.Code == 1)
            {
                login_success();

            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重试。");
            }*/

        }

        // 注册用户
        private void register(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private void login_success()
        {
            // 打开主窗体
            Form1 mainForm = new Form1();

            this.Hide();
            mainForm.ShowDialog();

            // 关闭登录窗体
            this.Close();
        }
    }
}
