using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_FinalProject
{
    struct Item
    {//stores all the item properties
        public int id;
        public string name;
        public int quantity;
        public double cost;
        public byte[] image;
        public int soldCount;
        public string iTag;
        public bool updated;
    }

    public partial class frmMain : Form
    {
        csValidation v = new csValidation();
        csDataBase cs = new csDataBase();
        List<Item> itemList = new List<Item>();//list of users
        Item ite = new Item();//neede to pass to the list
        string recipt;//hold the recipt string
        double total;//holds the running total
        Image newImage = Image.FromFile(@"..\..\\Graphics\\No-image-found.jpg");
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {//loads images and user data from database
            csDataBase.SellectAllItems();
            for (int i = 0; i < csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows.Count; i++)
            {//fills the structure user
                ite.id = (int)csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[i][0];
                ite.name = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[i][1].ToString();
                ite.quantity = (int)csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[i][2];
                ite.cost = double.Parse(csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[i][3].ToString());
                try
                {
                    ite.image = (byte[])csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[i][4];
                }
                catch (Exception)
                {
                    ite.image = v.ConvertImageToBinary(newImage);
                    //MessageBox.Show("gotcha");
                }
                ite.iTag = i.ToString();
                ite.updated = false;
                ite.soldCount = 0;
                //adds a user to the list
                itemList.Add(ite);
                AddPicture(pnlItemsInStock.Controls, 80, 80, v.ConvertBinaryToImage(ite.image), i.ToString());
            }
            rtbxDetails.Enabled = false;
            lbxOrderDetails.Enabled = false;
            lblTotal.Text = "Total: $" + total.ToString();
        }

        private void AddPicture(Control.ControlCollection cc, int x, int y, Image img, string taggo)
        {//adds a picturebox to the stock panel in the right
            PictureBox pbx = new PictureBox();
            pbx.BackgroundImage = img;
            pbx.BackgroundImageLayout = ImageLayout.Zoom;
            pbx.Tag = taggo;
            pbx.Width = x;
            pbx.Height = y;
            cc.Add(pbx);
            int index = Int32.Parse(taggo);
            pbx.Click += new EventHandler((s, e) => Click_AddToBlendPanel(s, e, 80,80,v.ConvertBinaryToImage(itemList[index].image),taggo,index));
            pbx.MouseEnter += new EventHandler((s, e) => MouseEnter_ShowDetails(s,e,index));
            pbx.MouseLeave += new EventHandler((s, e) => MouseLeave_defaultCursor(s, e));
        }
        
        private void MouseEnter_ShowDetails(object s, EventArgs e, int index)
        {//when mouse enters to a picturebox it shows the object details
            this.Cursor = new Cursor("..\\..\\Graphics\\plus.cur");
            rtbxDetails.Text = "Name: "+ itemList[index].name + "\nQuantity: "+ itemList[index].quantity + "\nCost: $"+ itemList[index].cost;
        }

        private void MouseLeave_defaultCursor(object s, EventArgs e)
        {//when cursor gets out of the pictures it displays the normal cursor
            this.Cursor = new Cursor("..\\..\\Graphics\\arrow-pointer.cur");
        }
        
        private void Click_AddToBlendPanel(object s, EventArgs e, int x, int y, Image img, string taggo, int index)
        {//when you click a picture in the right panel a copy of that is added to the left panel
            PictureBox pbx = new PictureBox();
            pbx.BackgroundImage = img;
            pbx.BackgroundImageLayout = ImageLayout.Zoom;
            pbx.Tag = taggo;
            pbx.Width = x;
            pbx.Height = y;
            pnlItemsInBlender.Controls.Add(pbx);
            pbx.Click += new EventHandler((ss, ee) => Click_RemoveToBlendPanel(s, e, pnlItemsInBlender.Controls, pbx,index));
            pbx.MouseEnter += new EventHandler((ss, ee) => MouseEnter_RemoveHover(s, e, index));
            pbx.MouseLeave += new EventHandler((ss, ee) => MouseLeave_defaultCursor(s, e));
            updateItem(index, 0, itemList[index].quantity-1, itemList[index].soldCount + 1, ite);
            displayRecipt();
            rtbxDetails.Text = "Name: " + itemList[index].name + "\nQuantity: " + itemList[index].quantity + "\nCost: $" + itemList[index].cost;
        }
        
        private void MouseEnter_RemoveHover(object s, EventArgs e, int index)
        {//when user hovers over a picture in the left panel the cursor image is changed to a delete picture
            this.Cursor = new Cursor("..\\..\\Graphics\\delete.cur");
            rtbxDetails.Text = "Name: " + itemList[index].name + "\nQuantity: " + itemList[index].quantity + "\nCost: $" + itemList[index].cost;
        }

        private void Click_RemoveToBlendPanel(object ss, EventArgs ee, Control.ControlCollection cc2, PictureBox pbx,int index)
        {//when you click a picture in the left panel it gets rem,oved from the panel and from the list box in the left bottom part
            cc2.Remove(pbx);
            updateItem(index, 0, itemList[index].quantity + 1, itemList[index].soldCount - 1,ite);
            rtbxDetails.Text = "Name: " + itemList[index].name + "\nQuantity: " + itemList[index].quantity + "\nCost: $" + itemList[index].cost;
            displayRecipt();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {//makes sure application closes
            Application.Exit();
        }

        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {//closes application
            Application.Exit();
        }

        private void mnuEdit_Items_Click(object sender, EventArgs e)
        {//opens the login form to edit contents
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void mnuHelp_Demo_Click(object sender, EventArgs e)
        {//opens the video demo form 
            frmDemo frm = new frmDemo();
            frm.Show();
        }

        private void btnBlend_Click(object sender, EventArgs e)
        {//asks if user ants to gro thru with the order and commits changes
            DialogResult dialogResult = MessageBox.Show(recipt + "\nTotal: $" + total.ToString(), "Blend Juice?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {//if user click ok in the dialog result box
                SoundPlayer s = new SoundPlayer(@"...\...\Sounds\blender5.wav");
                s.PlaySync();
                SoundPlayer s2 = new SoundPlayer(@"...\...\Sounds\micro-bell.wav");
                s2.Play();
                //clears controls in the main form
                pnlItemsInBlender.Controls.Clear();
                rtbxDetails.Text = "";
                lbxOrderDetails.Items.Clear();
                total = 0;
                //loops all the list to see wich items have been added to the order
                for (int i = 0; i < itemList.Count; i++)
                {
                    if (itemList[i].soldCount > 0)
                    {//if items sold is more than 1 
                        //sets all solditem fields to 0 for next user
                        updateItem(i, 0, itemList[i].quantity, 0, ite);
                        //applies changes to database
                        int tempId = i + 1; 
                        csDataBase.UpdateItemQuantity(tempId.ToString(), itemList[i].quantity.ToString());
                    }
                }

                lblTotal.Text = "Total: $" + total.ToString();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                //do something else
            }
        }

        void displayRecipt()
        {//displays recipt in the list box order details 
            lbxOrderDetails.Items.Clear();
            recipt = "";
            total = 0;
            //loops all items
            for (int i = 0; i < itemList.Count; i++)
            {
                //if the current item has more than one on sold count it is added to the listbox
                if (itemList[i].soldCount > 0)
                {
                    lbxOrderDetails.Items.Add(itemList[i].soldCount + "\t" + itemList[i].name + "\t\t\t$" + itemList[i].cost * itemList[i].soldCount);
                    recipt += itemList[i].soldCount + "\t" + itemList[i].name + "\t\t\t$" + itemList[i].cost * itemList[i].soldCount + "\n";
                    total = total + itemList[i].cost * itemList[i].soldCount;
                }
            }
            //displays current total
            lblTotal.Text = "Total: $" + total.ToString();
        }

        void updateItem(int index, int sold, int quaDecre, int solIncre, Item ite)
        { //updates an item in the list
            //sets values and changes the item quantity
            ite.id = itemList[index].id;
            ite.name = itemList[index].name;
            ite.quantity = quaDecre;
            ite.cost = itemList[index].cost;
            ite.image = itemList[index].image;
            ite.iTag = itemList[index].iTag;
            ite.soldCount = solIncre;
            ite.updated = true;
            //removes the old item and adds the updated one
            itemList.RemoveAt(index);
            itemList.Insert(index, ite);
        }

        
    }//end of class
}
