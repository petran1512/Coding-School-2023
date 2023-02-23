using Fuel.Station.Blazor.Shared;
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

namespace Fuel.Station.Windows.Client
{
    public partial class Items : Form
    {
        private readonly HttpClient client;
        public Items()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void Items_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();

        }

        private async Task SetControlProperties()
        {
            itemBindingSource.DataSource = await GetItems();
            grvItems.DataSource = itemBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<List<ItemListDto?>> GetItems()
        {
            var response = await client.GetFromJsonAsync<List<ItemListDto?>>("item");
            return response.ToList();
        }
    }
}
