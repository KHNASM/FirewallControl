using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using FirewallControl.Structs;


namespace FirewallControl.FirewallMethods
{
    public static class FirewallRules
    {

       
        
        public static void BlockRemotePort(string NAME, string PORT, string PROTOCOL, string DIRECTION, string ACTION, string ENABLE, string DOMAIN)
        {
            Process p = new Process();
            string Output = string.Empty;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C netsh.exe advfirewall firewall add rule name=" + NAME + 
                                     " remoteport=" + PORT + 
                                     " dir=" + DIRECTION +
                                     " protocol=" + PROTOCOL +
                                     " enable =" + ENABLE +
                                     " action=" + ACTION +
                                     " profile=" + DOMAIN;

            p.Start();
           // Output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

           // return Output;
        }




        public static RuleInfo GetRuleInformation(string RuleName)
        {

            RuleInfo info = new RuleInfo();

            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            dynamic fwPolicy2 = Activator.CreateInstance(tNetFwPolicy2) as dynamic;
            IEnumerable Rules = fwPolicy2.Rules as IEnumerable;
            foreach (dynamic rule in Rules)
            {
                if (rule.Name == RuleName)
                {

                    info.ruleName = rule.Name;
                    info.ports = rule.RemotePorts;
                    info.protocol = rule.Protocol;
                    info.direction = rule.Direction;
                    info.action = rule.Action;

                }
            }

            return info;
        }


        public static BindingList<string> ListBlockedRules()
        {

            BindingList<string> ruleList = new BindingList<string>();

            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            var fwPolicy2 = Activator.CreateInstance(tNetFwPolicy2) as dynamic;
            IEnumerable Rules = fwPolicy2.Rules as IEnumerable;
            foreach (dynamic rule in Rules)
            {
                if (rule.Action == 0)
                {
                    ruleList.Add(rule.Name);
                }
            }

            return ruleList;
        }


        public static BindingList<string> ListAllowedRules()
        {

            BindingList<string> ruleList = new BindingList<string>();

            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            dynamic fwPolicy2 = Activator.CreateInstance(tNetFwPolicy2) as dynamic;
            IEnumerable Rules = fwPolicy2.Rules as IEnumerable;
            foreach (dynamic rule in Rules)
            {
                if (rule.Action == 1)
                {
                    ruleList.Add(rule.Name);
                }
            }

            return ruleList;
        }

        public static BindingList<string> ListOutboundRules()
        {

            BindingList<string> ruleList = new BindingList<string>();

            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            dynamic fwPolicy2 = Activator.CreateInstance(tNetFwPolicy2) as dynamic;
            IEnumerable Rules = fwPolicy2.Rules as IEnumerable;
            foreach (dynamic rule in Rules)
            {
                if (rule.Direction == 1)
                {
                    ruleList.Add(rule.Name);
                }
            }

            return ruleList;
        }


        public static void DeleteRule(string RULE_NAME)
        {
            Process p = new Process();
           
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C netsh.exe advfirewall firewall delete rule name=" + RULE_NAME;

            p.Start();
            
            p.WaitForExit();

        }


        public static BindingList<string> ListAllRules()
        {

            BindingList<string> ruleList = new BindingList<string>();

            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            dynamic fwPolicy2 = Activator.CreateInstance(tNetFwPolicy2) as dynamic;
            IEnumerable Rules = fwPolicy2.Rules as IEnumerable;
            foreach (dynamic rule in Rules)
            {
                ruleList.Add(rule.Name);
            }

            return ruleList;
        }
    }
}
