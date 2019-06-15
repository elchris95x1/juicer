using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_FinalProject
{
    struct Manager
    {//stores the login info
        public string ManagerId;
        public string FirstName;
        public string LastName;
        public string UserName;
        public string Password;
    }
    public partial class frmLogin : Form
    {
        //*********Variables
        csValidation v = new csValidation();
        List<Manager> UserList = new List<Manager>();//list of users
        Manager u = new Manager();//neede to pass to the list
        bool validLogin = false;
        bool validPass = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {//load the data from databse to list and sets the textboxes
            txtPassword.UseSystemPasswordChar = true;
            txtAccessKey.UseSystemPasswordChar = true;
            csDataBase.SellectAllManagers();
            for (int i = 0; i < csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Managers].Rows.Count; i++)
            {//fills the structure user
                u.ManagerId = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Managers].Rows[i][0].ToString();
                u.FirstName = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Managers].Rows[i][1].ToString();
                u.LastName = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Managers].Rows[i][2].ToString();
                u.UserName = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Managers].Rows[i][3].ToString();
                u.Password = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Managers].Rows[i][4].ToString();
                //adds a user to the list
                UserList.Add(u);
            }
        }

        private void lblLoginOps_Click(object sender, EventArgs e)
        {//switxhes lo login mode
            lblLoginOps.ForeColor = SystemColors.GrayText;
            lblRegisterOps.ForeColor = SystemColors.Highlight;
            lblfName.Hide();
            txtfName.Hide();
            lbllName.Hide();
            txtlName.Hide();
            lblAccessKey.Hide();
            txtAccessKey.Hide();
            btnLogin.Text = "LogIn";
            txtfName.Focus();
            lblTitleLog.Text = "Please enter you login info";
        }

        private void lblRegisterOps_Click(object sender, EventArgs e)
        {//switcches to register mode
            lblRegisterOps.ForeColor = SystemColors.GrayText;
            lblLoginOps.ForeColor = SystemColors.Highlight;
            lblfName.Show();
            txtfName.Show();
            lbllName.Show();
            txtlName.Show();
            lblAccessKey.Show();
            txtAccessKey.Show();
            btnLogin.Text = "Register";
            txtfName.Focus();
            lblTitleLog.Text = "Please enter your info to Register";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {//if calces is clicked the form closes
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmEdit frm = new frmEdit();
            if (btnLogin.Text == "LogIn")
            {//if button = login this runs
                ValidLogIn();
                if (validLogin == true && validPass == true)
                {//if both are valid then the form main is displayed
                    frm.Show();
                    this.Close();
                }
                else
                {
                    tssStatus.Text = "FAILED! login";
                }
            }
            else if(btnLogin.Text == "Register")
            {//if button = register this runs
                if (v.EmptyTxt(grpTextboxes,errProviderTxt) == 0 && txtAccessKey.Text == "123")
                {//if all textboxes are filled and the accesc key is right this runs
                    //the manager is register
                    csDataBase.Register(txtfName.Text, txtlName.Text, txtUserName.Text, txtPassword.Text);
                    lblLoginOps_Click(null, null);
                    frmLogin_Load(null,null);
                }
                else
                {
                    tssStatus.Text = "Fill All Textboxes*";
                }
            }
        }
        
        private void chkViewPass_CheckedChanged(object sender, EventArgs e)
        {//lets us view the pass or acces key if user unchecks option
            if (chkViewPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtAccessKey.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtAccessKey.UseSystemPasswordChar = true;
            }
        }



        //********FUNCTIONS*****

        private void ValidLogIn()
        {//validates for old users
            for (int i = 0; i < UserList.Count; i++)
            {//for each record on the list this loops
                if (txtUserName.Text == UserList[i].UserName)
                {//if the input matches on of the usernames validlogin is true
                    errProviderTxt.SetError(txtUserName, "");
                    validLogin = true;
                    break;
                }
                else
                {
                    //else valid login is false and an error will appear
                    errProviderTxt.SetError(txtUserName, "Wrong User Name");
                    validLogin = false;
                }
            }

            for (int i = 0; i < UserList.Count; i++)
            {//for each record on the list this loops
                if (txtPassword.Text == UserList[i].Password && validLogin == true)
                {//if the input matches on of the password validlogin is true
                    errProviderTxt.SetError(txtPassword, "");
                    validPass = true;
                    break;
                }
                else
                {//else valid login is false and an error will appear
                    errProviderTxt.SetError(txtPassword, "Wrong Password");
                    validPass = false;
                }
            }
        }
        
    }//end of class
}
