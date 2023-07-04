
namespace APITest_Wrapper {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.bttnRunTests = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbApiCall = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.lblPingHosts = new System.Windows.Forms.Label();
            this.lblTcpCheckHttp = new System.Windows.Forms.Label();
            this.tbRawOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnCopyOutput = new System.Windows.Forms.Button();
            this.spbStatus = new APITest_Wrapper.StatusProgressBar();
            this.lblTcpCheckHttps = new System.Windows.Forms.Label();
            this.cbCheckHttp = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(98, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(195, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // bttnRunTests
            // 
            this.bttnRunTests.Location = new System.Drawing.Point(299, 99);
            this.bttnRunTests.Name = "bttnRunTests";
            this.bttnRunTests.Size = new System.Drawing.Size(89, 23);
            this.bttnRunTests.TabIndex = 5;
            this.bttnRunTests.Text = "Run Tests";
            this.bttnRunTests.UseVisualStyleBackColor = true;
            this.bttnRunTests.Click += new System.EventHandler(this.bttnRunTests_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NetApp Host";
            // 
            // cbApiCall
            // 
            this.cbApiCall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApiCall.FormattingEnabled = true;
            this.cbApiCall.Items.AddRange(new object[] {
            "system-get-version",
            "qtree-list-iter"});
            this.cbApiCall.Location = new System.Drawing.Point(98, 100);
            this.cbApiCall.Name = "cbApiCall";
            this.cbApiCall.Size = new System.Drawing.Size(195, 21);
            this.cbApiCall.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "API Call";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(98, 38);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(195, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(98, 74);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(195, 20);
            this.tbHost.TabIndex = 3;
            this.tbHost.TextChanged += new System.EventHandler(this.tbHost_TextChanged);
            // 
            // lblPingHosts
            // 
            this.lblPingHosts.AutoSize = true;
            this.lblPingHosts.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPingHosts.Location = new System.Drawing.Point(95, 7);
            this.lblPingHosts.Name = "lblPingHosts";
            this.lblPingHosts.Size = new System.Drawing.Size(76, 13);
            this.lblPingHosts.TabIndex = 10;
            this.lblPingHosts.Text = "⭕ PING HOST";
            // 
            // lblTcpCheckHttp
            // 
            this.lblTcpCheckHttp.AutoSize = true;
            this.lblTcpCheckHttp.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcpCheckHttp.Location = new System.Drawing.Point(95, 20);
            this.lblTcpCheckHttp.Name = "lblTcpCheckHttp";
            this.lblTcpCheckHttp.Size = new System.Drawing.Size(106, 13);
            this.lblTcpCheckHttp.TabIndex = 11;
            this.lblTcpCheckHttp.Text = "⭕ TCP CHECK HTTP";
            // 
            // tbRawOutput
            // 
            this.tbRawOutput.BackColor = System.Drawing.Color.Black;
            this.tbRawOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRawOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRawOutput.ForeColor = System.Drawing.Color.White;
            this.tbRawOutput.Location = new System.Drawing.Point(9, 80);
            this.tbRawOutput.Multiline = true;
            this.tbRawOutput.Name = "tbRawOutput";
            this.tbRawOutput.ReadOnly = true;
            this.tbRawOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRawOutput.Size = new System.Drawing.Size(379, 220);
            this.tbRawOutput.TabIndex = 12;
            this.tbRawOutput.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Raw Output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Network Checks";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bttnCopyOutput);
            this.panel1.Controls.Add(this.spbStatus);
            this.panel1.Controls.Add(this.lblTcpCheckHttps);
            this.panel1.Controls.Add(this.lblPingHosts);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblTcpCheckHttp);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbRawOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 341);
            this.panel1.TabIndex = 15;
            // 
            // bttnCopyOutput
            // 
            this.bttnCopyOutput.Location = new System.Drawing.Point(299, 306);
            this.bttnCopyOutput.Name = "bttnCopyOutput";
            this.bttnCopyOutput.Size = new System.Drawing.Size(89, 23);
            this.bttnCopyOutput.TabIndex = 17;
            this.bttnCopyOutput.Text = "Copy Output";
            this.bttnCopyOutput.UseVisualStyleBackColor = true;
            this.bttnCopyOutput.Click += new System.EventHandler(this.bttnCopyOutput_Click);
            // 
            // spbStatus
            // 
            this.spbStatus.Location = new System.Drawing.Point(9, 306);
            this.spbStatus.Name = "spbStatus";
            this.spbStatus.Size = new System.Drawing.Size(284, 23);
            this.spbStatus.StatusText = "Idle";
            this.spbStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.spbStatus.TabIndex = 16;
            // 
            // lblTcpCheckHttps
            // 
            this.lblTcpCheckHttps.AutoSize = true;
            this.lblTcpCheckHttps.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcpCheckHttps.Location = new System.Drawing.Point(95, 33);
            this.lblTcpCheckHttps.Name = "lblTcpCheckHttps";
            this.lblTcpCheckHttps.Size = new System.Drawing.Size(112, 13);
            this.lblTcpCheckHttps.TabIndex = 15;
            this.lblTcpCheckHttps.Text = "⭕ TCP CHECK HTTPS";
            // 
            // cbCheckHttp
            // 
            this.cbCheckHttp.AutoSize = true;
            this.cbCheckHttp.Checked = true;
            this.cbCheckHttp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheckHttp.Location = new System.Drawing.Point(299, 76);
            this.cbCheckHttp.Name = "cbCheckHttp";
            this.cbCheckHttp.Size = new System.Drawing.Size(89, 17);
            this.cbCheckHttp.TabIndex = 6;
            this.cbCheckHttp.Text = "Check HTTP";
            this.cbCheckHttp.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 469);
            this.Controls.Add(this.cbCheckHttp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbApiCall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnRunTests);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "NetApp APITest Wrapper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button bttnRunTests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbApiCall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label lblPingHosts;
        private System.Windows.Forms.Label lblTcpCheckHttp;
        private System.Windows.Forms.TextBox tbRawOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTcpCheckHttps;
        private StatusProgressBar spbStatus;
        private System.Windows.Forms.CheckBox cbCheckHttp;
        private System.Windows.Forms.Button bttnCopyOutput;
    }
}

