using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CS11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // await DownloadHtmlAsync("https://docs.microsoft.com/en-us/");

            var result =await GetHtmlAsync("https://docs.microsoft.com/en-us/");
            MessageBox.Show(result.Substring(0, 30));
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webclient = new WebClient();
            return await webclient.DownloadStringTaskAsync(url);
        }

        public string GetHtml(string url)
        {
            var webclient = new WebClient();
            return webclient.DownloadString(url);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html =await webClient.DownloadStringTaskAsync(url);
            using (var streamWriter = new StreamWriter(@"G:\2.html"))
            {
               await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var streamWriter = new StreamWriter(@"G:\2.html")) 
            {
                streamWriter.Write(html);
            }
        }
    }
}
