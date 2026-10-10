using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuiteAtticFilmsEsoft
{
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DISON_PC\SQLEXPRESS;Initial Catalog=Esoft_Quite_Attic_Films;Integrated Security=True");

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string F_name = txtFirstName.Text;
                string L_name = txtLastName.Text;
                string NIC = txtNIC.Text;
                string Email = txtEmail.Text;
                string Contact_NO = txtContactNO.Text;
                string Responsibility = txtResponsibility.Text;
                string House_NO = txtHomeNO.Text;
                string Lane_Name = txtLaneName.Text;
                string City = txtCity.Text;
                string Fee_Per_Day = txtFeePerDy.Text;
                string Note = txtNotes.Text;

                string query_insert = "INSERT INTO Staff (F_name, L_name, NIC, Email, Contact_NO, House_NO, Lane_Name, City, Fee_Per_Day, Note) " +
                                      "VALUES ('" + F_name + "', '" + L_name + "', '" + NIC + "', '" + Email + "', '" + Contact_NO + "', '" +
                                      House_NO + "', '" + Lane_Name + "', '" + City + "', '" + Fee_Per_Day + "', '" + Note + "')";

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Insert Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void StaffPage_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_select = "SELECT * FROM Staff";
                SqlCommand cmnd = new SqlCommand(query_select, con);
                SqlDataReader row = cmnd.ExecuteReader();
                comboBoxStaffID.Items.Add("Staff_ID");
                while (row.Read())
                {
                    comboBoxStaffID.Items.Add(row[0].ToString());
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
            comboBoxStaffID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNIC.Text = "";
            txtEmail.Text = "";
            txtContactNO.Text = "";
            txtResponsibility.Text = "";
            txtHomeNO.Text = "";
            txtLaneName.Text = "";
            txtCity.Text = "";
            txtFeePerDy.Text = "";
            txtNotes.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string Staff_ID = comboBoxStaffID.Text;

                string query_delete = "DELETE FROM Staff WHERE Staff_ID = " + Staff_ID;

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

        private void btnUpate_Click(object sender, EventArgs e)
        {
            string Staff_ID = comboBoxStaffID.Text;
            if (Staff_ID != "New Register")
            {
                string F_name = txtFirstName.Text;
                string L_name = txtLastName.Text;
                string NIC = txtNIC.Text;
                string Email = txtEmail.Text;
                string Contact_NO = txtContactNO.Text;
                string Responsibility = txtResponsibility.Text;
                string House_NO = txtHomeNO.Text;
                string Lane_Name = txtLaneName.Text;
                string City = txtCity.Text;
                string Fee_Per_Day = txtFeePerDy.Text;
                string Note = txtNotes.Text;
                string query_insert = "UPDATE Staff SET F_name = '" + F_name + "',L_name = '" + L_name + "',NIC = '" + NIC + "',Email = '" + Email + "',Contact_NO = '" + Contact_NO + "',Responsibility = '" + Responsibility + "',House_NO = '" + House_NO + "',Lane_Name = '" + Lane_Name + "',City = '" + City + "',Fee_Per_Day=  '" + Fee_Per_Day + "',Note = '" + Note + "' WHERE Staff_ID = " + Staff_ID;

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStaffID = comboBoxStaffID.Text;
            if (selectedStaffID != "New Register")
            {
                try
                {
                    con.Open();
                    string query_select = "SELECT * FROM Staff WHERE Staff_ID = @StaffID";
                    SqlCommand cmnd = new SqlCommand(query_select, con);
                    cmnd.Parameters.AddWithValue("@StaffID", selectedStaffID);
                    SqlDataReader reader = cmnd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["F_name"].ToString();
                        txtLastName.Text = reader["L_name"].ToString();
                        txtNIC.Text = reader["NIC"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtContactNO.Text = reader["Contact_NO"].ToString();
                        txtResponsibility.Text = reader["Responsibility"].ToString();
                        txtHomeNO.Text = reader["House_NO"].ToString();
                        txtLaneName.Text = reader["Lane_Name"].ToString();
                        txtCity.Text = reader["City"].ToString();
                        txtFeePerDy.Text = reader["Fee_Per_Day"].ToString();               
                        txtNotes.Text = reader["Note"].ToString();
                    }
                    else
                    {

                    }
                    con.Close();
                    btnSave.Enabled = false;
                    btnUpate.Enabled = true;
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
                btnUpate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
