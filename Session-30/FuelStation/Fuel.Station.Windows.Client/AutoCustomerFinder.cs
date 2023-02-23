using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel.Station.Windows.Client
{
    public partial class AutoCustomerFinder : Form
    {
        private readonly HttpClient client;

        public AutoCustomerFinder()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
