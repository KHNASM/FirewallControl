﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirewallControl.CommonControls
{
    public static  class ProtocolNames
    {
        public static  Dictionary<int,string> ProtocolDictionary = new Dictionary<int, string>() 
                                                                {
                                                                {0, "HOPOPT"}, {1, "ICMP"}, {2, "IGMP"}, {3, "GGP"}, {4, "IPv4"}, {5, "ST"}, {6, "TCP"},
                                                                {7, "CBT"}, {8, "EGP"}, {9, "IGP"}, {10, "BBN-RCC-MON"}, {11, "NVP-II"}, {12, "PUP"}, {13, "ARGUS"},
                                                                {14, "EMCON"},{15, "XNET"}, {16, "CHAOS"}, {17, "UDP"}, {18, "MUX"}, {19, "DCN-MEAS"}, {20, "HMP"},
                                                                {21, "PRM"}, {22, "XNS-IDP"}, {23, "TRUNK-1"}, {24, "TRUNK-2"}, {25, "LEAF-1"}, {26, "LEAF-2"}, {27, "RDP"},
                                                                {28, "IRTP"}, {29, "ISO-TP4"}, {30, "NETBLT"}, {31, "MFE-NSP"}, {32, "MERIT-INP"}, {33, "DCCP"}, {34, "3PC"},
                                                                {35, "IDPR"}, {36, "XTP"}, {37, "DDP"}, {38, "IDPR-CMTP"}, {39, "TP++"}, {40, "IL"}, {41, "IPv6"}, {42, "SDRP"},
                                                                {43, "IPv6-Route"}, {44, "IPv6-Frag"}, {45, "IDRP"}, {46, "RSVP"}, {47, "GRE"}, {48, "DSR"}, {49, "BNA"}, {50, "ESP"},
                                                                {51, "AH"},{52, "I-NLSP"},{53, "SWIPE"},{54, "NARP"},{55, "MOBILE"},{56, "TLSP"},{57, "SKIP"},{58, "IPv6-ICMP"},{59, "IPv6-NoNxt"},
                                                                {60, "IPv6-Opts"},{61, "Unknown"},{62, "CFTP"},{63 ,"Unknown"},{64, "SAT-EXPAK"},{65, "KRYPTOLAN"},{66, "RVD"},{67, "IPPC"}, {68, "Unknown"},
                                                                {69, "SAT-MON"},{70, "VISA"},{71, "IPCV"},{72, "CPNX"},{73, "CPHB"},{74, "WSN"},
                                                                {75, "PVP"},{76, "BR-SAT-MON"},{77, "SUN-ND"},{78, "WB-MON"},{79, "WB-EXPAK"}, {80, "ISO-IP"},
                                                                {81, "VMTP"},{82, "SECURE-VMTP"},{83, "VINES"},{84, "IPTM"},{85, "NSFNET-IGP"},
                                                                {86, "DGP"},{87, "TCF"},{88, "EIGRP"},{89, "OSPFIGP"},{90, "Sprite-RPC"},{92, "MTP"},
                                                                {93, "AX.25"},{94, "IPIP"}, {95, "MICP"},{96, "SCC-SP"},{97, "ETHERIP"},{98, "ENCAP"},
                                                                {99, "Unknown"},{100, "GMTP"},{101, "IFMP"},{102, "PNNI"},{103, "PIM"},{104, "ARIS"},
                                                                {105, "SCPS"},{106, "QNX"},{107, "A/N"},{108, "IPComp"},{109, "SNP"},
                                                                {110, "Compaq-Peer"}, {111, "IPX-in-IP"}, {112, "VRRP"}, {113, "PGM"}, {114, "Unknown"},{115, "L2TP"},
                                                                {116, "DDX"}, {117, "IATP"}, {118, "STP"}, {119, "SRP"},{120, "UTI"},  {121, "SMP"},{122, "SM"},
                                                                {123, "PTP"},{124, "ISIS"},{125, "FIRE"}, {126, "CRTP"},{127, "CRUDP"},{128, "SSCOPMCE"},{129, "IPLT"},
                                                                {130, "SPS"}, {131, "PIPE"},{132, "SCTP"},{133, "FC"},{134, "RSVP-E2E-IGNORE"},{135, "Mobility" }, {136, "UDPLite"},
                                                                {137, "MPLS-in-IP"},{138, "Manet"},{139, "HIP"},{140, "Shim6"}, {141, "WESP"},{142, "ROHC"}, {143, "Ethernet"},{255, "Reserved"}
                                                                };

        public static BindingList<string> GetProtocolList()
        {
            BindingList<string> ReturnBindingList = new BindingList<string>();


            foreach (KeyValuePair<int,string> d in ProtocolDictionary)
            {
                ReturnBindingList.Add(d.Value.ToString());
            
            }
    

            return ReturnBindingList;
        }

    }
}
