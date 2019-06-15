namespace Lara_FinalProject
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTitleLog = new System.Windows.Forms.Label();
            this.lblRegisterOps = new System.Windows.Forms.Label();
            this.lblAccessKey = new System.Windows.Forms.Label();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkViewPass = new System.Windows.Forms.CheckBox();
            this.lblfName = new System.Windows.Forms.Label();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.lbllName = new System.Windows.Forms.Label();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.lblLoginOps = new System.Windows.Forms.Label();
            this.ttLogin = new System.Windows.Forms.ToolTip(this.components);
            this.errProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpTextboxes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTxt)).BeginInit();
            this.ssStatus.SuspendLayout();
            this.grpTextboxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(295, 158);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(71, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LogIn";
            this.ttLogin.SetToolTip(this.btnLogin, "Login");
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 68);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Manager Password*";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 64);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(76, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(153, 40);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(76, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(35, 43);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(109, 13);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Manager User Name*";
            // 
            // lblTitleLog
            // 
            this.lblTitleLog.AutoSize = true;
            this.lblTitleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLog.Location = new System.Drawing.Point(77, 9);
            this.lblTitleLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleLog.Name = "lblTitleLog";
            this.lblTitleLog.Size = new System.Drawing.Size(237, 24);
            this.lblTitleLog.TabIndex = 6;
            this.lblTitleLog.Text = "Please enter you login info ";
            // 
            // lblRegisterOps
            // 
            this.lblRegisterOps.AutoSize = true;
            this.lblRegisterOps.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRegisterOps.Location = new System.Drawing.Point(13, 189);
            this.lblRegisterOps.Name = "lblRegisterOps";
            this.lblRegisterOps.Size = new System.Drawing.Size(143, 13);
            this.lblRegisterOps.TabIndex = 10;
            this.lblRegisterOps.Text = "Register a Manager Account";
            this.ttLogin.SetToolTip(this.lblRegisterOps, "Register Options");
            this.lblRegisterOps.Click += new System.EventHandler(this.lblRegisterOps_Click);
            // 
            // lblAccessKey
            // 
            this.lblAccessKey.AutoSize = true;
            this.lblAccessKey.Location = new System.Drawing.Point(35, 92);
            this.lblAccessKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessKey.Name = "lblAccessKey";
            this.lblAccessKey.Size = new System.Drawing.Size(85, 13);
            this.lblAccessKey.TabIndex = 14;
            this.lblAccessKey.Text = "DB Access Key*";
            this.ttLogin.SetToolTip(this.lblAccessKey, "The Key is: 123");
            this.lblAccessKey.Visible = false;
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(153, 88);
            this.txtAccessKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(76, 20);
            this.txtAccessKey.TabIndex = 6;
            this.txtAccessKey.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.ttLogin.SetToolTip(this.btnCancel, "close login");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkViewPass
            // 
            this.chkViewPass.AutoSize = true;
            this.chkViewPass.Location = new System.Drawing.Point(234, 66);
            this.chkViewPass.Name = "chkViewPass";
            this.chkViewPass.Size = new System.Drawing.Size(53, 17);
            this.chkViewPass.TabIndex = 5;
            this.chkViewPass.Text = "Show";
            this.chkViewPass.UseVisualStyleBackColor = true;
            this.chkViewPass.CheckedChanged += new System.EventHandler(this.chkViewPass_CheckedChanged);
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.Location = new System.Drawing.Point(9, 17);
            this.lblfName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(61, 13);
            this.lblfName.TabIndex = 18;
            this.lblfName.Text = "First Name*";
            this.lblfName.Visible = false;
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(74, 14);
            this.txtfName.Margin = new System.Windows.Forms.Padding(2);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(76, 20);
            this.txtfName.TabIndex = 0;
            this.txtfName.Visible = false;
            // 
            // lbllName
            // 
            this.lbllName.AutoSize = true;
            this.lbllName.Location = new System.Drawing.Point(193, 17);
            this.lbllName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(62, 13);
            this.lbllName.TabIndex = 20;
            this.lbllName.Text = "Last Name*";
            this.lbllName.Visible = false;
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(259, 14);
            this.txtlName.Margin = new System.Windows.Forms.Padding(2);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(76, 20);
            this.txtlName.TabIndex = 1;
            this.txtlName.Visible = false;
            // 
            // lblLoginOps
            // 
            this.lblLoginOps.AutoSize = true;
            this.lblLoginOps.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLoginOps.Location = new System.Drawing.Point(13, 163);
            this.lblLoginOps.Name = "lblLoginOps";
            this.lblLoginOps.Size = new System.Drawing.Size(143, 13);
            this.lblLoginOps.TabIndex = 9;
            this.lblLoginOps.Text = "Login with Manager Account";
            this.ttLogin.SetToolTip(this.lblLoginOps, "Login Options");
            this.lblLoginOps.Click += new System.EventHandler(this.lblLoginOps_Click);
            // 
            // errProviderTxt
            // 
            this.errProviderTxt.ContainerControl = this;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 205);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(382, 22);
            this.ssStatus.TabIndex = 21;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // grpTextboxes
            // 
            this.grpTextboxes.Controls.Add(this.txtUserName);
            this.grpTextboxes.Controls.Add(this.lblUserName);
            this.grpTextboxes.Controls.Add(this.txtPassword);
            this.grpTextboxes.Controls.Add(this.lbllName);
            this.grpTextboxes.Controls.Add(this.lblPassword);
            this.grpTextboxes.Controls.Add(this.txtlName);
            this.grpTextboxes.Controls.Add(this.txtAccessKey);
            this.grpTextboxes.Controls.Add(this.lblfName);
            this.grpTextboxes.Controls.Add(this.lblAccessKey);
            this.grpTextboxes.Controls.Add(this.txtfName);
            this.grpTextboxes.Controls.Add(this.chkViewPass);
            this.grpTextboxes.Location = new System.Drawing.Point(18, 36);
            this.grpTextboxes.Name = "grpTextboxes";
            this.grpTextboxes.Size = new System.Drawing.Size(348, 117);
            this.grpTextboxes.TabIndex = 22;
            this.grpTextboxes.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 227);
            this.ControlBox = false;
            this.Controls.Add(this.grpTextboxes);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.lblLoginOps);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRegisterOps);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblTitleLog);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTxt)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.grpTextboxes.ResumeLayout(false);
            this.grpTextboxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTitleLog;
        private System.Windows.Forms.Label lblRegisterOps;
        private System.Windows.Forms.Label lblAccessKey;
        public System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkViewPass;
        private System.Windows.Forms.Label lblfName;
        public System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.Label lbllName;
        public System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.Label lblLoginOps;
        private System.Windows.Forms.ToolTip ttLogin;
        private System.Windows.Forms.ErrorProvider errProviderTxt;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.GroupBox grpTextboxes;
    }
}