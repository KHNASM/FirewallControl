
namespace FirewallControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBlock = new System.Windows.Forms.Button();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.tbRuleName = new System.Windows.Forms.TextBox();
            this.tbPorts = new System.Windows.Forms.TextBox();
            this.lbProtocol = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectApp = new System.Windows.Forms.Button();
            this.lbl_SelectedApp = new System.Windows.Forms.Label();
            this.lbDirection = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rd_RemotePorts = new System.Windows.Forms.RadioButton();
            this.rd_LocalPorts = new System.Windows.Forms.RadioButton();
            this.gb_AllowBlock = new System.Windows.Forms.GroupBox();
            this.rd_Block = new System.Windows.Forms.RadioButton();
            this.rd_Allow = new System.Windows.Forms.RadioButton();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDeleteRule = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPorts = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblRuleName = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RadioButton_ViewAllRules = new System.Windows.Forms.RadioButton();
            this.RadioButton_AllowedRules = new System.Windows.Forms.RadioButton();
            this.RadioButton_BlockedRules = new System.Windows.Forms.RadioButton();
            this.AppDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_Expand = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gb_AllowBlock.SuspendLayout();
            this.gbDeleteRule.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(9, 286);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(472, 51);
            this.btnBlock.TabIndex = 0;
            this.btnBlock.Text = "ADD RULE";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.Location = new System.Drawing.Point(12, 29);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(161, 82);
            this.lbRules.TabIndex = 1;
            this.lbRules.SelectedIndexChanged += new System.EventHandler(this.lbRules_SelectedIndexChanged);
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(7, 278);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(373, 51);
            this.btnDeleteRule.TabIndex = 2;
            this.btnDeleteRule.Text = "UNBLOCK / DELETE RULE";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // tbRuleName
            // 
            this.tbRuleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.SetColumnSpan(this.tbRuleName, 2);
            this.tbRuleName.Location = new System.Drawing.Point(157, 6);
            this.tbRuleName.Name = "tbRuleName";
            this.tbRuleName.Size = new System.Drawing.Size(201, 20);
            this.tbRuleName.TabIndex = 3;
            // 
            // tbPorts
            // 
            this.tbPorts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPorts.Location = new System.Drawing.Point(157, 69);
            this.tbPorts.Name = "tbPorts";
            this.tbPorts.Size = new System.Drawing.Size(97, 20);
            this.tbPorts.TabIndex = 4;
            // 
            // lbProtocol
            // 
            this.lbProtocol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.SetColumnSpan(this.lbProtocol, 2);
            this.lbProtocol.FormattingEnabled = true;
            this.lbProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.lbProtocol.Location = new System.Drawing.Point(157, 167);
            this.lbProtocol.Name = "lbProtocol";
            this.lbProtocol.Size = new System.Drawing.Size(201, 30);
            this.lbProtocol.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rule Name (No Spaces)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port/Port Range/App";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Protocol";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.btnBlock);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 355);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Rule";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.92366F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.07634F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.Controls.Add(this.tbPorts, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnSelectApp, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_SelectedApp, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbDirection, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.lbProtocol, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.rd_RemotePorts, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.rd_LocalPorts, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.gb_AllowBlock, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.cbSelect, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbRuleName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 237);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // btnSelectApp
            // 
            this.btnSelectApp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectApp.Location = new System.Drawing.Point(260, 69);
            this.btnSelectApp.Name = "btnSelectApp";
            this.btnSelectApp.Size = new System.Drawing.Size(97, 20);
            this.btnSelectApp.TabIndex = 14;
            this.btnSelectApp.Text = "Choose";
            this.btnSelectApp.UseVisualStyleBackColor = true;
            this.btnSelectApp.Click += new System.EventHandler(this.btnSelectApp_Click);
            // 
            // lbl_SelectedApp
            // 
            this.lbl_SelectedApp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_SelectedApp.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.lbl_SelectedApp, 2);
            this.lbl_SelectedApp.Location = new System.Drawing.Point(157, 96);
            this.lbl_SelectedApp.Name = "lbl_SelectedApp";
            this.lbl_SelectedApp.Size = new System.Drawing.Size(27, 13);
            this.lbl_SelectedApp.TabIndex = 16;
            this.lbl_SelectedApp.Text = "N/A";
            // 
            // lbDirection
            // 
            this.lbDirection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.SetColumnSpan(this.lbDirection, 2);
            this.lbDirection.FormattingEnabled = true;
            this.lbDirection.Items.AddRange(new object[] {
            "Inbound",
            "Outbound"});
            this.lbDirection.Location = new System.Drawing.Point(157, 203);
            this.lbDirection.Name = "lbDirection";
            this.lbDirection.Size = new System.Drawing.Size(201, 30);
            this.lbDirection.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Direction";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Action";
            // 
            // rd_RemotePorts
            // 
            this.rd_RemotePorts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_RemotePorts.AutoSize = true;
            this.rd_RemotePorts.Location = new System.Drawing.Point(260, 117);
            this.rd_RemotePorts.Name = "rd_RemotePorts";
            this.rd_RemotePorts.Size = new System.Drawing.Size(95, 17);
            this.rd_RemotePorts.TabIndex = 19;
            this.rd_RemotePorts.TabStop = true;
            this.rd_RemotePorts.Text = "Remote Port(s)";
            this.rd_RemotePorts.UseVisualStyleBackColor = true;
            // 
            // rd_LocalPorts
            // 
            this.rd_LocalPorts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_LocalPorts.AutoSize = true;
            this.rd_LocalPorts.Location = new System.Drawing.Point(157, 117);
            this.rd_LocalPorts.Name = "rd_LocalPorts";
            this.rd_LocalPorts.Size = new System.Drawing.Size(84, 17);
            this.rd_LocalPorts.TabIndex = 20;
            this.rd_LocalPorts.TabStop = true;
            this.rd_LocalPorts.Text = "Local Port(s)";
            this.rd_LocalPorts.UseVisualStyleBackColor = true;
            // 
            // gb_AllowBlock
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.gb_AllowBlock, 2);
            this.gb_AllowBlock.Controls.Add(this.rd_Block);
            this.gb_AllowBlock.Controls.Add(this.rd_Allow);
            this.gb_AllowBlock.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_AllowBlock.Location = new System.Drawing.Point(157, 141);
            this.gb_AllowBlock.Name = "gb_AllowBlock";
            this.gb_AllowBlock.Padding = new System.Windows.Forms.Padding(0);
            this.gb_AllowBlock.Size = new System.Drawing.Size(199, 20);
            this.gb_AllowBlock.TabIndex = 11;
            this.gb_AllowBlock.TabStop = false;
            // 
            // rd_Block
            // 
            this.rd_Block.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rd_Block.AutoSize = true;
            this.rd_Block.Location = new System.Drawing.Point(104, 1);
            this.rd_Block.Name = "rd_Block";
            this.rd_Block.Size = new System.Drawing.Size(52, 17);
            this.rd_Block.TabIndex = 22;
            this.rd_Block.TabStop = true;
            this.rd_Block.Text = "Block";
            this.rd_Block.UseVisualStyleBackColor = true;
            // 
            // rd_Allow
            // 
            this.rd_Allow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_Allow.AutoSize = true;
            this.rd_Allow.Location = new System.Drawing.Point(0, 1);
            this.rd_Allow.Name = "rd_Allow";
            this.rd_Allow.Size = new System.Drawing.Size(50, 17);
            this.rd_Allow.TabIndex = 23;
            this.rd_Allow.TabStop = true;
            this.rd_Allow.Text = "Allow";
            this.rd_Allow.UseVisualStyleBackColor = true;
            // 
            // cbSelect
            // 
            this.cbSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.SetColumnSpan(this.cbSelect, 2);
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Select...",
            "Port(s)",
            "App"});
            this.cbSelect.Location = new System.Drawing.Point(157, 39);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(201, 21);
            this.cbSelect.TabIndex = 13;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Type (App/Port)";
            // 
            // gbDeleteRule
            // 
            this.gbDeleteRule.Controls.Add(this.tableLayoutPanel2);
            this.gbDeleteRule.Controls.Add(this.btnDeleteRule);
            this.gbDeleteRule.Controls.Add(this.tableLayoutPanel1);
            this.gbDeleteRule.Controls.Add(this.lbRules);
            this.gbDeleteRule.Location = new System.Drawing.Point(596, 29);
            this.gbDeleteRule.Name = "gbDeleteRule";
            this.gbDeleteRule.Size = new System.Drawing.Size(397, 347);
            this.gbDeleteRule.TabIndex = 10;
            this.gbDeleteRule.TabStop = false;
            this.gbDeleteRule.Text = "Existing Rules";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.68665F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.31335F));
            this.tableLayoutPanel2.Controls.Add(this.lblPorts, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAction, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRuleName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDirection, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProtocol, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 136);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 99);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // lblPorts
            // 
            this.lblPorts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPorts.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblPorts, 2);
            this.lblPorts.Location = new System.Drawing.Point(3, 76);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(37, 13);
            this.lblPorts.TabIndex = 13;
            this.lblPorts.Text = "Ports: ";
            // 
            // lblAction
            // 
            this.lblAction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(3, 43);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(40, 13);
            this.lblAction.TabIndex = 15;
            this.lblAction.Text = "Action:";
            // 
            // lblRuleName
            // 
            this.lblRuleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRuleName.AutoSize = true;
            this.lblRuleName.Location = new System.Drawing.Point(3, 10);
            this.lblRuleName.Name = "lblRuleName";
            this.lblRuleName.Size = new System.Drawing.Size(38, 13);
            this.lblRuleName.TabIndex = 11;
            this.lblRuleName.Text = "Name:";
            // 
            // lblDirection
            // 
            this.lblDirection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(167, 10);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(52, 13);
            this.lblDirection.TabIndex = 12;
            this.lblDirection.Text = "Direction:";
            // 
            // lblProtocol
            // 
            this.lblProtocol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Location = new System.Drawing.Point(167, 43);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(49, 13);
            this.lblProtocol.TabIndex = 14;
            this.lblProtocol.Text = "Protocol:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RadioButton_ViewAllRules, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RadioButton_AllowedRules, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RadioButton_BlockedRules, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(179, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 81);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // RadioButton_ViewAllRules
            // 
            this.RadioButton_ViewAllRules.AutoSize = true;
            this.RadioButton_ViewAllRules.Location = new System.Drawing.Point(3, 3);
            this.RadioButton_ViewAllRules.Name = "RadioButton_ViewAllRules";
            this.RadioButton_ViewAllRules.Size = new System.Drawing.Size(39, 17);
            this.RadioButton_ViewAllRules.TabIndex = 16;
            this.RadioButton_ViewAllRules.TabStop = true;
            this.RadioButton_ViewAllRules.Text = "All ";
            this.RadioButton_ViewAllRules.UseVisualStyleBackColor = true;
            this.RadioButton_ViewAllRules.CheckedChanged += new System.EventHandler(this.RadioButton_ViewAllRules_CheckedChanged);
            // 
            // RadioButton_AllowedRules
            // 
            this.RadioButton_AllowedRules.AutoSize = true;
            this.RadioButton_AllowedRules.Location = new System.Drawing.Point(103, 3);
            this.RadioButton_AllowedRules.Name = "RadioButton_AllowedRules";
            this.RadioButton_AllowedRules.Size = new System.Drawing.Size(62, 17);
            this.RadioButton_AllowedRules.TabIndex = 18;
            this.RadioButton_AllowedRules.TabStop = true;
            this.RadioButton_AllowedRules.Text = "Allowed";
            this.RadioButton_AllowedRules.UseVisualStyleBackColor = true;
            this.RadioButton_AllowedRules.CheckedChanged += new System.EventHandler(this.RadioButton_AllowedRules_CheckedChanged);
            // 
            // RadioButton_BlockedRules
            // 
            this.RadioButton_BlockedRules.AutoSize = true;
            this.RadioButton_BlockedRules.Location = new System.Drawing.Point(3, 31);
            this.RadioButton_BlockedRules.Name = "RadioButton_BlockedRules";
            this.RadioButton_BlockedRules.Size = new System.Drawing.Size(64, 17);
            this.RadioButton_BlockedRules.TabIndex = 17;
            this.RadioButton_BlockedRules.TabStop = true;
            this.RadioButton_BlockedRules.Text = "Blocked";
            this.RadioButton_BlockedRules.UseVisualStyleBackColor = true;
            this.RadioButton_BlockedRules.CheckedChanged += new System.EventHandler(this.RadioButton_BlockedRules_CheckedChanged);
            // 
            // AppDialog
            // 
            this.AppDialog.FileName = "Select an app";
            // 
            // btn_Expand
            // 
            this.btn_Expand.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Expand.Location = new System.Drawing.Point(517, 25);
            this.btn_Expand.Name = "btn_Expand";
            this.btn_Expand.Size = new System.Drawing.Size(40, 351);
            this.btn_Expand.TabIndex = 11;
            this.btn_Expand.Text = ">";
            this.btn_Expand.UseVisualStyleBackColor = false;
            this.btn_Expand.Click += new System.EventHandler(this.btn_Expand_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Author: Asim ul Asre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email: au.asre@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "HTTPS;//DSV.SU.SE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 419);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Expand);
            this.Controls.Add(this.gbDeleteRule);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Firewall Control";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gb_AllowBlock.ResumeLayout(false);
            this.gb_AllowBlock.PerformLayout();
            this.gbDeleteRule.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.TextBox tbRuleName;
        private System.Windows.Forms.TextBox tbPorts;
        private System.Windows.Forms.ListBox lbProtocol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDeleteRule;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblRuleName;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbDirection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton RadioButton_ViewAllRules;
        private System.Windows.Forms.RadioButton RadioButton_AllowedRules;
        private System.Windows.Forms.RadioButton RadioButton_BlockedRules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.OpenFileDialog AppDialog;
        private System.Windows.Forms.Button btnSelectApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_SelectedApp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rd_Block;
        private System.Windows.Forms.RadioButton rd_Allow;
        private System.Windows.Forms.RadioButton rd_RemotePorts;
        private System.Windows.Forms.RadioButton rd_LocalPorts;
        private System.Windows.Forms.GroupBox gb_AllowBlock;
        private System.Windows.Forms.Button btn_Expand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}