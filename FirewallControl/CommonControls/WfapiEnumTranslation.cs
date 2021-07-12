using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;

namespace FirewallControl.CommonControls
{
    public static class WfapiEnumTranslation
    {

        public static string TranslateDirection(NET_FW_RULE_DIRECTION_ Direction)
        {

            if (Direction == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN)
            {
                return "Inbound";
            }
            else 
            {
                return "Outbound";
            }
        }

        public static string TranslateAction(NET_FW_ACTION_ Action)
        {

            if (Action == NET_FW_ACTION_.NET_FW_ACTION_ALLOW)
            {
                return "Allowed";
            }
            else
            {
                return "Blocked";
            }
        }

    }
}
