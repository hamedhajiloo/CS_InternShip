using P11_Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //var result = Base.TestNoneAsync();
            //headerListTextBox.Text = result;
            Base.TestAsync(webClientDownloadStringCompleted);


        }

        void webClientDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            headerListTextBox.Text = e.Result;
        }

        private async void FetchAndShowHeaders(string url)
        {
            using (var w = new HttpClient())
            {
                var req = new HttpRequestMessage(HttpMethod.Head, url);
                HttpResponseMessage response =
                await w.SendAsync(req, HttpCompletionOption.ResponseHeadersRead);
                var headerStrings =
                from header in response.Headers
                select header.Key + ": " + string.Join(",", header.Value);
                string headerList = string.Join(Environment.NewLine, headerStrings);
                headerListTextBox.Text = headerList;
            }
        }

        private void OldSchoolFetchHeaders(string url)
        {
            var w = new HttpClient();
            var req = new HttpRequestMessage(HttpMethod.Head, url);
            var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            w.SendAsync(req, HttpCompletionOption.ResponseHeadersRead)
            .ContinueWith(sendTask =>
            {
                try
                {
                    HttpResponseMessage response = sendTask.Result;
                    var headerStrings =
                    from header in response.Headers
                    select header.Key + ": " + string.Join(",", header.Value);
                    string headerList =
                    string.Join(Environment.NewLine, headerStrings);
                    headerListTextBox.Text = headerList;
                }
                finally
                {
                    w.Dispose();
                }
            },uiScheduler);
        }
    }
}
