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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (Username == "Admin" && Password == "Admin@123")
            {
                this.Hide();
                HomePage obj = new HomePage();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Inavlid login in credentials, Please check username and password and try again !", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you wanna go back...?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 obj = new Form1();
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
    }
}
