using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSwitch
{
    public class IpConfig
    {
        public string Name { get; set; } // 配置名称
        public string ConnectionName { get; set; } // 网络连接名称
        public string IpAddress { get; set; } // IP地址
        public string SubnetMask { get; set; } // 子网掩码
        public string Gateway { get; set; } // 网关
        public string Dns1 { get; set; } // DNS1
        public string Dns2 { get; set; } // DNS2
    }
}
