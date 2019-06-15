using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Lara_FinalProject
{
    class csDataBase
    {
        //connection string
        //  private const string CONNECT_STRING = "Server = gaming.tstc.edu;database = CLaraCSFinal; User ID = CLara;Password = 1617180";
        private const string CONNECT_STRING = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
        //connection
        private static SqlConnection cnt = new SqlConnection(CONNECT_STRING);
        //dataadapter
        private static SqlDataAdapter _daAdapter = new SqlDataAdapter();
        //sql command
        private static SqlCommand cmd = new SqlCommand();
        //creates a subs table dataset
        public static DataSet ds_CLaraCSFinal { get; set; } = new DataSet();
        //creates a data table of subs tables
        public static string dt_Managers { get; set; } = "Managers";
        //creates a subs table dataset
        public static string dt_Items { get; set; } = "Items";
        
        //Create tables
        public static void SellectAllItems()
        {
            try
            {
                //first thing open database
                cnt.Open();
                //clear dataset
                ds_CLaraCSFinal.Clear();
                // SQL statement to query all records for a single table.
                cmd.CommandText = "SELECT * FROM Items";
                //puts command on the data adapter
                _daAdapter.SelectCommand = cmd;
                //makes a conection to the comand
                cmd.Connection = cnt;
                // Open data connection           
                _daAdapter.Fill(ds_CLaraCSFinal, dt_Items);
                // Close the data connection
                cnt.Close();
            }
            catch (Exception ex)
            {
                cnt.Close();
                MessageBox.Show("Items DB Table Access Failed\n\n" + ex.Message);
            }
        }

        public static void SellectAllManagers()
        {
            try
            {
                //first thing open database
                cnt.Open();
                //clear dataset
                ds_CLaraCSFinal.Clear();
                // SQL statement to query all records for a single table.
                cmd.CommandText = "SELECT * FROM Managers";
                //puts command on the data adapter
                _daAdapter.SelectCommand = cmd;
                //makes a conection to the comand
                cmd.Connection = cnt;
                // Open data connection           
                _daAdapter.Fill(ds_CLaraCSFinal, dt_Managers);
                // Close the data connection
                cnt.Close();
            }
            catch (Exception ex)
            {
                cnt.Close();
                MessageBox.Show("Managers DB Table Access Failed\n\n" + ex.Message);
            }
        }

        public static void formatGrid(DataGridView dgv)
        {
            //disable most function to manipullate the grid
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Cursor = Cursors.Hand;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowDrop = false;
            dgv.MultiSelect = false;
            foreach (DataGridViewColumn column in dgv.Columns)
            {//disables sort property and makes all of the columns invisible
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //reenables the movieid and movie name 
            dgv.Columns[0].Visible = false;
            //dgv.Columns[4].Visible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ClearSelection();
        }

        public static void Register(string fname, string lName, string user, string pass)
        {//runs the register query and inserts the new manager data into the database
            try
            {
                cnt.Open();
                //sql qury
                SqlCommand cmdRegister = new SqlCommand("INSERT INTO Managers Values((SELECT MAX(ManagerID) FROM Managers)+1,@fName,@lName,@un,@pass)", cnt);
                //parameters
                cmdRegister.Parameters.AddWithValue("@fName", fname);
                cmdRegister.Parameters.AddWithValue("@lName", lName);
                cmdRegister.Parameters.AddWithValue("@un", user);
                cmdRegister.Parameters.AddWithValue("@pass", pass);
                cmdRegister.ExecuteNonQuery();
                cnt.Close();
            }
            catch (Exception ex)
            {
                cnt.Close();
                MessageBox.Show("Registration Failed\n\n" + ex.Message);
            }
        }

        public static void UpdateItem(string name,string quantity,string cost,byte[] image,int currentRow)
        {//runs the update query to update a row from the database
            try
            {
                // Get row clicked on in dgvMembers and display the row number
                int cRow = currentRow;//dgvItems.CurrentRow.Index;
                string tempID = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[cRow][0].ToString();
                cnt.Open();
                //sql query
                SqlCommand cmdUpdate = new SqlCommand("UPDATE Items SET ItemName = @name,"
                    + "ItemQuantity = @iq, ItemCost = @ic, ItemImage = @ii WHERE ItemID = @id;", cnt);
                cmdUpdate.Parameters.AddWithValue("@id", tempID);
                cmdUpdate.Parameters.AddWithValue("@name", name);
                cmdUpdate.Parameters.AddWithValue("@iq", quantity);
                cmdUpdate.Parameters.AddWithValue("@ic", cost);
                cmdUpdate.Parameters.AddWithValue("@ii", image);
                cmdUpdate.ExecuteNonQuery();
                cnt.Close();
            }
            catch (Exception ex)
            {
                cnt.Close();
                MessageBox.Show("Update DB Row Table Access Failed\n\n" + ex.Message);
            }
        }

        public static void AddItem(string name, string quantity, string cost, byte[] image)
        {//runs the update query to update a row from the database
            try
            {
                cnt.Open();
                //sql query
                SqlCommand cmdUpdate = new SqlCommand("INSERT INTO Items (ItemID,ItemName,ItemQuantity,ItemCost,ItemImage)"
                    + "values ((SELECT MAX(ItemID) FROM Items)+1, @name, @iq, @ic, @ii);", cnt);
                //parameters
                cmdUpdate.Parameters.AddWithValue("@name", name);
                cmdUpdate.Parameters.AddWithValue("@iq", quantity);
                cmdUpdate.Parameters.AddWithValue("@ic", cost);
                cmdUpdate.Parameters.AddWithValue("@ii", image);
                cmdUpdate.ExecuteNonQuery();
                cnt.Close();
            }
            catch (Exception ex)
            {
                cnt.Close();
                MessageBox.Show("Update DB Row Table Access Failed\n\n" + ex.Message);
            }
        }

        public static void RemoveItem(int currentRow)
        {//removes an item from the database
            try
            {
                // Get row clicked on in dgvMembers and display the row number
                int cRow = currentRow;
                //gets the id of the current selected row
                string tempID = csDataBase.ds_CLaraCSFinal.Tables[csDataBase.dt_Items].Rows[cRow][0].ToString();
                cnt.Open();
                //sql query
                SqlCommand cmdUpdate = new SqlCommand("DELETE FROM Items where ItemID = @id;", cnt);
                //parameters
                cmdUpdate.Parameters.AddWithValue("@id", tempID);
                cmdUpdate.ExecuteNonQuery();
                cnt.Close();
            }
            catch (Exception ex)
            {
                cnt.Close();
                MessageBox.Show("Update DB Row Table Access Failed\n\n" + ex.Message);
            }
        }

        public static void UpdateItemQuantity(string id,string quantity)
        {//UpdateStatus the quantity when user buys a fruit
            try
            {
                cnt.Open();
                //sql query
                SqlCommand cmdUpdate = new SqlCommand("UPDATE Items SET ItemQuantity = @iq WHERE ItemID = @id;", cnt);
                //parameters
                cmdUpdate.Parameters.AddWithValue("@id", id);
                cmdUpdate.Parameters.AddWithValue("@Iq", quantity);
                cmdUpdate.ExecuteNonQuery();
                cnt.Close();
            }
            catch (Exception ex)
            {
                cnt.Close();
                MessageBox.Show("Update DB Row Table Access Failed\n\n" + ex.Message);
            }
        }



    }
}
