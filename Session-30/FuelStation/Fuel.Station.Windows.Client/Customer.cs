using Fuel.Station.Blazor.Shared;
using Fuel.Station.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;

namespace Fuel.Station.Windows.Client
{
    public partial class Customer : Form
    {
        private readonly HttpClient client;



        public Customer()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            customerBindingSource.DataSource = await GetCustomers();
            grvCustomers.DataSource = customerBindingSource;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<List<CustomerListDto?>> GetCustomers()
        {
            var response = await client.GetFromJsonAsync<List<CustomerListDto?>>("customer");
            return response.ToList();   
        }
    }
}
