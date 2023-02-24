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

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustCash().Show();
            this.Hide();
        }

        private void button1_Click_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoCustomerFinder trForm = new AutoCustomerFinder();

            trForm.FormClosed += (s, args) => this.Show();
            trForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
