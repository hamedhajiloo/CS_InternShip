using System;
using System.Collections.Generic;
using System.Text;

namespace Event_MemoryLeak
{
    public class MyClass: IDisposable
    {
        private readonly WiFiManager _wiFiManager;

        public MyClass(WiFiManager wiFiManager)
        {
            _wiFiManager = wiFiManager;
            _wiFiManager.WiFiSignalChanged += OnWiFiChanged;
        }

        public void Dispose()
        {
            _wiFiManager.WiFiSignalChanged -= OnWiFiChanged;
        }

        private void OnWiFiChanged(object sender, WifiEventArgs e)
        {
            // do something
        }


        public void SomeOperation(WiFiManager wiFiManager)
        {
            var myClass = new MyClass(wiFiManager);
            myClass.DoSomething();

            //... myClass is not used again
        }
    }
}
