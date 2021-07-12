using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirewallControl.Structs
{

    public struct RuleInfo
    {
        public string ruleName;
        public string ports;
        public int protocol;
        public int direction;
        public int action;

    }
}
