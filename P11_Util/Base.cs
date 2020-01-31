using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P11_Util
{
    public static class Base
    {
        public static string TestNoneAsync()
        {
            var webClient = new WebClient();
            return webClient.DownloadString("http://www.google.com");
        }
        public static void TestAsync( DownloadStringCompletedEventHandler eventHandler)
        {
            var webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri("http://www.google.com"));
            webClient.DownloadStringCompleted += eventHandler;
        }



    }
}
