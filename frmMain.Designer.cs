namespace Lara_FinalProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbxBlender = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Items = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_Demo = new System.Windows.Forms.ToolStripMenuItem();
            this.stpMain = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlItemsInBlender = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlItemsInStock = new System.Windows.Forms.FlowLayoutPanel();
            this.lbxOrderDetails = new System.Windows.Forms.ListBox();
            this.btnBlend = new System.Windows.Forms.Button();
            this.rtbxDetails = new System.Windows.Forms.RichTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBlentTitle = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblItemsStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlender)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.stpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBlender
            // 
            this.pbxBlender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxBlender.BackColor = System.Drawing.Color.Transparent;
            this.pbxBlender.Image = ((System.Drawing.Image)(resources.GetObject("pbxBlender.Image")));
            this.pbxBlender.Location = new System.Drawing.Point(384, 126);
            this.pbxBlender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxBlender.Name = "pbxBlender";
            this.pbxBlender.Size = new System.Drawing.Size(404, 469);
            this.pbxBlender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBlender.TabIndex = 0;
            this.pbxBlender.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1204, 28);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFile_Exit.Size = new System.Drawing.Size(161, 26);
            this.mnuFile_Exit.Text = "Exit";
            this.mnuFile_Exit.ToolTipText = "Exit application";
            this.mnuFile_Exit.Click += new System.EventHandler(this.mnuFile_Exit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit_Items});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(47, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuEdit_Items
            // 
            this.mnuEdit_Items.Name = "mnuEdit_Items";
            this.mnuEdit_Items.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuEdit_Items.Size = new System.Drawing.Size(166, 26);
            this.mnuEdit_Items.Text = "Items";
            this.mnuEdit_Items.ToolTipText = "Edit Items";
            this.mnuEdit_Items.Click += new System.EventHandler(this.mnuEdit_Items_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_Demo});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(53, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelp_Demo
            // 
            this.mnuHelp_Demo.Name = "mnuHelp_Demo";
            this.mnuHelp_Demo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuHelp_Demo.Size = new System.Drawing.Size(178, 26);
            this.mnuHelp_Demo.Text = "Demo";
            this.mnuHelp_Demo.ToolTipText = "Watch a video demo";
            this.mnuHelp_Demo.Click += new System.EventHandler(this.mnuHelp_Demo_Click);
            // 
            // stpMain
            // 
            this.stpMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.stpMain.Location = new System.Drawing.Point(0, 729);
            this.stpMain.Name = "stpMain";
            this.stpMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stpMain.Size = new System.Drawing.Size(1204, 22);
            this.stpMain.TabIndex = 2;
            this.stpMain.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlItemsInBlender
            // 
            this.pnlItemsInBlender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlItemsInBlender.AutoScroll = true;
            this.pnlItemsInBlender.BackColor = System.Drawing.Color.Transparent;
            this.pnlItemsInBlender.Location = new System.Drawing.Point(15, 126);
            this.pnlItemsInBlender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlItemsInBlender.Name = "pnlItemsInBlender";
            this.pnlItemsInBlender.Size = new System.Drawing.Size(361, 279);
            this.pnlItemsInBlender.TabIndex = 10;
            // 
            // pnlItemsInStock
            // 
            this.pnlItemsInStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemsInStock.AutoScroll = true;
            this.pnlItemsInStock.BackColor = System.Drawing.Color.Transparent;
            this.pnlItemsInStock.Location = new System.Drawing.Point(796, 241);
            this.pnlItemsInStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlItemsInStock.Name = "pnlItemsInStock";
            this.pnlItemsInStock.Size = new System.Drawing.Size(387, 353);
            this.pnlItemsInStock.TabIndex = 13;
            // 
            // lbxOrderDetails
            // 
            this.lbxOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxOrderDetails.FormattingEnabled = true;
            this.lbxOrderDetails.ItemHeight = 16;
            this.lbxOrderDetails.Location = new System.Drawing.Point(16, 412);
            this.lbxOrderDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxOrderDetails.Name = "lbxOrderDetails";
            this.lbxOrderDetails.Size = new System.Drawing.Size(359, 180);
            this.lbxOrderDetails.TabIndex = 14;
            // 
            // btnBlend
            // 
            this.btnBlend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBlend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlend.Location = new System.Drawing.Point(515, 623);
            this.btnBlend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBlend.Name = "btnBlend";
            this.btnBlend.Size = new System.Drawing.Size(172, 79);
            this.btnBlend.TabIndex = 15;
            this.btnBlend.Text = "Receipt";
            this.btnBlend.UseVisualStyleBackColor = true;
            this.btnBlend.Click += new System.EventHandler(this.btnBlend_Click);
            // 
            // rtbxDetails
            // 
            this.rtbxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbxDetails.Location = new System.Drawing.Point(796, 126);
            this.rtbxDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbxDetails.Name = "rtbxDetails";
            this.rtbxDetails.Size = new System.Drawing.Size(385, 107);
            this.rtbxDetails.TabIndex = 16;
            this.rtbxDetails.Text = "";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(16, 597);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 25);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(305, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(563, 54);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Choose Your Ingredients";
            // 
            // lblBlentTitle
            // 
            this.lblBlentTitle.AutoSize = true;
            this.lblBlentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlentTitle.Location = new System.Drawing.Point(15, 102);
            this.lblBlentTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlentTitle.Name = "lblBlentTitle";
            this.lblBlentTitle.Size = new System.Drawing.Size(198, 20);
            this.lblBlentTitle.TabIndex = 19;
            this.lblBlentTitle.Text = "Items In Juice Blender";
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTitle.Location = new System.Drawing.Point(796, 102);
            this.lblInfoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(148, 20);
            this.lblInfoTitle.TabIndex = 20;
            this.lblInfoTitle.Text = "Item Description";
            // 
            // lblItemsStock
            // 
            this.lblItemsStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemsStock.AutoSize = true;
            this.lblItemsStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsStock.Location = new System.Drawing.Point(796, 603);
            this.lblItemsStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsStock.Name = "lblItemsStock";
            this.lblItemsStock.Size = new System.Drawing.Size(256, 20);
            this.lblItemsStock.TabIndex = 21;
            this.lblItemsStock.Text = "Add Itemes From this Panel ^";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 751);
            this.Controls.Add(this.lblItemsStock);
            this.Controls.Add(this.lblInfoTitle);
            this.Controls.Add(this.lblBlentTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.rtbxDetails);
            this.Controls.Add(this.btnBlend);
            this.Controls.Add(this.lbxOrderDetails);
            this.Controls.Add(this.pnlItemsInStock);
            this.Controls.Add(this.pnlItemsInBlender);
            this.Controls.Add(this.stpMain);
            this.Controls.Add(this.pbxBlender);
            this.Controls.Add(this.mnuMain);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Got Juice?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlender)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stpMain.ResumeLayout(false);
            this.stpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBlender;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.StatusStrip stpMain;
        private System.Windows.Forms.FlowLayoutPanel pnlItemsInBlender;
        private System.Windows.Forms.FlowLayoutPanel pnlItemsInStock;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Items;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_Demo;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Exit;
        private System.Windows.Forms.ListBox lbxOrderDetails;
        private System.Windows.Forms.Button btnBlend;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.RichTextBox rtbxDetails;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBlentTitle;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblItemsStock;
    }
}

