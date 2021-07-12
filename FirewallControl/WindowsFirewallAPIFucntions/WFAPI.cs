using System;
using System.ComponentModel;
using NetFwTypeLib;

namespace FirewallControl.WindowsFirewallAPIFucntions
{
    public static class WFAPI
    {

        public static BindingList<string> GetAllRules()
        {
            BindingList<string> RulesFound = new BindingList<string>();
            INetFwPolicy2 inetPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            foreach (INetFwRule rule in inetPolicy.Rules)
            {
               RulesFound.Add(rule.Name.ToString());
            }

            return RulesFound;
        }

        public static INetFwRule GetRuleDetails(string _ruleName)
        {

            INetFwRule RuleFound = null;

            INetFwPolicy2 inetPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            foreach (INetFwRule rule in inetPolicy.Rules)
            {
                if (rule.Name == _ruleName)
                {
                    RuleFound = rule;
                }
            }

            return RuleFound;
        }


        public static bool AddRule(string NAME, bool ENABLED, int PROTOCOL, NET_FW_RULE_DIRECTION_ DIRECTION, NET_FW_ACTION_ ACTION, string DESCRIPTION = "NA", string REMOTE_PORTS = "NA", string LOCAL_PORTS = "NA",  string APP_PATH= "NA" )
        {

            INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            if (REMOTE_PORTS == "NA" && LOCAL_PORTS == "NA")
            {
                firewallRule.ApplicationName = APP_PATH;
                firewallRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY;
            }
            else if (APP_PATH == "NA" && LOCAL_PORTS == "NA")
            {
                firewallRule.Protocol = PROTOCOL;
                firewallRule.RemotePorts = REMOTE_PORTS;
                
            }
            else if (APP_PATH == "NA" && REMOTE_PORTS == "NA")
            {
                firewallRule.Protocol = PROTOCOL;
                firewallRule.LocalPorts = LOCAL_PORTS;
            }

            firewallRule.Name = NAME;
            firewallRule.Enabled = ENABLED;
            firewallRule.Description = DESCRIPTION;
            firewallRule.Direction = DIRECTION;
            firewallRule.Action = ACTION;

            try
            {
                firewallPolicy.Rules.Add(firewallRule);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static void DeleteRule(string RULE_NAME)
        {

            //INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            foreach (INetFwRule rule in firewallPolicy.Rules)
            {
                if (rule.Name == RULE_NAME)
                {
                    firewallPolicy.Rules.Remove(rule.Name);
                }
            }
        
        }


        public static BindingList<string>  GetBlockedRules()
        {
            BindingList<string> ReturnList = new BindingList<string>();


                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                foreach (INetFwRule rule in firewallPolicy.Rules)
                {
                    if (rule.Action == NET_FW_ACTION_.NET_FW_ACTION_BLOCK )
                    {
                    ReturnList.Add(rule.Name);
                    }
                }

            return ReturnList;
        }

        public static BindingList<string> GetAllowedRules()
        {
            BindingList<string> ReturnList = new BindingList<string>();


            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            foreach (INetFwRule rule in firewallPolicy.Rules)
            {
                if (rule.Action == NET_FW_ACTION_.NET_FW_ACTION_ALLOW)
                {
                    ReturnList.Add(rule.Name);
                }
            }

            return ReturnList;
        }


    }
}
