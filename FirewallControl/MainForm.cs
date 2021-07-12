using System;
using System.Windows.Forms;
using FirewallControl.CommonControls;
using FirewallControl.WindowsFirewallAPIFucntions;
using NetFwTypeLib;


namespace FirewallControl
{
    public partial class MainForm : Form
    {

        private bool Expanded = true;
        public MainForm()
        {
            InitializeComponent();
            lbRules.DataSource = WFAPI.GetAllRules();
            lbDirection.SelectedIndex = 0;
            cbSelect.SelectedIndex = 0;
            tbPorts.Enabled = false;
            btnSelectApp.Enabled = false;
            RadioButton_ViewAllRules.Checked = true;
            ExpandPanel();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

            NET_FW_ACTION_ ACTION = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            NET_FW_IP_PROTOCOL_ PROTOCOL = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
            NET_FW_RULE_DIRECTION_ DIRECTION = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            string PORTS = string.Empty;
            string APP = string.Empty;


            #region Validate and Parse User Input

            if (tbRuleName.Text == String.Empty || tbRuleName.Text == null)
            {
                MessageBox.Show("Rule name cannot be empty!");
                return;
            }

            if (!ValidatePorts(tbPorts.Text))
            {
                MessageBox.Show("Invalid Port/Ports");
                return;
            }


                if (rd_Block.Checked)
            {
                ACTION = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            }
            else if (rd_Allow.Checked)
            {
                ACTION = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            }
            else
            {
                MessageBox.Show("Error! No action is selelcted.");
                return;
            }

            if (cbSelect.SelectedIndex == 1)
            {
                if (lbProtocol.SelectedIndex == 0)
                {
                    PROTOCOL = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
                    PORTS = tbPorts.Text;

                }
                else if (lbProtocol.SelectedIndex == 1)
                {
                    PROTOCOL = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
                    PORTS = tbPorts.Text;
                }
                else if (lbProtocol.SelectedIndex == 2)
                {

                    PROTOCOL = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY;
                    PORTS = tbPorts.Text;
                }
                else
                {
                    MessageBox.Show("No Protocol Selected");
                    return;
                }
            }
            else if (cbSelect.SelectedIndex == 2)
            {
                APP = AppDialog.FileName;
            }

            if (lbDirection.SelectedIndex == 0)
            {
                DIRECTION = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            }
            else if (lbDirection.SelectedIndex == 1)
            {
                DIRECTION = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            }
            else
            {
                MessageBox.Show("Error! Please select a direction");
                return;
            }

            #endregion

            
                if (cbSelect.SelectedIndex == 1)
                {
                    if (rd_LocalPorts.Checked)
                    {
                       WFAPI.AddRule(tbRuleName.Text, true, (int)PROTOCOL, DIRECTION, ACTION, "NA", "NA", tbPorts.Text, "NA");
                    }
                    else if (rd_RemotePorts.Checked)
                    {
                        WFAPI.AddRule(tbRuleName.Text, true, (int)PROTOCOL, DIRECTION, ACTION, "NA", tbPorts.Text, "NA", "NA");
                    }
                }
                else if (cbSelect.SelectedIndex == 2)
                {

                    WFAPI.AddRule(tbRuleName.Text, true, (int)PROTOCOL, DIRECTION, ACTION, "NA", "NA", "NA", APP);
                }

            

            UpdateRuleList();
        }

     
        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
                        
            string ruleName = lbRules.SelectedItem.ToString();
            WFAPI.DeleteRule(ruleName);
            UpdateRuleList();
        }

        private void lbRules_SelectedIndexChanged(object sender, EventArgs e)
        {

            INetFwRule RuleInformation;

            RuleInformation = WFAPI.GetRuleDetails(lbRules.SelectedItem.ToString());

            lblRuleName.Text = "Name: " + RuleInformation.Name;
            lblProtocol.Text = "Protocol: " + ProtocolTranslation.GetProtocolName(RuleInformation.Protocol);                      
            if (RuleInformation.RemotePorts == null || RuleInformation.LocalPorts == null)
            {
                lblPorts.Text = "Application: " + RuleInformation.ApplicationName;
            }
            else
            {
                lblPorts.Text = "Ports: " + RuleInformation.RemotePorts.ToString() + RuleInformation.LocalPorts.ToString();
            }
            lblDirection.Text = "Direction: " + WfapiEnumTranslation.TranslateDirection(RuleInformation.Direction);                   
            lblAction.Text = "Connection: " + WfapiEnumTranslation.TranslateAction(RuleInformation.Action);              

            
        }

        private void RadioButton_ViewAllRules_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRuleList();            
        }
                
        private  void UpdateRuleList()
        {

            if (RadioButton_AllowedRules.Checked)
            {
                lbRules.DataSource = WFAPI.GetAllowedRules();
            }
            else if (RadioButton_BlockedRules.Checked)
            {
                lbRules.DataSource = WFAPI.GetBlockedRules();
            }
            else if (RadioButton_ViewAllRules.Checked)
            {
                lbRules.DataSource = WFAPI.GetAllRules();
            }
            

        }

        #region RadioButtons

        private void RadioButton_AllowedRules_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRuleList();
        }

        private void RadioButton_BlockedRules_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRuleList();
        }

        private void RadioButton_InboundRules_CheckedChanged(object sender, EventArgs e)
        {
           UpdateRuleList();
        }

        private void RadioButton_OutboundRules_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRuleList();
        }
        #endregion


        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelect.SelectedIndex == 2)
            {
                btnSelectApp.Enabled = true;
                tbPorts.Enabled = false;
                rd_LocalPorts.Enabled = false;
                rd_RemotePorts.Enabled = false;
                lbProtocol.Enabled = false;
                gb_AllowBlock.Enabled = true;

            }
            else if (cbSelect.SelectedIndex == 1)
            {
                tbPorts.Enabled = true;
                btnSelectApp.Enabled = false;
                rd_LocalPorts.Enabled = true;
                rd_RemotePorts.Enabled = true;
                lbProtocol.Enabled = true;
                gb_AllowBlock.Enabled = true;


            }
            else 
            {
                tbPorts.Enabled = false;
                btnSelectApp.Enabled = false;
                rd_LocalPorts.Enabled = false;
                rd_RemotePorts.Enabled = false;
                lbProtocol.Enabled = false;
                gb_AllowBlock.Enabled = false;
            }

        }

        private void btnSelectApp_Click(object sender, EventArgs e)
        {
            AppDialog.Filter = "Exectuables (*.exe) | *.exe";
            AppDialog.ShowDialog();
            lbl_SelectedApp.Text = AppDialog.FileName;
        }

        private void btn_Expand_Click(object sender, EventArgs e)
        {
            ExpandPanel();
        }

        private void ExpandPanel()
        {
            if (Expanded)
            {
                this.Width = 581;
                this.Height = 458;
                Expanded = false;
                btn_Expand.Text = ">";
            }
            else if (!Expanded)
            {
                this.Width = 1026;
                this.Height = 458;
                Expanded = true;
                btn_Expand.Text = "<";
            }
        }

        private bool ValidatePorts(string PORTS)
        {
            string[] temp = null;
            int portNumber;

            if (PORTS.Contains("-"))
            {
                temp = PORTS.Split('-');

                foreach (string port in temp)
                {
                    
                    int.TryParse(port, out portNumber);
                    if (portNumber == 0)
                    {
                        return false;
                    }

                }
            }
            else if (!PORTS.Contains("-"))
            {
 
               int.TryParse(PORTS, out portNumber);
                if (portNumber == 0)
                {
                    return false;
                }
            
            }

            return true;
        
        }
    }
}
