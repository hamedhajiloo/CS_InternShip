using System;
using System.Collections.Generic;
using System.Text;

namespace P8
{
    public class DeviceNotReadyException : InvalidOperationException
    {
        public DeviceNotReadyException(DeviceStatus status)
        : this("Device must be in Ready state", status)
        {
        }
        public DeviceNotReadyException(string message, DeviceStatus status)
        : base(message)
        {
            Status = status;
        }
        public DeviceNotReadyException(string message, DeviceStatus status,
        Exception innerException)
        : base(message, innerException)
        {
            Status = status;
        }
        public DeviceStatus Status { get; private set; }
    }
    public enum DeviceStatus
    {
        Disconnected,
        Initializing,
        Failed,
        Ready
    }
}
