using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel.Station.Windows.Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text== "manager" && txtPassword.Text=="manager")
            {
                new Manager().Show();
                this.Hide();
            }
            else if (txtUserName.Text == "cashier" && txtPassword.Text == "cashier")
            {
                new Cashier().Show();
                this.Hide();
            }
            else if (txtUserName.Text == "staff" && txtPassword.Text == "staff")
            {
                new Staff().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password please try again.");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
