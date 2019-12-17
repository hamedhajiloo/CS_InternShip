using System;
using System.Collections.Generic;
using System.Text;

namespace Event_MemoryLeak
{
    public class WiFiManager
    {
        public event EventHandler<WifiEventArgs> WiFiSignalChanged;
        // ...
    }
}
