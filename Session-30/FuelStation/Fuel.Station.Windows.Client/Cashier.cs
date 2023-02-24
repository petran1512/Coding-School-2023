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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            new Items().Show();
            this.Hide();
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
