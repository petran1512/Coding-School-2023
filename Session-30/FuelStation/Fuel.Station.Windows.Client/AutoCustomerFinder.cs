using Fuel.Station.Blazor.Client.Pages.Customers;
using Fuel.Station.Blazor.Client.Pages.Transactions;
using Fuel.Station.Blazor.Shared;
using Fuel.Station.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fuel.Station.Windows.Client
{
    public partial class AutoCustomerFinder : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly HttpClient client;



        public AutoCustomerFinder()
        {
 
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            //btnFind.Enabled = false;
            //string inputText = boxCustomerFind.Text;
            //boxCustomerFind.Refresh();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //customers = await httpClient.GetFromJsonAsync<List<CustomerListDto>>("customer");
            //Guid foundID = Guid.Empty;
            //bool found = false;

            //CustomerListDto foundcus = new();
            //foreach (var cus in customers)
            //{

            //    if (cus.CardNumber.ToString() == boxCustomerFind.Text.ToString())
            //    {
            //        foundcus = cus;
            //        found = true;
            //        break;
            //    }
            //}
            //if (found && foundcus != null)
            //{
            //    MessageBox.Show("Customer Found!\n" + foundcus.Name + " " + foundcus.Surname);
            //    var trForm = new Transactions(_loginStatus.EmployeeID, foundcus.Id);
            //    trForm.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Customer not Found!\n");
            //    var form = new CustomerEditF(null);
            //    form.ShowDialog();
            //    customers = await httpClient.GetFromJsonAsync<List<CustomerListDto>>("customer");
            //    var trForm = new Transactions(_loginStatus.EmployeeID, customers.Where(c => c.CardNumber == form.resultCustomer.CardNumber).Select(c => c.ID).SingleOrDefault());
            //    trForm.ShowDialog();
            //}
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
            //MessageBox.Show("Customer not found! Please insert new customer.", "Message");
            //this.Hide();
            //Customer formMenu = new Customer();
            //formMenu.FormClosed += (s, args) => this.Close();
            //formMenu.ShowDialog();
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

        private void boxCustomerFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutoCustomerFinder_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
