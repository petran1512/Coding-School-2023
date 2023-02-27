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
using System.Xml.Linq;

namespace Fuel.Station.Windows.Client
{
    public partial class AutoCustomerFinder : Form
    {
        private readonly HttpClient client;
        private CustomerEditDto _customerEditDto;
        private CustomerListDto _customerListDto;
        public CustomerEditDto outCustomer = new();


        public AutoCustomerFinder(CustomerListDto customerListDto)
        {
            _customerListDto = customerListDto;
            _customerEditDto= new CustomerEditDto();
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            //btnFind.Enabled = false;
            //string inputText = boxCustomerFind.Text;
            AutoCN();
            boxCustomerFind.Refresh();
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

        private void boxCustomerFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutoCustomerFinder_Load(object sender, EventArgs e)
        {
            Finder();
        }

        private async Task Finder()
        {
            if (_customerListDto != null)
            {
                if (_customerListDto.Id != null)
                {
                    try
                    {

                        _customerEditDto = await HttpClient.GetFromJsonAsync<_customerEditDto>($"customer/{_customerListDto.Id}");
                        boxCustomerFind.ReadOnly = true;
                        boxCustomerFind.Text = _customerEditDto.CardNumber;
                        Finder();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }

        private void UpdateFinder()
        {
            boxCustomerFind.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AutoCN()
        {
            if (_customerEditDto.Id == Id.Empty)
            {
                string guidString = Guid.NewGuid().ToString().Replace("-", "");
                guidString = "A" + guidString;

                if (guidString.Length > 20)
                {
                    guidString = guidString.Substring(0, 20);
                }
                boxCustomerFind.Text = guidString;
            }
            else { MessageBox.Show("Customer Already Has a Card!"); }
        }

    }
}
