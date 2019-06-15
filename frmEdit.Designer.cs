namespace Lara_FinalProject
{
    partial class frmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.stpEdit = new System.Windows.Forms.StatusStrip();
            this.tssStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbxPictureItem = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.mnuEdit = new System.Windows.Forms.MenuStrip();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ttEdit = new System.Windows.Forms.ToolTip(this.components);
            this.ofdEdit = new System.Windows.Forms.OpenFileDialog();
            this.grpTxt = new System.Windows.Forms.GroupBox();
            this.errProviderEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.stpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPictureItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.mnuEdit.SuspendLayout();
            this.grpTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // stpEdit
            // 
            this.stpEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stpEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatusLabel});
            this.stpEdit.Location = new System.Drawing.Point(0, 301);
            this.stpEdit.Name = "stpEdit";
            this.stpEdit.Size = new System.Drawing.Size(350, 22);
            this.stpEdit.TabIndex = 1;
            this.stpEdit.Text = "statusStrip1";
            // 
            // tssStatusLabel
            // 
            this.tssStatusLabel.Name = "tssStatusLabel";
            this.tssStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // pbxPictureItem
            // 
            this.pbxPictureItem.Image = ((System.Drawing.Image)(resources.GetObject("pbxPictureItem.Image")));
            this.pbxPictureItem.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxPictureItem.InitialImage")));
            this.pbxPictureItem.Location = new System.Drawing.Point(18, 37);
            this.pbxPictureItem.Name = "pbxPictureItem";
            this.pbxPictureItem.Size = new System.Drawing.Size(106, 95);
            this.pbxPictureItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPictureItem.TabIndex = 3;
            this.pbxPictureItem.TabStop = false;
            this.ttEdit.SetToolTip(this.pbxPictureItem, "Click to add image");
            this.pbxPictureItem.Click += new System.EventHandler(this.pbxPictureItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(79, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 48);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(18, 138);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(311, 132);
            this.dgvItems.TabIndex = 8;
            this.dgvItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvItems_MouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(77, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.ttEdit.SetToolTip(this.btnCancel, "Cancel");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(190, 276);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.ttEdit.SetToolTip(this.btnOk, "Make accion");
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(79, 71);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 12;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(22, 74);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Cost";
            // 
            // mnuEdit
            // 
            this.mnuEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuUpdate,
            this.mnuRemove});
            this.mnuEdit.Location = new System.Drawing.Point(0, 0);
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(350, 24);
            this.mnuEdit.TabIndex = 15;
            this.mnuEdit.Text = "menuStrip1";
            this.mnuEdit.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuEdit_ItemClicked);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(41, 20);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.ToolTipText = "Add an Item";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(57, 20);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.ToolTipText = "Update an Item";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuRemove
            // 
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(62, 20);
            this.mnuRemove.Text = "Remove";
            this.mnuRemove.ToolTipText = "Remove an Item";
            this.mnuRemove.Click += new System.EventHandler(this.mnuRemove_Click);
            // 
            // ofdEdit
            // 
            this.ofdEdit.FileName = "openFileDialog1";
            // 
            // grpTxt
            // 
            this.grpTxt.Controls.Add(this.txtName);
            this.grpTxt.Controls.Add(this.txtCost);
            this.grpTxt.Controls.Add(this.lblName);
            this.grpTxt.Controls.Add(this.lblCost);
            this.grpTxt.Controls.Add(this.lblQuantity);
            this.grpTxt.Controls.Add(this.txtQuantity);
            this.grpTxt.Location = new System.Drawing.Point(130, 32);
            this.grpTxt.Name = "grpTxt";
            this.grpTxt.Size = new System.Drawing.Size(200, 100);
            this.grpTxt.TabIndex = 16;
            this.grpTxt.TabStop = false;
            this.grpTxt.Text = "Fill All Textboxes";
            // 
            // errProviderEdit
            // 
            this.errProviderEdit.ContainerControl = this;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 323);
            this.Controls.Add(this.grpTxt);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.pbxPictureItem);
            this.Controls.Add(this.stpEdit);
            this.Controls.Add(this.mnuEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.stpEdit.ResumeLayout(false);
            this.stpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPictureItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.mnuEdit.ResumeLayout(false);
            this.mnuEdit.PerformLayout();
            this.grpTxt.ResumeLayout(false);
            this.grpTxt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stpEdit;
        private System.Windows.Forms.PictureBox pbxPictureItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.MenuStrip mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.ToolTip ttEdit;
        private System.Windows.Forms.OpenFileDialog ofdEdit;
        private System.Windows.Forms.GroupBox grpTxt;
        private System.Windows.Forms.ErrorProvider errProviderEdit;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.TextBox txtCost;
        public System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.ToolStripStatusLabel tssStatusLabel;
    }
}