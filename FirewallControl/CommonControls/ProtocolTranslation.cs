using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirewallControl.CommonControls.ProtocolNames;

namespace FirewallControl.CommonControls
{
   public static class ProtocolTranslation
    {

        public static string ProtocolIdToProtocolName(int protocolID)
        {

            
            string ProtocolName = string.Empty;

            ProtocolName = ProtocolDictionary[protocolID].ToString();

            return ProtocolName;
               
        }

       





        public  static string GetProtocolName(int protocolID)
        {

            if (protocolID == 6)
            {

                return "TCP";

            }
            else 
                if (protocolID == 17)
                {
                    return "UDP";
                }
                else 
                    {
                        return "Any";
                    }
                
        }


        public static string GetDirectionName(int directionID)
        {

            if (directionID == 1)
            {
                return "Inboud";
            }
            else
                if (directionID == 2)
                {
                    return "Outbound";
                }
                else
                    {
                    return "Unknown";
                    }
        }


        public  static string GetActionName(int actionID)
        {

            if (actionID == 1)
            {
                return "Allowed";
            }
            else
                if (actionID == 0)
            {
                return "Blocked";
            }
            else
            {
                return "Unknown";
            }
        }


        public static string SetAction(string action)
        {

            if (action == "Inbound")
            {
                return "in";
            }
            else
                if (action == "Outbound")
            {
                return "out";
            }
            else
            {
                return "in";
            }
        }


    }
}
