using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_FinalProject
{
    public partial class frmEdit : Form
    {
        csValidation v=  new csValidation();
        Image img;//stores the image to pass between panels
        string path = "";//used to change cursor image
        public frmEdit()
        {
            InitializeComponent();
        }
        
        private void frmEdit_Load(object sender, EventArgs e)
        {//starts application on view mode a load all data
            ViewMode();
            csDataBase.SellectAllItems();
            //displays info on the dataset to the dgv
            dgvItems.DataSource = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items];
            csDataBase.formatGrid(dgvItems);
        }

        private void pbxPictureItem_Click(object sender, EventArgs e)
        {//when picturebox is clicke a diolofbox shows to choose an image
            try
            {//trys to get image from dialog box
                ofdEdit.InitialDirectory = @"..\..\Graphics";
                ofdEdit.Filter = "Image File(*.png;*.ico)|*.png;*.ico|All files (*.*)|*.*";
                //if showdialog is ok then the picture is added
                if (ofdEdit.ShowDialog() == DialogResult.OK)
                {
                    img = Image.FromFile(ofdEdit.FileName);
                    pbxPictureItem.Image = img;
                    pbxPictureItem.SizeMode = PictureBoxSizeMode.StretchImage;
                    path = pbxPictureItem.ImageLocation;
                }
            }
            //else an exeption is catched and the picturebox remains the same
            catch (Exception)
            {
                //handles error when dialog box is canceled
                img = pbxPictureItem.Image;
            }
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {//gets into add item mode enablling textboxes and clearing them
            btnOk.Text = "Add";
            btnCancel.Enabled = true;
            btnOk.Enabled = true;
            v.TextBoxes(grpTxt, "Enabled");
            v.TextBoxes(grpTxt, "Clear");
            pbxPictureItem.Enabled = true;
            pbxPictureItem.ImageLocation = @"..\..\Graphics\No-image-found.jpg";
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {//gets into update item mode enablling textboxes
            btnOk.Text = "Update";
            btnCancel.Enabled = true;
            btnOk.Enabled = true;
            v.TextBoxes(grpTxt, "Enabled");
            pbxPictureItem.Enabled = true;
        }

        private void mnuRemove_Click(object sender, EventArgs e)
        {//gets into remove item mode changing the ok text button to Remove
            btnOk.Text = "Remove";
            btnCancel.Enabled = true;
            btnOk.Enabled = true;
            pbxPictureItem.Enabled = true;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //view mode
            ViewMode();
            btnOk.Enabled = false;
            btnCancel.Enabled = false;
            btnOk.Text = "Ok";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (v.EmptyTxt(grpTxt,errProviderEdit) == 0 && path != "")
            {//if invalud function is false this runs
                if (btnOk.Text == "Update")
                {//if the button text is update. we update the current row with the current selected student id
                    csDataBase.UpdateItem(txtName.Text,txtQuantity.Text,txtCost.Text, v.ConvertImageToBinary(img), dgvItems.CurrentRow.Index);
                    tssStatusLabel.Text = "(1) Row Updated";
                }
                else if (btnOk.Text == "Add")
                {//if the button is add . the program adds the values in the textboxes to the dataset
                    csDataBase.AddItem(txtName.Text,txtQuantity.Text,txtCost.Text,v.ConvertImageToBinary(img));
                    tssStatusLabel.Text = "(1) Row Added";
                }
                else if(btnOk.Text == "Remove")
                {
                    csDataBase.RemoveItem(dgvItems.CurrentRow.Index);
                    tssStatusLabel.Text = "(1) Row Removed";
                }
                //call the load function to reload dgv
                frmEdit_Load(null,null);
                btnCancel.Enabled = false;
                btnOk.Enabled = false;
            }
            else
            {
                tssStatusLabel.Text = "Make sure To fill All data and add an image";
            }
        }

        //*************FUNCTIONS

    

        public void ViewMode()
        {//this functions resets the for to view mode after an edit is made and when the form loads
            v.TextBoxes(grpTxt, "Disabled");
            mnuUpdate.Enabled = false;
            mnuRemove.Enabled = false;
            txtName.Focus();
            pbxPictureItem.Enabled = false;
        }

        
        public void DisplayTo_txt()
        {
            // Get row clicked on in dgvMembers and display the row number
            int cRow = dgvItems.CurrentRow.Index;
            // Display record clicked message
            txtName.Text = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[cRow][1].ToString();
            txtQuantity.Text = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[cRow][2].ToString();
            txtCost.Text = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[cRow][3].ToString();
            try
            {
                byte[] tempImage = (byte[])csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[cRow][4];
                pbxPictureItem.Image = v.ConvertBinaryToImage(tempImage);
            }
            catch (Exception)
            {
                pbxPictureItem.ImageLocation = @"..\..\Graphics\No-image-found.jpg";
            }
            
        }

        private void dgvItems_MouseClick(object sender, MouseEventArgs e)
        {//displays text and enables update and remove
            DisplayTo_txt();
            mnuUpdate.Enabled = true;
            mnuRemove.Enabled = true;
        }

        private void frmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {//opens main application
            Application.OpenForms[0].Show();
        }

        private void mnuEdit_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {//changes status to none
            tssStatusLabel.Text = "";
        }
    }
}
