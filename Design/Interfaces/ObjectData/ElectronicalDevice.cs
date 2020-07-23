using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Interfaces.ObjectData
{
    public enum DeviceType
    {
        Phone,
        Laptop,
        IPad
    }
    public struct Device
    {
        public DeviceType DeviceType { get; set; }

        public string Id { get; set; }
    }
}
