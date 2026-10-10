using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuiteAtticFilmsEsoft
{
    public partial class ClientPage : Form
    {
        private string selectedGeneder;
        private string connectingString;

        public SqlConnection Con { get; private set; }
        public ClientPage()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            connectingString = "Data Source=DISON_PC\\SQLEXPRESS;Initial Catalog=Esoft_Quite_Attic_Films;Integrated Security=True";
            Con = new SqlConnection(connectingString);
            Con.Open();
            {
                if (radioButtonCardPayment.Checked)
                {
                    Payment_Method = "Card Payment";
                }
                else if (radioButtonCardlessPayment.Checked)
                {
                    Payment_Method = "Cardless Payment";
                }

                string Command1 = "INSERT INTO Client Values ()";
                SqlConnection COnn = new SqlConnection(connectionString);
                SqlCommand comm1 = new SqlCommand(Command1, COnn);

                comm1.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                Con.Close();
            }
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_select = "SELECT * FROM Client";
                SqlCommand cmnd = new SqlCommand(query_select, con);
                SqlDataReader row = cmnd.ExecuteReader();
                comboBoxClientID.Items.Add("Client_ID");
                while (row.Read())
                {
                    comboBoxClientID.Items.Add(row[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Loading Data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxClientID.Text = "";

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNIC.Text = "";
            txtEmail.Text = "";
            txtHomeNO.Text = "";
            txtLaneName.Text = "";
            txtCity.Text = "";
            txtNotes.Text = "";

            txtContactNO.Text = "";
            txtClientContactNO.Text = "";

            radioButtonCardPayment.Checked = false;
            radioButtonCardlessPayment.Checked = false;
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Client_ID = comboBoxClientID.Text;
            if (Client_ID != "New Register")
            {

                string F_name = txtFirstName.Text;
                string L_name = txtLastName.Text;
                string NIC = txtNIC.Text;
                string Email = txtEmail.Text;
                string House_NO = txtHomeNO.Text;
                string Lane_Name = txtLaneName.Text;
                string City = txtCity.Text;
                string Payment_Method;
                if (radioButtonCardPayment.Checked)
                {
                    Payment_Method = "Card payment";
                }
                else
                {
                    Payment_Method = "Cardless payment";
                }
                string Contact_NO = txtContactNO.Text;

                string Note = txtNotes.Text;
                string query_insert = "UPDATE Client SET F_name = '" + F_name + "',L_name = '" + L_name + "',NIC = '" + NIC + "',Email = '" + Email + "',Contact_NO = '" + Contact_NO + "',House_NO = '" + House_NO + "',Lane_Name = '" + Lane_Name + "',City = '" + City + "',Payment_Method =  '" + Payment_Method + "',Note = '" + Note + "' WHERE Client_ID = " + Client_ID;

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string Client_ID = comboBoxClientID.Text;

                string query_delete = "DELETE FROM Client WHERE Client_ID = " + Client_ID;

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_delete, con);
                cmnd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted Successfully!", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void comboBoxClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClientID = comboBoxClientID.Text;
            if (selectedClientID != "New Register")
            {
                try
                {
                    con.Open();
                    string query_select = "SELECT * FROM Client WHERE Client_ID = @ClientID";
                    SqlCommand cmnd = new SqlCommand(query_select, con);
                    cmnd.Parameters.AddWithValue("@ClientID", selectedClientID);
                    SqlDataReader reader = cmnd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["F_name"].ToString();
                        txtLastName.Text = reader["L_name"].ToString();
                        txtNIC.Text = reader["NIC"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtContactNO.Text = reader["Contact_NO"].ToString();
                        //txtClientContactNO.Text = reader["Contact_NO"].ToString();
                        txtHomeNO.Text = reader["House_NO"].ToString();
                        txtLaneName.Text = reader["Lane_Name"].ToString();
                        txtCity.Text = reader["City"].ToString();

                        string paymentMethod = reader["Payment_Method"].ToString();
                        if (paymentMethod == "Card_Payments")
                        {
                            radioButtonCardPayment.Checked = true;
                            radioButtonCardlessPayment.Checked = false;
                        }
                        else 
                        {
                            radioButtonCardlessPayment.Checked = true;
                            radioButtonCardPayment.Checked = false;
                        }

                        txtNotes.Text = reader["Note"].ToString();
                    }
                    else
                    {

                    }
                    con.Close();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnSave.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you wanna go back...?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                HomePage obj = new HomePage();
                obj.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really wanna exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnContactNOAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string Contact_NO = txtContactNO.Text;

                string query_insert = "INSERT INTO Client_Contact (Contact_NO) " + "VALUES (, '" + Contact_NO + "')";

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void btnContactNOAdd2_Click(object sender, EventArgs e)
        {
            try
            {

                string Contact_NO = txtClientContactNO.Text;

                string query_insert = "INSERT INTO Client_Contact (Contact_NO) " + "VALUES ('" + Contact_NO + "')";

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            { 
                
            }
            finally
            {
                con.Close();
            }
        }
    }
}
