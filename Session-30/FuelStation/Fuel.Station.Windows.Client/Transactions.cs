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
    public partial class Transactions : Form
    {
        private readonly HttpClient client;

        public Transactions()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
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

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            transactionBindingSource.DataSource = await GetTransactions();
            grvTransactions.DataSource = transactionBindingSource;

            transactionlineBindingSource.DataSource = await GetTransactionLines();
            grvTransactionLines.DataSource = transactionlineBindingSource;
        }

        private async Task<List<TransactionListDto?>> GetTransactions()
        {
            var response = await client.GetFromJsonAsync<List<TransactionListDto?>>("transaction");
            return response.ToList();
        }

        private async Task<List<TransactionLineListDto?>> GetTransactionLines()
        {
            var response = await client.GetFromJsonAsync<List<TransactionLineListDto?>>("transactionline");
            return response.ToList();
        }
    }
}

