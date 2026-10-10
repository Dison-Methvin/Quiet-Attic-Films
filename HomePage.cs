using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuiteAtticFilmsEsoft
{
    public partial class HomePage : Form
    {
        private string UserName { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(string name)
        {
            this.UserName = name;
            InitializeComponent();
            if (UserName == "Client")
            {
                btnStaffViewMore.Enabled = false;
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

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you wanna Logout...?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                RoleSelectionPage obj = new RoleSelectionPage();
                obj.Show();
            }
        }

        private void btnClientViewMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientPage obj = new ClientPage();
            obj.Show();
        }

        private void btnStaffViewMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffPage obj = new StaffPage();
            obj.Show();
        }

        private void btnProductionViewMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductionPage obj = new ProductionPage();
            obj.Show();
        }

        private void btnPropertiesViewMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropertiesPage obj = new PropertiesPage();
            obj.Show();
        }

        private void btnLocationViewMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationPage obj = new LocationPage();
            obj.Show();
        }

        private void btnPaymentViewMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentPage obj = new PaymentPage();
            obj.Show();
        }
    }
}
