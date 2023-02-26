using Fuel.Station.Blazor.Shared;
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

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            btnFind.Enabled = false;
            string inputText = boxCustomerFind.Text;

            _ = FormFinderController(inputText);
        }

        private async Task FormFinderController(string input)
        {
            var customer = await CustomerDetails(input);
            if (customer != null)
            {
                OpenTransactionsForm(customer);
            }
            else
            {
                OpenCustomersForm();
            }
        }

        private void OpenTransactionsForm(CustomerListDto item)
        {
            this.Hide();

            Transactions formMenu = new Transactions(/*item*/);

            formMenu.FormClosed += (s, args) => this.Close();
            formMenu.ShowDialog();
        }

        private void OpenCustomersForm()
        {
            MessageBox.Show("Customer not found! Please insert new customer.", "Message");
            this.Hide();
            Customer formMenu = new Customer();
            formMenu.FormClosed += (s, args) => this.Close();
            formMenu.ShowDialog();
        }

        private async Task<CustomerListDto?> CustomerDetails(string cardnumber)
        {

            var response = await client.GetAsync($"customer/cardnumber/{cardnumber}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<CustomerListDto>();
            }
            return null;
        }
    }
}
